using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
            this.x_o = 0;
            this.label1.Text = "Wartość zmiennej xo = " + this.x_o.ToString();
        }
        public Form2(int x_i)
        {
            InitializeComponent();
            this.x_o = x_i;
            this.label1.Text = "Wartość zmiennej xo = " + this.x_o.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.x_st++;
        }
    }
}
