using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace mszi
{
    public partial class FrequencyForm : Form
    {
        public FrequencyForm()
        {
            InitializeComponent();
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
    }
}
