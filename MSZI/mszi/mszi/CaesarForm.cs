using System;
using System.Windows.Forms;

namespace mszi
{
    public partial class CaesarForm : Form
    {
        public CaesarForm()
        {
            InitializeComponent();
        }

        private void btnEnterCaesar_Click(object sender, EventArgs e)
        {
            string shtext;
            int step = int.Parse(txbxStepCaesar.Text);
            if (txbxInputCaesar.Text != "")
            {
                txbxOutputCaesar.Text = "";
                shtext = "";
                int itemcode = 0;
                foreach (var item in txbxInputCaesar.Text)
                {
                    itemcode = (int)item;
                    if (itemcode >= 97 && itemcode <= 122 || itemcode >= 1072 && itemcode <= 1103)
                    {
                        if (itemcode > 122 - step && itemcode <= 122)
                        {
                            shtext += (char)(itemcode - 26 + step);
                        }
                        else if (itemcode > 1072 - step && itemcode <= 1072)
                        {
                            shtext += (char)(itemcode - 33 + step);
                        }
                        else
                        {
                            shtext += (char)(itemcode + step);
                        }
                    }
                    else
                    {
                        shtext += item;
                    }
                }

                if (rdbtnEncryptCaesar.Checked)
                    txbxOutputCaesar.Text = shtext;
                else if (rdbtnDecryptCaesar.Checked)
                {
                    itemcode = 0;
                    foreach (var item in shtext)
                    {
                        itemcode = (int)item;
                        if (itemcode >= 97 && itemcode <= 122 || itemcode >= 1072 && itemcode <= 1103)
                        {
                            if (itemcode < 97 + step && itemcode >= 97)
                            {
                                txbxOutputCaesar.Text += (char)(itemcode + 26 - step);
                            }
                            else if (itemcode < 1072 + step && itemcode >= 1072)
                            {
                                txbxOutputCaesar.Text += (char)(itemcode + 33 - step);
                            }
                            else
                            {
                                txbxOutputCaesar.Text += (char)(itemcode - step);
                            }
                        }
                        else
                        {
                            txbxOutputCaesar.Text += item;
                        }

                    }
                }

            }
        }
    }
}
