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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Load("C:\\Users\\natan\\OneDrive - Politechnika Gdańska\\Stable Diffusion\\txt2img\\2023-05-05\\00017-2420655974.png");
        }

        private void edycjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void plikToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.label1.Text = this.openFileDialog1.FileName;
            this.pictureBox1.Load(this.openFileDialog1.FileName);
        }
    }
}
