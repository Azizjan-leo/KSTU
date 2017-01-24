using System;
using System.Windows.Forms;

namespace mszi
{
    public partial class VigenereForm : Form
    {
        public VigenereForm()
        {
            InitializeComponent();
        }

        private void btnEnterVigenere_Click(object sender, EventArgs e)
        {

            if (txbxInputVigenere.Text != "" && txbxKeywordVigenere.Text != "")
            {
                string text = txbxInputVigenere.Text;
                string keyword = txbxKeywordVigenere.Text;
                string keytext = "";
                while (keytext.Length < text.Length)
                {
                    if ((text.Length - keytext.Length) >= keyword.Length)
                    {
                        keytext += keyword;
                    }
                    else
                    {
                        keytext += keyword.Substring(0, text.Length % keyword.Length);
                    }
                }
                //зашифровка
                int first = (int)'а';
                int n = 33;
                string outputtext = "";
                for (int i = 0; i < text.Length; i++)
                {
                    int num = (((int)text[i] + (int)keytext[i]) - 2 * first) % n;
                    outputtext += (char)(num + first+1);
                }


                if (rdbtnEncryptVigenere.Checked)
                {
                    txbxOutputVigenere.Text = outputtext;
                }
                else
                {
                    //расшифровка
                    string dectext = outputtext;
                    outputtext = "";
                    for (int i = 0; i < dectext.Length; i++)
                    {
                        int num = (((int)dectext[i] - (int)keytext[i] + n)) % n;
                        outputtext += (char)(num + first-1);
                    }
                    txbxOutputVigenere.Text = outputtext;
                }
            }
        }
    }
}
