using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public struct Equation
{
    double firstNumber;
    double secondNumber;
    char operation;
    public double result;
    bool[] isOptionSet;
    string equationString;

    public Equation(double firstNumber, double secondNumber, char operation, double result, bool[] isOptionSet)
    {
        this.firstNumber = firstNumber;
        this.secondNumber = secondNumber;
        this.operation = operation;
        this.result = result;
        this.isOptionSet = isOptionSet;
        this.equationString = string.Empty;
    }
}

namespace _1_Kalkulator
{
    public partial class Form1 : Form
    {
        private Rectangle rect = new Rectangle(0, 0, 80, 80);
        private Pen blackPen = new Pen(Color.Black, 1);
        private PrivateFontCollection pfc = new PrivateFontCollection();
        private Equation equation = new Equation(0, 0, '0', 0, new bool[] { false, false, false, false });

        private Button lastClickedButton;
        private Color skinColor = Color.FromArgb(244, 189, 188);

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = this.equals;
        }

        int height = 200, width = 200;

        private void calc_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            timer2.Stop();

            if (lastClickedButton != null && lastClickedButton != przycisk)
            {
                lastClickedButton.BackColor = this.skinColor;
            }

            switch (przycisk.Name)
            {
                case "one":
                    this.one.BackColor = Color.Red;
                    lastClickedButton = this.one;
                    break;
                case "two":
                    this.two.BackColor = Color.Red;
                    lastClickedButton = this.two;
                    break;
                case "three":
                    this.three.BackColor = Color.Red;
                    lastClickedButton = this.three;
                    break;
                case "four":
                    this.four.BackColor = Color.Red;
                    lastClickedButton = this.four;
                    break;
                case "five":
                    this.five.BackColor = Color.Red;
                    lastClickedButton = this.five;
                    break;
                case "six":
                    this.six.BackColor = Color.Red;
                    lastClickedButton = this.six;
                    break;
                case "seven":
                    this.seven.BackColor = Color.Red;
                    lastClickedButton = this.seven;
                    break;
                case "eight":
                    this.eight.BackColor = Color.Red;
                    lastClickedButton = this.eight;
                    break;
                case "nine":
                    this.nine.BackColor = Color.Red;
                    lastClickedButton = this.nine;
                    break;
                case "zero":
                    this.zero.BackColor = Color.Red;
                    lastClickedButton = this.zero;
                    break;
                case "comma":
                    this.comma.BackColor = Color.Red;
                    lastClickedButton = this.comma;
                    break;
                case "clear":
                    this.clear.BackColor = Color.Red;
                    lastClickedButton = this.clear;
                    break;
                case "negate":
                    this.negate.BackColor = Color.Red;
                    lastClickedButton = this.negate;
                    break;
                case "clear_entry":
                    this.clear_entry.BackColor = Color.Red;
                    lastClickedButton = this.clear_entry;
                    break;
                case "multiply":
                    this.multiply.BackColor = Color.Red;
                    lastClickedButton = this.multiply;
                    break;
                case "division":
                    this.division.BackColor = Color.Red;
                    lastClickedButton = this.division;
                    break;
                case "minus":
                    this.minus.BackColor = Color.Red;
                    lastClickedButton = this.minus;
                    break;
                case "plus":
                    this.plus.BackColor = Color.Red;
                    lastClickedButton = this.plus;
                    break;
                case "equals":
                    this.equals.BackColor = Color.Red;
                    lastClickedButton = this.equals;
                    break;
                case "percent":
                    this.percent.BackColor = Color.Red;
                    lastClickedButton = this.percent;
                    break;
            }

            timer2.Interval = 500;
            timer2.Start();
        }

        private void calc_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    this.one.PerformClick();
                    break;
                case '2':
                    this.two.PerformClick();
                    break;
                case '3':
                    this.three.PerformClick();
                    break;
                case '4':
                    this.four.PerformClick();
                    break;
                case '5':
                    this.five.PerformClick();
                    break;
                case '6':
                    this.six.PerformClick();
                    break;
                case '7':
                    this.seven.PerformClick();
                    break;
                case '8':
                    this.eight.PerformClick();
                    break;
                case '9':
                    this.nine.PerformClick();
                    break;
                case '0':
                    this.zero.PerformClick();
                    break;
                case ',':
                    this.comma.PerformClick();
                    break;
                case '+':
                    this.plus.PerformClick();
                    break;
                case '-':
                    this.minus.PerformClick();
                    break;
                case '*':
                    this.multiply.PerformClick();
                    break;
                case '/':
                    this.division.PerformClick();
                    break;
                case '=':
                case '\r':
                    this.equals.PerformClick();
                    break;
                case 'c':
                    this.clear.PerformClick();
                    break;
                case 'C':
                    this.clear_entry.PerformClick();
                    break;
                case 'n':
                    this.negate.PerformClick();
                    break;
                case '%':
                    this.percent.PerformClick();
                    break;
            }
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
            try
            {
                string fontPath = Path.Combine(Application.StartupPath, "digital-7 (italic).ttf");
                if (File.Exists(fontPath))
                {
                    pfc.AddFontFile(fontPath);
                    Font customFont = new Font(pfc.Families[0], 60f, FontStyle.Italic);
                    digital_clock.Font = customFont;
                }
                else
                {
                    MessageBox.Show("Nie znaleziono pliku czcionki: " + fontPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania czcionki: " + ex.Message);
            }
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
            this.skinColor = Color.FromArgb(165, 89, 60);
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = this.skinColor;
                }
            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(223, 225, 176);
            this.skinColor = Color.FromArgb(151, 157, 85);
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = this.skinColor;
                }
            }
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(252, 223, 221);
            this.skinColor = Color.FromArgb(244, 189, 188);
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = this.skinColor;
                }
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(223, 242, 248);
            this.skinColor = Color.FromArgb(133, 204, 226);
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = this.skinColor;
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = this.skinColor;
                lastClickedButton = null;
            }
            timer2.Stop();
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
