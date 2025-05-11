using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4_RS232_Emulator.Helpers;

namespace _4_RS232_Emulator
{
    public partial class Transmitter : Form
    {
        public Transmitter()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(485, 100);

            this.receiver = new Receiver();
            this.receiver.StartPosition = FormStartPosition.Manual;
            this.receiver.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y + this.Height / 2 - this.receiver.Height / 2);
            this.receiver.Show();
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            string input = BadWordsHelper.FilterWords(this.inputTextBox.Text);
            var sb = new StringBuilder();

            foreach (char c in input)
            {
                sb.Append("0");
                for (int i = 0; i < 8; i++)
                {
                    sb.Append(((c >> i) & 1) == 1 ? "1" : "0");
                }
                sb.Append("11" + Environment.NewLine);
            }
            this.encodedTextBox.Text = sb.ToString();
            var frames = sb.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            this.receiver.ReceiveData(frames);
        }
    }
}
