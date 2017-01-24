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
    public partial class Cipher_Vernama : Form
    {
        public Cipher_Vernama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            char[] key = KeyWermann(richTextBox1.Text);
            richTextBox3.Text = WehrmannСode(richTextBox1.Text, key);

            for (int i = 0; i < richTextBox1.Text.Length; i++)
                richTextBox2.Text += key[i];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            char[] key = new char[richTextBox3.Text.Length];
            int j = 0;
            foreach (char k in richTextBox3.Text)
            {
                key[j] = k;
                j++;
            }
            richTextBox1.Text = WehrmannСode(richTextBox2.Text, key);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string WehrmannСode(string OpenText, char[] keyChars) // код вернама
        {
            int len = OpenText.Length;  // длина входного текста, исп-ся для шифр., дешифр кода Вермана                   
            // объявление массива входных символов 
            char[] OpenChar = new char[len];
            char[] CloseChar = new char[len];
            string close = "";
            int[] keyCh = new int[len];
            //OpenText = (OpenText).ToLower;

            int i = 0;
            foreach (char op in OpenText) // присваивание массиву символы входного текста
            {
                OpenChar[i] = op;
                i++;
            }

            for (i = 0; i < len; i++) // процесс шифрования
            {
                CloseChar[i] = Convert.ToChar(Convert.ToInt32(OpenChar[i]) ^ Convert.ToInt32(keyChars[i]));
                close += CloseChar[i];
            }

            return close;
        }

        private char[] KeyWermann(string OpenText) // функция создания случаного ключа для шифра вермана
        {
            int len = OpenText.Length;  // длина входного текста, исп-ся для шифр., дешифр кода Вермана   
            char[] key = new char[len];
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                key[i] = (char)rand.Next(0x0410, 0x44F);
            }
            return key;
        }

        private int mod(int a, int b)
        {
            int c = a, s = 0;
            while (c >= b)
            {
                c = a - b;
                s++;
            }
            int mod = a - s * b;
            return mod;
        }
    }
}
