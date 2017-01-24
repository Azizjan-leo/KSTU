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
    public partial class Key_Method_Caesar : Form
    {
        public Key_Method_Caesar()
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
            char[] text = textBox2.Text.ToLower().ToArray();
            int a = text.Length;
            char[] fr = new char[0];
            char[] fr1 = new char[0];

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

            if (fr[0] >= 1072 && fr[0] <= 1103)
            {
                Array.Resize(ref fr1, fr1.Length + 32);
                for (int j = 0, i = 1072; i <= 1103; i++, j++)
                {
                    fr1[j] = (char)i;
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
            }
            else 
            {
                Array.Resize(ref fr1, fr1.Length + 26);
                for (int j = 0, i = 97; i <= 122; i++, j++)
                {
                    fr1[j] = (char)i;
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
            }
            char[] txt = richTextBox1.Text.ToLower().ToArray();

            int b = txt.Length;

            for (int i = 0; i < b; i++)
            {
                int d = 0;

                for (int z = 0; z < fr1.Length; z++)
                {
                    if (txt[i] == fr1[z])
                        d = z;
                }
                if ((d - int.Parse(textBox1.Text.Trim())) >= 0 && fr[0] >= 1072 && fr[0] <= 1103)
                    richTextBox2.Text = richTextBox2.Text + fr[d - int.Parse(textBox1.Text.Trim())];

                else if((d - int.Parse(textBox1.Text.Trim())) < 0 && fr[0] >= 1072 && fr[0] <= 1103)
                    richTextBox2.Text = richTextBox2.Text + fr[d - int.Parse(textBox1.Text.Trim()) + 32];

                else if ((d - int.Parse(textBox1.Text.Trim())) >= 0 && fr[0] >= 96 && fr[0] <= 122)
                    richTextBox2.Text = richTextBox2.Text + fr[d - int.Parse(textBox1.Text.Trim())];

                else if ((d - int.Parse(textBox1.Text.Trim())) < 0 && fr[0] >= 96 && fr[0] <= 122)
                    richTextBox2.Text = richTextBox2.Text + fr[d - int.Parse(textBox1.Text.Trim()) + 26];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            char[] text = textBox2.Text.ToLower().ToArray();
            int a = text.Length;
            char[] fr = new char[0];
            char[] fr1 = new char[0];

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

            if (fr[0] >= 1072 && fr[0] <= 1103)
            {
                Array.Resize(ref fr1, fr1.Length + 32);
                for (int j = 0, i = 1072; i <= 1103; i++, j++)
                {
                    fr1[j] = (char)i;
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
            }
            else
            {
                Array.Resize(ref fr1, fr1.Length + 26);
                for (int j = 0, i = 97; i <= 122; i++, j++)
                {
                    fr1[j] = (char)i;
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
                if ((d + int.Parse(textBox1.Text.Trim())) <= fr.Length && fr[0] >= 1072 && fr[0] <= 1103)
                    richTextBox1.Text = richTextBox1.Text + fr1[d + int.Parse(textBox1.Text.Trim())];

                else if ((d + int.Parse(textBox1.Text.Trim())) > fr.Length && fr[0] >= 1072 && fr[0] <= 1103)
                    richTextBox1.Text = richTextBox1.Text + fr1[d + int.Parse(textBox1.Text.Trim()) - 32];

                else if ((d + int.Parse(textBox1.Text.Trim())) <= fr.Length && fr[0] >= 96 && fr[0] <= 122)
                    richTextBox1.Text = richTextBox1.Text + fr1[d + int.Parse(textBox1.Text.Trim())];

                else if ((d + int.Parse(textBox1.Text.Trim())) > fr.Length && fr[0] >= 96 && fr[0] <= 122)
                    richTextBox1.Text = richTextBox1.Text + fr1[d + int.Parse(textBox1.Text.Trim()) - 26];
            }
        }
    }
}
