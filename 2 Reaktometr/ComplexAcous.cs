using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Reaktometr
{
    public partial class ComplexAcous : Form
    {
        private ContinuousTone _tone = new ContinuousTone();
        private readonly Dictionary<Button, int> buttonFrequencies = new Dictionary<Button, int>();
        private Button currentCorrectButton;

        public ComplexAcous()
        {
            InitializeComponent();
            buttonFrequencies[button1] = 500;
            buttonFrequencies[button2] = 1000;
            buttonFrequencies[button3] = 1500;
            buttonFrequencies[button4] = 2000;
        }

        private TaskCompletionSource<bool> roundCompleteTcs;

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn == currentCorrectButton)
            {
                _tone.Stop();
                point++;
                btn.BackColor = GetHighlightColor(btn);
                long lastTime = comAcousTimer.StopTest();
                sumTime += lastTime;
                this.label1.Text = $"Punkty: {point}";
                this.label2.Text += $"\nRunda {point}: {lastTime} ms";
                this.label3.Text = $"Średnia: {sumTime/point} ms";
                if(point == 15)
                {
                    this.label4.Text = $"Koniec gry!";
                }
                roundCompleteTcs?.TrySetResult(true);
            }
        }

        private Color GetHighlightColor(Button btn)
        {
            if (btn == button1) return Color.Red;
            else if (btn == button2) return Color.Green;
            else if (btn == button3) return Color.Blue;
            else if (btn == button4) return Color.Yellow;
            else return SystemColors.Control;
        }

        private async Task RunGame()
        {
            Button[] buttons = new Button[] { button1, button2, button3, button4 };
            for (int i = 0; i < 15; i++)
            {
                await Task.Delay(new Random().Next(500, 1000));

                foreach (var btn in buttons)
                    btn.BackColor = SystemColors.Control;
                
                int idx = new Random().Next(buttons.Length);
                Button selectedButton = buttons[idx];
                currentCorrectButton = selectedButton;
                int frequency = buttonFrequencies[selectedButton];

                _tone.Start(frequency);
                comAcousTimer.StartTest();

                roundCompleteTcs = new TaskCompletionSource<bool>();
                await roundCompleteTcs.Task;
            }
        }

        private async Task ShowTonesPresentation()
        {
            foreach (var kvp in buttonFrequencies)
            {
                Button btn = kvp.Key;
                int freq = kvp.Value;
                Color highlightColor;
                if (btn == button1) highlightColor = Color.Red;
                else if (btn == button2) highlightColor = Color.Green;
                else if (btn == button3) highlightColor = Color.Blue;
                else if (btn == button4) highlightColor = Color.Yellow;
                else highlightColor = Color.Red;

                btn.BackColor = highlightColor;
                _tone.Start(freq);
                await Task.Delay(500);
                _tone.Stop();
                btn.BackColor = SystemColors.Control;
                await Task.Delay(200);
            }
        }

        private async void ComplexAcous_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                _tone.Stop();
                this.Close();
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                point = 0;
                sumTime = 0;
                await ShowTonesPresentation();
                await RunGame();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _tone.Stop();
        }
    }
}
