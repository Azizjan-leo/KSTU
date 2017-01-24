using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_МСЗКИ
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void The_Method_of_reverse_encryption_Click(object sender, EventArgs e)
        {
            The_Method_of_reverse_encryption Temp_Form = new The_Method_of_reverse_encryption();
            Temp_Form.Show();
        }

        private void Method_Caesar_Click(object sender, EventArgs e)
        {
            Method_Caesar Temp_Form = new Method_Caesar();
            Temp_Form.Show();
        }

        private void Analysis_of_the_number_of_letters_Click(object sender, EventArgs e)
        {
            Analysis_of_the_number_of_letters Temp_Form = new Analysis_of_the_number_of_letters();
            Temp_Form.Show();
        }

        private void Key_Method_Caesar_Click(object sender, EventArgs e)
        {
            Key_Method_Caesar Temp_Form = new Key_Method_Caesar();
            Temp_Form.Show();
        }

        private void Trithemius_cipher_Click(object sender, EventArgs e)
        {
            Trithemius_cipher Temp_Form = new Trithemius_cipher();
            Temp_Form.Show();
        }

        private void Playfair_cipher_Click(object sender, EventArgs e)
        {
            Playfair_cipher Temp_Form = new Playfair_cipher();
            Temp_Form.Show();
        }

        private void Cipher_Vigenère_Click(object sender, EventArgs e)
        {
            Cipher_Vigenère Temp_Form = new Cipher_Vigenère();
            Temp_Form.Show();
        }

        private void Analytical_conversion_Click(object sender, EventArgs e)
        {
            Analytical_conversion Temp_Form = new Analytical_conversion();
            Temp_Form.Show();
        }

        private void Cod_of_Haffman_Click(object sender, EventArgs e)
        {
            Cod_of_Haffman Temp_Form = new Cod_of_Haffman();
            Temp_Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cipher_Vernama Temp_Form = new Cipher_Vernama();
            Temp_Form.Show();
        }
    }
}
