using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aziretParser;
using info.lundin.math;

namespace FinalSolution
{

    public partial class TryAziret : Form
    {
        public ExpressionParser parser = new ExpressionParser();
        public void TryAziret_Load(object sender, EventArgs e)
        {
            parser.Values.Add("x", 0);
        }
        public double func()
        {
            parser.Values.Remove("x");
            parser.Values.Add("x", Double.Parse(textBox2.Text));
            return parser.Parse(textBox3.Text);
        }
        public double func(double x)
        {
            parser.Values.Remove("x");
            parser.Values.Add("x", x);
            return parser.Parse(textBox1.Text);
        }
        public double diff_func(double x)
        {
            return (func(x + 0.00001 / 2) - func(x - 0.00001 / 2)) / 0.00001;
        }
        public TryAziret()
        {
            InitializeComponent();
        }
        public decimal lol(decimal x)
        {
            String func = textBox1.Text;
            return ParserDecimal.Compute(func, x);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String func = ParserDecimal.ReturnDerivative(textBox1.Text); //-8
            func = textBox1.Text;
            
            textBox3.Text = ParserDecimal.ReturnDerivative(func);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = diff_func(Double.Parse(textBox2.Text)).ToString();
        }
    }
}
