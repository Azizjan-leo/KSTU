using System;
using System.Windows.Forms;

namespace mszi
{
    public partial class VernamForm : Form
    {
        public VernamForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txbxInputText.Text != "")
            {
                string text = txbxInputText.Text;
                string key = GenerateKey(text);
                if (rdbtnEncrypt.Checked)
                {
                    txbxKeyText.Text = key;
                    txbxOutputText.Text = VernamEncrypt(text, key);
                }
                else
                {
                    txbxOutputText.Text = VernamDecrypt(txbxOutputText.Text, txbxKeyText.Text);
                }
            }
        }
        private string VernamEncrypt(string text, string key)
        {
            
            string dectext = "";
            int shift = (int)('а');

            int[] keyInt=new int[key.Length];
            int[] textInt = new int[text.Length];

            for (int i = 0; i < key.Length; i++)
            {
                keyInt[i] = (int) key[i] - shift;
                textInt[i] = (int) text[i] - shift;
            }
            for (int i = 0; i < text.Length; i++)
            {
                dectext += Convert.ToChar((textInt[i]^keyInt[i])+shift);
            }
            return dectext;
        }


        private string VernamDecrypt(string text, string key)
        {
            return VernamEncrypt(text, key);
        }
        
        private string GenerateKey(string text)
        {
            string key = "";
            Random random = new Random();
            for (int i = 0; i < text.Length; i++)
            {
                key += (char) random.Next(0x0410, 0x44F);
            }
            return key;
        }
    }
}
