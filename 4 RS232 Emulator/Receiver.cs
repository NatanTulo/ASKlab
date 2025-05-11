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
    public partial class Receiver : Form
    {
        public Receiver()
        {
            InitializeComponent();
        }

         public void ReceiveData(string[] frames)
        {
            var sb = new StringBuilder();
            foreach (string frame in frames)
            {
                if (frame.Length < 11) continue;
                string dataBits = frame.Substring(1, 8);
                int ascii = 0;
                for (int i = 0; i < 8; i++)
                {
                    if (dataBits[i] == '1')
                        ascii += (1 << i);
                }
                sb.Append((char)ascii);
            }
            this.outputTextBox.Text = BadWordsHelper.FilterWords(sb.ToString());
        }
    }
}
