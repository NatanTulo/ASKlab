using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            this.x = 0; // tu nadajemy wartości początkowe zmiennych
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == 0){
                x = 1;
                this.pictureBox1.Load("C:\\Users\\natan\\OneDrive - Politechnika Gdańska\\Stable Diffusion\\txt2img\\2023-05-05\\00000-841089095.png");
            }
            else if (x == 1){
                x = 2;
                this.pictureBox1.Load("C:\\Users\\natan\\OneDrive - Politechnika Gdańska\\Stable Diffusion\\txt2img\\2023-05-05\\00000-2852612156.png");
            }
            else if (x == 2){
                x = 3;
                this.pictureBox1.Load("C:\\Users\\natan\\OneDrive - Politechnika Gdańska\\Stable Diffusion\\txt2img\\2023-05-05\\00001-2432068759.png");
            }
            else if (x == 3){
                x = 0;
                this.pictureBox1.Load("C:\\Users\\natan\\OneDrive - Politechnika Gdańska\\Stable Diffusion\\txt2img\\2023-05-05\\00002-2874387958.png");
            }
            this.label2.Text="wartość zmiennej statycznej x_st = "+ Form1.x_st.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.okno = new Form2();
            this.okno = new Form2(158); //inny konstruktor
            //this.okno.Show(); // otwiera okno jako osobne okno
            this.okno.ShowDialog(); // otwiera okno jako dialog (nie można przełączyć się na okno główne)
        }

        private void przycisk_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            if (przycisk.Name == "jeden") 
            {
                this.label3.Text = "Wciśnięto przycisk jeden";
                this.jeden.BackColor = Color.Red;
                this.dwa.BackColor = Color.LightGray;
                this.trzy.BackColor = Color.LightGray;
            }
            if (przycisk.Name == "dwa")
            {
                this.label3.Text = "Wciśnięto przycisk dwa";
                this.jeden.BackColor = Color.LightGray;
                this.dwa.BackColor = Color.Red;
                this.trzy.BackColor = Color.LightGray;
            }
            if (przycisk.Name == "trzy")
            {
                this.label3.Text = "Wciśnięto przycisk trzy";
                this.jeden.BackColor = Color.LightGray;
                this.dwa.BackColor = Color.LightGray;
                this.trzy.BackColor = Color.Red;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '1')
            {
                this.jeden.PerformClick();
            }
            if (e.KeyChar == '2')
            {
                this.dwa.PerformClick();
            }
            if (e.KeyChar == '3')
            {
                this.trzy.PerformClick();
            }
        }
    }
}
