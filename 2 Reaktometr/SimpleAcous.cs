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
    }
}
