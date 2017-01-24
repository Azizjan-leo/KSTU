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
    public partial class Method_Caesar : Form
    {
        public Method_Caesar()
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
            for (int i = 0; i < richTextBox1.Text.Length; i++)
            {
                if (richTextBox1.Text[i] <= 122)
                {
                    if ((richTextBox1.Text[i] + 3) <= 122)
                        richTextBox2.Text += (char)(richTextBox1.Text[i] + 3);
                    else
                        richTextBox2.Text += (char)(richTextBox1.Text[i] + 3 - 26);
                }
                else if (richTextBox1.Text[i] >= 1072)
                {
                    if ((richTextBox1.Text[i] + 3) <= 1103)
                        richTextBox2.Text += (char)(richTextBox1.Text[i] + 3);
                    else
                        richTextBox2.Text += (char)(richTextBox1.Text[i] + 3 - 32);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            for (int i = 0; i < richTextBox2.Text.Length; i++)
            {
                if (richTextBox2.Text[i] >= 96 && richTextBox2.Text[i] <= 122)
                {
                    if ((richTextBox2.Text[i] - 3) > 96)
                        richTextBox1.Text += (char)(richTextBox2.Text[i] - 3);
                    else
                        richTextBox1.Text += (char)(richTextBox2.Text[i] - 3 + 26);
                }
                else if (richTextBox2.Text[i] >= 1072 && richTextBox2.Text[i] <= 1103)
                {
                    if ((richTextBox2.Text[i] - 3) >= 1072)
                        richTextBox1.Text += (char)(richTextBox2.Text[i] - 3);
                    else
                        richTextBox1.Text += (char)(richTextBox2.Text[i] - 3 + 32);
                }
            }
        }
    }
}
