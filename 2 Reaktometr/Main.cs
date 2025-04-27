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

        private void opto_Click(object sender, EventArgs e)
        {
            this.oknOptynczne = new Optyczne();
            this.oknOptynczne.ShowDialog();
        }

        private void akus_Click(object sender, EventArgs e)
        {
            this.oknAkustyczne = new Akustyczne();
            this.oknAkustyczne.ShowDialog();
        }
    }
}
