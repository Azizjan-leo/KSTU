using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_МСЗКИ
{
    public partial class Cipher_Vigenère : Form
    {
        public Cipher_Vigenère()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            char[] Data = richTextBox1.Text.ToLower().ToArray();
            char[] DataK = textBox2.Text.ToLower().ToArray();
            char[] Data2 = new char[Data.Length];
            for (int i = 0, j = 0; i < Data.Length; i++, j++)
            {
                if (j == DataK.Length)
                    j -= DataK.Length;
                if((((int)DataK[j] - 1071) + ((int)Data[i] - 1071)) < 33)
                    Data2[i] = (char)((((int)DataK[j] - 1071) + ((int)Data[i] - 1071)) + 1071);
                else
                    Data2[i] = (char)((((int)DataK[j] - 1071) + ((int)Data[i] - 1071)) + 1071 - 33);
                richTextBox2.Text += Data2[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            char[] Data2 = richTextBox2.Text.ToLower().ToArray();
            char[] DataK = textBox2.Text.ToLower().ToArray();
            char[] Data1 = new char[Data2.Length];
            for (int i = 0, j = 0; i < Data2.Length; i++, j++)
            {
                if (j == DataK.Length)
                    j -= DataK.Length;
                if ((((int)Data2[i] - 1071)) - ((int)DataK[j] - 1071) > 0)
                    Data1[i] = (char)((((int)Data2[i] - 1071)) - ((int)DataK[j] - 1071) + 1071);
                else
                    Data1[i] = (char)((((int)Data2[i] - 1071)) - ((int)DataK[j] - 1071) + 1071 + 33);
                richTextBox1.Text += Data1[i];
            }
        }
    }
}