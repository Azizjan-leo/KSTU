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
    public partial class Playfair_cipher : Form
    {
        public Playfair_cipher()
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

            //char[,] Table = new char[3,7];
            //for(int c = 0, i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 7; j++, c++)
            //    {
            //        Table[i, j] = fr[c];
            //    }
            //}

            char[] test = richTextBox1.Text.ToLower().ToArray();

            char[] txt = richTextBox1.Text.ToLower().Replace(" ", "").ToArray();

            int b = txt.Length;

            //if (b % 2 == 1)
            //{
            //    Array.Resize(ref txt, txt.Length + 1);
            //    txt[txt.Length - 1] = (char)1072;
            //    b = txt.Length;
            //}

            //char[,] Text = new char[b/2, 1];

            //for (int c = 0, i = 0; i < b/2; i++)
            //{
            //    for (int j = 0; j < 1; j++, c++)
            //    {
            //        Text[i, j] = txt[c];
            //    }
            //}            

            for (int i = 0; i < b; i += 2)
            {
                int d = 0;
                int f = 0;


                for (int z = 0; z < fr.Length; z++)
                {
                    if (txt[i] == fr[z])
                        d = z;
                }

                for (int z = 0; z < fr.Length; z++)
                {
                    if (txt[i + 1] == fr[z])
                        f = z;
                }

                if ((d >= 0) && (d <= 7) && (f >= 0) && (f <= 7))
                {
                    if (d == 7)
                        txt[i] = fr[0];
                    else if (d < 7)
                        txt[i] = fr[d + 1];
                    else if (f == 7)
                        txt[i + 1] = fr[0];
                    else if (f < 7)
                        txt[i + 1] = fr[f + 1];
                }
                else if ((d >= 8) && (d <= 15) && (f >= 8) && (f <= 15))
                {
                    if (d == 15)
                        txt[i] = fr[8];
                    else if (d < 15)
                        txt[i] = fr[d + 1];
                    else if (f == 15)
                        txt[i + 1] = fr[8];
                    else if (f < 15)
                        txt[i + 1] = fr[f + 1];
                }
                else if ((d >= 16) && (d <= 23) && (f >= 16) && (f <= 23))
                {
                    if (d == 23)
                        txt[i] = fr[16];
                    else if (d < 23)
                        txt[i] = fr[d + 1];
                    else if (f == 23)
                        txt[i + 1] = fr[16];
                    else if (f < 23)
                        txt[i + 1] = fr[f + 1];
                }
                else if ((d >= 24) && (d <= 31) && (f >= 24) && (f <= 31))
                {
                    if (d == 31)
                        txt[i] = fr[24];
                    else if (d < 31)
                        txt[i] = fr[d + 1];
                    else if (f == 31)
                        txt[i + 1] = fr[24];
                    else if (f < 31)
                        txt[i + 1] = fr[f + 1];
                }
                else
                {
                    txt[i] = fr[8 * (d / 8) + (f % 8)];
                    txt[i + 1] = fr[8 * (f / 8) + (d % 8)];
                }
            }
            int flag1 = 0;
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] == ' ')
                {
                    richTextBox2.Text = richTextBox2.Text + " ";
                }
                else
                {
                    richTextBox2.Text = richTextBox2.Text + txt[flag1];
                    flag1++;
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
