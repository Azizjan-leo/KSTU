using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace mszi
{
    public partial class CaesarKeyForm : Form
    {
        public CaesarKeyForm()
        {
            InitializeComponent();
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
    }
}
