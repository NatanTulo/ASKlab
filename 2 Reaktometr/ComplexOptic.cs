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
    public partial class ComplexOptic : Form
    {
        private TaskCompletionSource<bool> roundCompleteTcs;

        public ComplexOptic()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.BackColor == Color.Red)
            {
                point++;
                btn.BackColor = SystemColors.Control;
                long lastTime = comOptoTimer.StopTest();
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

        private async Task RunGame()
        {
            Button[] buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8 };
            for (int i = 0; i < 15; i++)
            {
                await Task.Delay(new Random().Next(500, 1000));

                foreach (var btn in buttons)
                    btn.BackColor = SystemColors.Control;
                
                int idx = new Random().Next(buttons.Length);
                buttons[idx].BackColor = Color.Red;
                comOptoTimer.StartTest();

                roundCompleteTcs = new TaskCompletionSource<bool>();
                await roundCompleteTcs.Task;
            }
        }

        private async void ComplexOptic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                point = 0;
                await RunGame();
            }
        }
    }
}
