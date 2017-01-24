using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace mszi
{
    public partial class msziMain : Form
    {
        public msziMain()
        {
            InitializeComponent();
        }
        private string shtext = "";
        private void msziMain_Load(object sender, EventArgs e)
        {
            txbxStepCaesar.Text = "0";
        }
        private void btnEnterReverse_Click(object sender, EventArgs e)
        {
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
        private void btnEnterCaesar_Click(object sender, EventArgs e)
        {
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
        private void btnEnterCaesarKey_Click(object sender, EventArgs e)
        {
            //ru -- [1072;1103]
            //en -- [97;122]

            if (txbxInputCaesarKey.Text != "" && txbxKeywordCaesarKey.Text != "" && txbxStepCaesarKey.Text != "")
            {
                int step = int.Parse(txbxStepCaesarKey.Text);
                string keyword = txbxKeywordCaesarKey.Text;
                var keytable = new Dictionary<char, char>();
                int keycode = (int)'a';
                int valuecode = (int)'z';
                int j = step;
                
                txbxOutputCaesarKey.Text = "";
                
                while (j > 0)
                {
                    j--;
                    if (keyword.Contains((char)valuecode))
                    {
                        j++;
                    }
                    valuecode--;
                }
                do
                {
                    valuecode++;
                    if (!keyword.Contains((char)valuecode))
                    {

                        keytable.Add((char)keycode, (char)valuecode);
                        keycode++;
                        j++;
                    }
                    
                } while (step > j);

                foreach (var item in keyword)
                {
                    keytable.Add((char)keycode, item);
                    keycode++;
                }
                valuecode = (int)'a';
                for (int i = 0; i < 26; i++)
                {
                    if (!keytable.ContainsValue((char)valuecode))
                    {
                        keytable.Add((char)keycode, (char)valuecode);
                        keycode++;
                    }
                    valuecode++;
                }

                /*---------*/
                foreach (var item in keytable)
                {
                    txbxOutputCaesarKey.Text += item.Key;
                }

                txbxOutputCaesarKey.Text += "\r\n";

                foreach (var item in keytable)
                {
                    txbxOutputCaesarKey.Text += item.Value;
                }

                txbxOutputCaesarKey.Text += "\r\n";
                string text = txbxInputCaesarKey.Text;

                foreach (var item in text)
                {
                    txbxOutputCaesarKey.Text += keytable[item];
                }
            }

            
            
        }
        private void btnEnterFrequency_Click(object sender, EventArgs e)
        {
            if (txbxInputFrequency.Text != "")
            {
                var symdict = new Dictionary<char, int>();
                foreach (var item in txbxInputFrequency.Text)
                {
                    if (symdict.ContainsKey(item))
                    {
                        symdict[item]++;
                    }
                    else
                    {
                        symdict.Add(item, 1);
                    }
                }
                foreach (var item in symdict)
                {
                    txbxOutputFrequency.Text += String.Format("Частота появления символа '{0}' равна {1:0.00};\r\n", item.Key, (item.Value * 1.0) / txbxInputFrequency.Text.Length);
                }
            }

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
                txbxOutputVigenere.Text = keytext;

                for (var i = 0; i < text.Length; i++)
                {

                }
            }
        }
        private void msziMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Вы действительно желаете закрыть приложение", "Закрытие приложения", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
            //    e.Cancel = false;
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }
        private void btnEnterTrisemus_Click(object sender, EventArgs e)
        {
            //ru -- [1072;1103]
            //en -- [97;122]
            char[,] keytable = new char[4, 8];
            string key = (txbxKeywordTrisemus.Text).Trim().ToLower();
            int k = 0, y = 1072;
            for (int i = 0; i < 4; i++)//заполняем массив
            {
                for (int j = 0; j < 8; j++)
                {
                    if (k < key.Length)
                    {
                        keytable[i, j] = key[k];
                    }
                    else
                    {
                        while (y <= 1103)
                        {
                            if (!key.Contains((char)y))
                            {
                                keytable[i, j] = (char)y;
                                y++;
                                break;
                            }
                            y++;
                        };

                    }
                    k++;
                }


            }
            string text = (txbxInputTrisemus.Text).Trim().ToLower();
            string detext = "";
            bool flag = false;
            foreach (char item in text)
            {
                for (int i = 0; i < 4; i++)//шифруем
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (item == keytable[i, j])
                        {
                            if (i < 3)
                            {
                                detext += keytable[i + 1, j];
                            }
                            else
                            {
                                detext += keytable[1, j];
                            }
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            if (rdbtnEncryptTrisemus.Checked)
            {
                txbxOutputTrisemus.Text = detext;
            }
            else
            {
                text = detext;
                detext = "";
                foreach (char item in text)
                {
                    for (int i = 0; i < 4; i++)//дешифруем
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (item == keytable[i, j])
                            {
                                if (i > 0)
                                {
                                    detext += keytable[i - 1, j];
                                }
                                else
                                {
                                    detext += keytable[3, j];
                                }
                                flag = true;
                                break;
                            }
                        }
                        if (flag)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                txbxOutputTrisemus.Text = detext;
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txbxOutputFrequency_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbxInputFrequency_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rdbtnEncryptReverse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbxOutputReverse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbxInputReverse_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnDecryptReverse_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
    
