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
    public partial class Analysis_of_the_number_of_letters : Form
    {
        public Analysis_of_the_number_of_letters()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                var word = new double[1104];
                var str = richTextBox1.Text.ToLower();
                richTextBox2.Text = "";
                foreach (var t in str)
                {
                    if (t >= 97 && t <= 122 ||
                        t >= 1072 && t <= 1103)
                    {
                        word[t]++;
                    }
                }
                for (var i = 97; i <= 122; i++)
                    if (word[i] > 0)
                        richTextBox2.Text += @"Буква " + (char)i + @" встречается " + Math.Round((word[i] * 100 / richTextBox1.TextLength), 2) + "%" + Environment.NewLine;
                for (var i = 1072; i <= 1103; i++)
                    if (word[i] > 0)
                        richTextBox2.Text += @"Буква " + (char)i + @" встречается " + Math.Round((word[i] * 100 / richTextBox1.TextLength), 2) + "%" + Environment.NewLine;
            }
        }
    }
}
