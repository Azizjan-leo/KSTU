using System;
using System.Windows.Forms;
using mszi.Classes;

namespace mszi
{

   
    public partial class HuffmanForm : Form
    {

      

       
        


        public HuffmanForm()
        {
            InitializeComponent();
        }

        

        private void btnHuffmanEnter_Click(object sender, EventArgs e)
        {
            Haffman hafman = new Haffman();
            string shtext = hafman.Transforme(txbxHuffmanInput.Text.Trim(), true); 
            if (rdbtnEncrypt.Checked)
            {
                txbxHuffmanOutput.Text = shtext;
            }
            else
            {
                txbxHuffmanOutput.Text = hafman.Transforme(shtext, false); 
            }
         
            

            
        }
    }
}
