using System;
using System.Windows.Forms;

namespace mszi
{
    public partial class ReverseForm : Form
    {
        public ReverseForm()
        {
            InitializeComponent();
        }

        private void btnEnterReverse_Click(object sender, EventArgs e)
        {
            string shtext;
            if (txbxInputReverse.Text != "")
            {
                txbxOutputReverse.Text = "";
                shtext = "";

                for (int i = txbxInputReverse.Text.Length - 1; i >= 0; i--)
                {
                    shtext += txbxInputReverse.Text[i];
                }


                if (rdbtnEncryptReverse.Checked)
                {
                    txbxOutputReverse.Text = shtext;
                }
                else if (rdbtnDecryptReverse.Checked)
                {
                    for (int i = shtext.Length - 1; i >= 0; i--)
                    {
                        txbxOutputReverse.Text += shtext[i];
                    }
                }


            }
        }
    }
}
