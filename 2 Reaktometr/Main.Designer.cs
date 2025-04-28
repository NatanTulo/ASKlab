using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace _2_Reaktometr
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public SimpleOptic SimOpt;
        public SimpleAcous SimAco;
        public ComplexOptic ComOpt;
        public ComplexAcous ComAco;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.simOpto = new System.Windows.Forms.Button();
            this.simAcous = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comOpto = new System.Windows.Forms.Button();
            this.comAcous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simOpto
            // 
            this.simOpto.Location = new System.Drawing.Point(166, 115);
            this.simOpto.Name = "simOpto";
            this.simOpto.Size = new System.Drawing.Size(140, 140);
            this.simOpto.TabIndex = 0;
            this.simOpto.Text = "Prosty test optyczny";
            this.simOpto.UseVisualStyleBackColor = true;
            this.simOpto.Click += new System.EventHandler(this.simOpto_Click);
            // 
            // simAcous
            // 
            this.simAcous.Location = new System.Drawing.Point(521, 115);
            this.simAcous.Name = "simAcous";
            this.simAcous.Size = new System.Drawing.Size(140, 140);
            this.simAcous.TabIndex = 1;
            this.simAcous.Text = "Prosty test akustyczny";
            this.simAcous.UseVisualStyleBackColor = true;
            this.simAcous.Click += new System.EventHandler(this.simAcous_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(349, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reaktometr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Testy optyczne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Testy akustyczne";
            // 
            // comOpto
            // 
            this.comOpto.Location = new System.Drawing.Point(166, 278);
            this.comOpto.Name = "comOpto";
            this.comOpto.Size = new System.Drawing.Size(140, 140);
            this.comOpto.TabIndex = 4;
            this.comOpto.Text = "Złożony test optyczny";
            this.comOpto.UseVisualStyleBackColor = true;
            this.comOpto.Click += new System.EventHandler(this.comOpto_Click);
            // 
            // comAcous
            // 
            this.comAcous.Location = new System.Drawing.Point(521, 278);
            this.comAcous.Name = "comAcous";
            this.comAcous.Size = new System.Drawing.Size(140, 140);
            this.comAcous.TabIndex = 5;
            this.comAcous.Text = "Złożony test akustyczny";
            this.comAcous.UseVisualStyleBackColor = true;
            this.comAcous.Click += new System.EventHandler(this.comAcous_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comAcous);
            this.Controls.Add(this.comOpto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simAcous);
            this.Controls.Add(this.simOpto);
            this.Name = "Main";
            this.Text = "Reaktometr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button simOpto;
        private System.Windows.Forms.Button simAcous;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button comOpto;
        private System.Windows.Forms.Button comAcous;
    }
    public class ReactionTimer
    {
        private Stopwatch _sw = new Stopwatch();

        public void StartTest()
        {
            _sw.Reset();
            _sw.Start();
        }
        public long StopTest()
        {
            _sw.Stop();
            return _sw.ElapsedMilliseconds;
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

