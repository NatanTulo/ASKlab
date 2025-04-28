using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace _2_Reaktometr
{
    public partial class SimpleAcous : Form
    {
        public SimpleAcous()
        {
            InitializeComponent();
        }

        private void SimpleAcous_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            long timeSW = simAcousTimer.StopTest();
            _tone.Stop();
            if (timeSW != 0)
                this.label1.Text = "Czas: " + timeSW.ToString() + " ms";
            this.label1.ForeColor = Color.Black;
        }

        private async void SimpleAcous_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                _tone.Stop();
                this.Close();
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                this.BackColor = Color.White;
                this.label1.ForeColor = Color.Red;
                this.label1.Text = "Przygotuj się";
                await Task.Delay(new Random().Next(1000, 3000));
                _tone.Start(440);
                simAcousTimer.StartTest();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _tone.Stop();
        }

        private void SimpleAcous_Load(object sender, EventArgs e)
        {

        }
    }

    public class ContinuousTone
    {
        const int SAMPLE_RATE = 44100;
        const int BITS_PER_SAMPLE = 16;
        const int CHANNELS = 1;
        const int BUFFER_MS = 100; // długość bufora w ms
        const int BUFFER_SAMPLES = SAMPLE_RATE * BUFFER_MS / 1000;
        const int BUFFER_BYTES = BUFFER_SAMPLES * (BITS_PER_SAMPLE / 8);

        private IntPtr _hwo = IntPtr.Zero;
        private WAVEHDR[] _headers = new WAVEHDR[2];
        private GCHandle[] _pinHandles = new GCHandle[2];
        private byte[][] _buffers = new byte[2][];
        private bool _playing;
        private Thread _fillThread;

        // faza i przyrost fazy sinusoidy
        private double _phase;
        private double _phaseIncrement;

        #region WinMM P/Invoke

        private delegate void WaveOutProc(IntPtr hwo, uint uMsg, IntPtr dwInstance, IntPtr dwParam1, IntPtr dwParam2);

        [DllImport("winmm.dll", SetLastError = true)]
        private static extern int waveOutOpen(
            out IntPtr hWaveOut, IntPtr uDeviceID, ref WAVEFORMATEX pwfx,
            WaveOutProc dwCallback, IntPtr dwInstance, uint dwFlags);

        [DllImport("winmm.dll", SetLastError = true)]
        private static extern int waveOutPrepareHeader(IntPtr hwo, ref WAVEHDR pwh, uint cb);

        [DllImport("winmm.dll", SetLastError = true)]
        private static extern int waveOutWrite(IntPtr hwo, ref WAVEHDR pwh, uint cb);

        [DllImport("winmm.dll", SetLastError = true)]
        private static extern int waveOutUnprepareHeader(IntPtr hwo, ref WAVEHDR pwh, uint cb);

        [DllImport("winmm.dll", SetLastError = true)]
        private static extern int waveOutClose(IntPtr hwo);

        [StructLayout(LayoutKind.Sequential)]
        private struct WAVEHDR
        {
            public IntPtr lpData;
            public uint dwBufferLength;
            public uint dwBytesRecorded;
            public uint dwUser;
            public uint dwFlags;
            public uint dwLoops;
            public IntPtr lpNext;
            public IntPtr reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct WAVEFORMATEX
        {
            public ushort wFormatTag;
            public ushort nChannels;
            public uint nSamplesPerSec;
            public uint nAvgBytesPerSec;
            public ushort nBlockAlign;
            public ushort wBitsPerSample;
            public ushort cbSize;
        }

        #endregion

        /// <summary>
        /// Rozpoczyna odtwarzanie ciągłego tonu sinusoidalnego o zadanej częstotliwości (Hz).
        /// </summary>
        public void Start(double frequency)
        {
            if (_playing) return;
            _playing = true;

            // inicjalizacja fazy
            _phase = 0;
            _phaseIncrement = 2 * Math.PI * frequency / SAMPLE_RATE;

            // przygotuj format PCM
            var fmt = new WAVEFORMATEX
            {
                wFormatTag = 1, // PCM
                nChannels = CHANNELS,
                nSamplesPerSec = SAMPLE_RATE,
                wBitsPerSample = BITS_PER_SAMPLE,
                nBlockAlign = (ushort)(CHANNELS * BITS_PER_SAMPLE / 8),
                nAvgBytesPerSec = SAMPLE_RATE * CHANNELS * BITS_PER_SAMPLE / 8,
                cbSize = 0
            };

            // otwórz urządzenie audio
            int res = waveOutOpen(out _hwo, IntPtr.Zero, ref fmt, null, IntPtr.Zero, 0);
            if (res != 0) throw new Exception($"waveOutOpen failed: {res}");

            // przygotuj i wyrzuć oba bufory
            for (int i = 0; i < 2; i++)
            {
                _buffers[i] = new byte[BUFFER_BYTES];
                _pinHandles[i] = GCHandle.Alloc(_buffers[i], GCHandleType.Pinned);
                _headers[i] = new WAVEHDR
                {
                    lpData = _pinHandles[i].AddrOfPinnedObject(),
                    dwBufferLength = (uint)BUFFER_BYTES,
                    dwFlags = 0,
                    dwLoops = 0
                };

                waveOutPrepareHeader(_hwo, ref _headers[i], (uint)Marshal.SizeOf<WAVEHDR>());
                FillBuffer(i);
                waveOutWrite(_hwo, ref _headers[i], (uint)Marshal.SizeOf<WAVEHDR>());
            }

            // uruchom pętlę refillującą bufory
            _fillThread = new Thread(RefillLoop) { IsBackground = true };
            _fillThread.Start();
        }

        /// <summary>
        /// Pętla w tle: sprawdza flagę DONE i refiluje zakończone buforu natychmiast.
        /// </summary>
        private void RefillLoop()
        {
            int idx = 0;
            while (_playing)
            {
                // gdy WHDR_DONE (bit 0x00000001) jest ustawiony → bufor odtworzony
                if ((_headers[idx].dwFlags & 0x00000001) != 0)
                {
                    // odznacz i refill
                    waveOutUnprepareHeader(_hwo, ref _headers[idx], (uint)Marshal.SizeOf<WAVEHDR>());
                    FillBuffer(idx);
                    waveOutPrepareHeader(_hwo, ref _headers[idx], (uint)Marshal.SizeOf<WAVEHDR>());
                    waveOutWrite(_hwo, ref _headers[idx], (uint)Marshal.SizeOf<WAVEHDR>());

                    idx ^= 1;  // przełącz bufor (0↔1)
                }
                else
                {
                    Thread.Sleep(1);
                }
            }
        }

        /// <summary>
        /// Wypełnia bufor sinusoidą, używając przechowywanej fazy i przyrostu fazy.
        /// </summary>
        private void FillBuffer(int i)
        {
            for (int n = 0; n < BUFFER_SAMPLES; n++)
            {
                short sample = (short)(0.3 * short.MaxValue * Math.Sin(_phase));
                _phase = (_phase + _phaseIncrement) % (2 * Math.PI);

                int off = n * 2;
                _buffers[i][off] = (byte)(sample & 0xFF);
                _buffers[i][off + 1] = (byte)(sample >> 8);
            }
        }

        /// <summary>
        /// Zatrzymuje odtwarzanie.
        /// </summary>
        public void Stop()
        {
            if (!_playing) return;
            _playing = false;
            _fillThread.Join();

            // cleanup
            for (int i = 0; i < 2; i++)
            {
                waveOutUnprepareHeader(_hwo, ref _headers[i], (uint)Marshal.SizeOf<WAVEHDR>());
                _pinHandles[i].Free();
            }
            waveOutClose(_hwo);
            _hwo = IntPtr.Zero;
        }
    }
}
