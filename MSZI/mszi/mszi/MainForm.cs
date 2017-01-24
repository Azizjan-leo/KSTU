using System;
using System.Windows.Forms;

namespace mszi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnOpenTrisemusForm_Click(object sender, EventArgs e)
        {
            new TrisemusForm().Show();
        }
        private void btnOpenVigenereForm_Click(object sender, EventArgs e)
        {
           new VigenereForm().Show();
        }
        private void btnOpenCaesarForm_Click(object sender, EventArgs e)
        {
            new CaesarForm().Show();
        }
        private void btnOpenReverseForm_Click(object sender, EventArgs e)
        {
            new ReverseForm().Show();
        }

        private void btnOpenCaesarKey_Click(object sender, EventArgs e)
        {
            new CaesarKeyForm().Show();
        }
        private void btnOpenFrequenceForm_Click(object sender, EventArgs e)
        {
            new FrequencyForm().Show();
        }
        private void btnOpenAnalyticTransformationForm_Click(object sender, EventArgs e)
        {
            new AnalyticTransformationForm().Show();
        }
        private void btnOpenHuffmanForm_Click(object sender, EventArgs e)
        {
            new HuffmanForm().Show();
        }
        private void btnOpenVernamForm_Click(object sender, EventArgs e)
        {
            new VernamForm().Show();
        }
    }
}
