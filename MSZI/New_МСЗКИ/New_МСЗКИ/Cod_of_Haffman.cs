using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using МСЗКИ;

namespace New_МСЗКИ
{
    public partial class Cod_of_Haffman : Form
    {
        public Cod_of_Haffman()
        {
            InitializeComponent();
            Binary = null;
        }

        public List<Tree> Binary { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string words = richTextBox1.Text;
            richTextBox2.Text = Transforme(words, true);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string words = richTextBox2.Text;
            richTextBox1.Text = Transforme(words, false);
        }
        public string Transforme(string words, bool code)
        {
            if (words == "") return null;
            if (code)
            {
                Binary = new List<Tree>();
                Tree tree;
                foreach (var word in words)
                {
                    tree = Binary.FirstOrDefault(x => x.Item.Letter == word);
                    if (tree != null)
                        tree.Item.Count++;
                    else
                        Binary.Add(new Tree(word, 1));
                }
                if (Binary.Count == 1) return words.Replace(words[0], '0');
                while (Binary.Count > 1)
                {
                    var first = FindMin();
                    Binary.Remove(first);
                    var second = FindMin();
                    Binary.Remove(second);
                    Binary.Add(new Tree(first, second));
                }
                var output = "";
                tree = Binary.First();
                foreach (int letter in words)
                    output += tree.GetCode(letter) + " ";
                return output;
            }
            if (words.Length <= 1) return Binary.First().Item.Letter.ToString();
            return Binary.First().GetWord(words.Split(' '));
        }
        public Tree FindMin()
        {
            Tree min = null;
            foreach (var tree in Binary)
            {
                if (min == null) min = tree;
                else if (tree.Item.Count < min.Item.Count)
                    min = tree;
            }
            return min;
        }
    }
}
