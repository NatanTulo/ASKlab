using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Reaktometr
{
    public partial class SimpleOptic : Form
    {
        public SimpleOptic()
        {
            InitializeComponent();
        }

        private void SimpleOptic_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            long timeSW = simOptoTimer.StopTest();
            if (timeSW != 0)
                this.label1.Text = "Czas: " + timeSW.ToString() + " ms";
            this.label1.ForeColor = Color.Black;
        }

        private async void SimpleOptic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                this.BackColor = Color.White;
                this.label1.ForeColor = Color.Red;
                this.label1.Text = "Przygotuj się";
                await Task.Delay(new Random().Next(1000, 3000));
                this.BackColor = Color.Black;
                simOptoTimer.StartTest();
            }
        }
    }
}
