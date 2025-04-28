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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void simOpto_Click(object sender, EventArgs e)
        {
            this.SimOpt = new SimpleOptic();
            this.SimOpt.ShowDialog();
        }

        private void simAcous_Click(object sender, EventArgs e)
        {
            this.SimAco = new SimpleAcous();
            this.SimAco.ShowDialog();
        }

        private void comOpto_Click(object sender, EventArgs e)
        {
            this.ComOpt = new ComplexOptic();
            this.ComOpt.ShowDialog();
        }

        private void comAcous_Click(object sender, EventArgs e)
        {
            this.ComAco = new ComplexAcous();
            this.ComAco.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
