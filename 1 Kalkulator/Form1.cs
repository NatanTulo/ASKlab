using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Kalkulator
{
    public partial class Form1 : Form
    {
        Rectangle rect = new Rectangle(0, 0, 80, 80);
        Pen blackPen = new Pen(Color.Black, 1);

        public Form1()
        {
            InitializeComponent();
        }

        int height = 200, width = 200;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void negate_Click(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {

        }

        private void comma_Click(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {

        }

        private void two_Click(object sender, EventArgs e)
        {

        }

        private void three_Click(object sender, EventArgs e)
        {

        }

        private void four_Click(object sender, EventArgs e)
        {

        }

        private void five_Click(object sender, EventArgs e)
        {

        }

        private void six_Click(object sender, EventArgs e)
        {

        }

        private void minus_Click(object sender, EventArgs e)
        {

        }

        private void seven_Click(object sender, EventArgs e)
        {

        }

        private void eight_Click(object sender, EventArgs e)
        {

        }

        private void nine_Click(object sender, EventArgs e)
        {

        }

        private void multiply_Click(object sender, EventArgs e)
        {

        }

        private void clear_entry_Click(object sender, EventArgs e)
        {

        }

        private void division_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            digital_clock.Text = DateTime.Now.ToString("hh:mm:ss");
            analog_clock.Invalidate(); // odśwież PictureBox
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void digital_clock_Click(object sender, EventArgs e)
        {

        }

        private void analog_Click(object sender, EventArgs e)
        {
            digital_clock.Visible = false;
            analog_clock.Visible = true;

        }

        private void digital_Click(object sender, EventArgs e)
        {
            digital_clock.Visible = true;
            analog_clock.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void oragneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(232, 152, 93);
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(165, 89, 60);
                }
            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(223, 225, 176);
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(151, 157, 85);
                }
            }
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.BackColor = Color.FromArgb(252, 223, 221);
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(244, 189, 188);
                }
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(223, 242, 248);
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(133, 204, 226);
                }
            }
        }

        private void zielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.analog_clock.Load("Resources/green_clock.png");
        }

        private void pomarańczowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.analog_clock.Load("Resources/orange_clock.png");
        }

        private void różowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.analog_clock.Load("Resources/pink_clock.png");
        }

        private void niebieskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.analog_clock.Load("Resources/blue_clock.png");
        }


        private void analog_clock_paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int centerX = analog_clock.Width / 2;
            int centerY = analog_clock.Height / 2;

            DateTime now = DateTime.Now;

            // Długości wskazówek
            int secondLength = 50;
            int minuteLength = 40;
            int hourLength = 30;

            // Kąty
            float secondAngle = now.Second * 6;
            float minuteAngle = now.Minute * 6 + now.Second * 0.1f;
            float hourAngle = (now.Hour % 12) * 30 + now.Minute * 0.5f; 

            PointF GetPoint(float angleDeg, float length)
            {
                double angleRad = (Math.PI / 180) * (angleDeg - 90); 
                return new PointF(
                    centerX + (float)(length * Math.Cos(angleRad)),
                    centerY + (float)(length * Math.Sin(angleRad))
                );
            }

            PointF hourEnd = GetPoint(hourAngle, hourLength);
            PointF minuteEnd = GetPoint(minuteAngle, minuteLength);
            PointF secondEnd = GetPoint(secondAngle, secondLength);

            g.DrawLine(new Pen(Color.Black, 3), centerX, centerY, hourEnd.X, hourEnd.Y);
            g.DrawLine(new Pen(Color.Black, 2), centerX, centerY, minuteEnd.X, minuteEnd.Y);
            g.DrawLine(new Pen(Color.Black, 1), centerX, centerY, secondEnd.X, secondEnd.Y);

            // Środek
            g.FillEllipse(Brushes.Black, centerX - 4, centerY - 4, 8, 8);
        }


    }
}
