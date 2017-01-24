using System;
using System.Linq;
using System.Windows.Forms;

namespace mszi
{
    public partial class TrisemusForm : Form
    {
        public TrisemusForm()
        {
            InitializeComponent();
        }

        private void btnEnterTrisemus_Click(object sender, EventArgs e)
        {

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

        }
    }
}
