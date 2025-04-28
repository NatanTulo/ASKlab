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
        public ComplexAcous()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void ComplexAcous_Load(object sender, EventArgs e)
        {

        }

        private async void ComplexAcous_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                //this.BackColor = Color.White;
                //this.label1.ForeColor = Color.Red;
                //this.label1.Text = "Przygotuj się";
                await Task.Delay(new Random().Next(1000, 3000));
                //this.BackColor = Color.Black;
                //optoTimer.StartTest();
            }
        }
    }
}
