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
    public partial class Trithemius_cipher : Form
    {
        public Trithemius_cipher()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] text = textBox2.Text.ToLower().ToArray();
            int a = text.Length;
            char[] fr = new char[0];

            for (int i = 0; i < a; i++)
            {
                if (i == 0)
                {
                    Array.Resize(ref fr, fr.Length + 1);
                    fr[fr.Length - 1] = text[i];
                }
                else
                {
                    int flag = 0;
                    for (int c = 0; c < fr.Length; c++)
                    {
                        if (fr[c] != text[i])
                            flag++;
                    }
                    if (flag == fr.Length)
                    {
                        Array.Resize(ref fr, fr.Length + 1);
                        fr[fr.Length - 1] = text[i];
                    }
                }
            }
            
            for (int i = 1072; i <= 1103; i++)
            {
                int flag = 0;
                for (int c = 0; c < fr.Length; c++)
                {
                    if (fr[c] != (char)i)
                        flag++;
                }
                if (flag == fr.Length)
                {
                    Array.Resize(ref fr, fr.Length + 1);
                    fr[fr.Length - 1] = (char)i;

                }
            }

            char[] txt = richTextBox1.Text.ToLower().ToArray();

            int b = txt.Length;

            for (int i = 0; i < b; i++)
            {
                int d = 0;

                for (int z = 0; z < fr.Length; z++)
                {
                    if (txt[i] == fr[z])
                        d = z;
                }

                if (d < fr.Length - 8)
                {
                    richTextBox2.Text = richTextBox2.Text + fr[d + 8];
                }
                else
                {
                    richTextBox2.Text = richTextBox2.Text + fr[d + 8 - 32];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] text = textBox2.Text.ToLower().ToArray();
            int a = text.Length;
            char[] fr = new char[0];

            for (int i = 0; i < a; i++)
            {
                if (i == 0)
                {
                    Array.Resize(ref fr, fr.Length + 1);
                    fr[fr.Length - 1] = text[i];
                }
                else
                {
                    int flag = 0;
                    for (int c = 0; c < fr.Length; c++)
                    {
                        if (fr[c] != text[i])
                            flag++;
                    }
                    if (flag == fr.Length)
                    {
                        Array.Resize(ref fr, fr.Length + 1);
                        fr[fr.Length - 1] = text[i];
                    }
                }
            }

            for (int i = 1072; i <= 1103; i++)
            {
                int flag = 0;
                for (int c = 0; c < fr.Length; c++)
                {
                    if (fr[c] != (char)i)
                        flag++;
                }
                if (flag == fr.Length)
                {
                    Array.Resize(ref fr, fr.Length + 1);
                    fr[fr.Length - 1] = (char)i;

                }
            }

            char[] txt = richTextBox2.Text.ToLower().ToArray();

            int b = txt.Length;

            for (int i = 0; i < b; i++)
            {
                int d = 0;

                for (int z = 0; z < fr.Length; z++)
                {
                    if (txt[i] == fr[z])
                        d = z;
                }

                if (d > 8)
                {
                    richTextBox1.Text = richTextBox1.Text + fr[d - 8];
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + fr[d - 8 + 32];
                }
            }
        }
    }
}
