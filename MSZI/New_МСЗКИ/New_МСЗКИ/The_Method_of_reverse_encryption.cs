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
    public partial class The_Method_of_reverse_encryption : Form
    {
        public The_Method_of_reverse_encryption()
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
                richTextBox2.Text += richTextBox1.Text[richTextBox1.Text.Length - 1 - i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            for (int i = 0; i < richTextBox2.Text.Length; i++)
            {
                richTextBox1.Text += richTextBox2.Text[richTextBox2.Text.Length - 1 - i];
            }
        }
    }
}
