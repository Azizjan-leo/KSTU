using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ESM esm = new ESM();
            esm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PSM psm = new PSM();
            psm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GSM gsm = new GSM();
            gsm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NSM nsm = new NSM();
            nsm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://D:\\KSTU\\TenIG_MO(Bachelors)_2016.09.01\\PracticeWork\\FinalSolution\\Manual.chm");
        }
    }
}
