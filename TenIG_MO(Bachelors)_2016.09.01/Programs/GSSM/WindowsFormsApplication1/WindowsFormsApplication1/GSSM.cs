using info.lundin.math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        public ExpressionParser parser = new ExpressionParser();


        public void Form1_Load(object sender, EventArgs e)
        {
            parser.Values.Add("x", 0);
        }


        public double func(double x)
        {
            parser.Values.Remove("x");
            parser.Values.Add("x", x);
            return parser.Parse(textBox1.Text);

        }
        public Form1()
        {
            InitializeComponent();
        }
        //x^3+x^2-8*x-8
        private void button2_Click(object sender, EventArgs e)
        {
            double tol = double.Parse(tolerance.Text, System.Globalization.NumberStyles.Any), r, a = double.Parse(InA.Text, System.Globalization.NumberStyles.Any), fx1, fx2, x1, x2, b = double.Parse(InB.Text, System.Globalization.NumberStyles.Any);
            int k = 0;
            textBox2.Text = "";

            r = (Math.Sqrt(5.0) - 1) / 2;
            textBox2.AppendText("Step 1 r = (5^1/2 - 1) / 2 =  " + r);
            textBox2.AppendText(Environment.NewLine);

            x1 = a + (1 - r) * (b - a);
            textBox2.AppendText("Step 2 x1 = a + (1 - r) * (b - a) => x1 =  " + x1);
            textBox2.AppendText(Environment.NewLine);

            fx1 = func(x1);
            textBox2.AppendText("Step 3 f(x1) = " + fx1);
            textBox2.AppendText(Environment.NewLine);

            x2 = a + r * (b - a);
            textBox2.AppendText("Step 4 x2 = a + r * (b - a) => x2 = " + x2);
            textBox2.AppendText(Environment.NewLine);

            fx2 = func(x2);
            textBox2.AppendText("Step 5 f(x2) = ");

            k = 0;
            textBox2.AppendText(Environment.NewLine);
            if (minCheckBox.Checked)
            {
                do
                {

                    if (k > 0)
                    {
                        textBox2.AppendText("true");
                        textBox2.AppendText(Environment.NewLine);
                    }
                    // Step 1
                    textBox2.AppendText("Iteration " + ++k);
                    textBox2.AppendText(Environment.NewLine);

                    textBox2.AppendText("Step 1 k = k + 1 = " + k);
                    textBox2.AppendText(Environment.NewLine);

                    // Step 2
                    textBox2.AppendText("Step 2 yf1 < yf2 => " + fx1 + " < " + fx2 + " - ");

                    if (fx1 < fx2)
                    {
                        textBox2.AppendText("true");
                        textBox2.AppendText(Environment.NewLine);

                        textBox2.AppendText(" Step 3 a = x1 => a = " + x1);
                        a = x1;
                        textBox2.AppendText(Environment.NewLine);

                        textBox2.AppendText(" Step 4 x1 = x2 => x1 = " + x2);
                        x1 = x2;
                        textBox2.AppendText(Environment.NewLine);

                        textBox2.AppendText(" Step 5 f1 = f2 => f1 = " + fx2);
                        fx1 = fx2;
                        textBox2.AppendText(Environment.NewLine);

                        x2 = a + r * (b - a);
                        textBox2.AppendText(" Step 6 x2 = a + r * (b - a) => x2 = " + x2);
                        textBox2.AppendText(Environment.NewLine);

                        fx2 = func(x2);
                    }
                    else
                    {
                        textBox2.AppendText("false");
                        textBox2.AppendText(Environment.NewLine);

                        b = x2;
                        textBox2.AppendText(" Step 3 b = x2 => b = " + b);
                        textBox2.AppendText(Environment.NewLine);

                        x2 = x1;
                        textBox2.AppendText(" Step 4 x2 = x1 => x2 = " + x2);
                        textBox2.AppendText(Environment.NewLine);

                        fx2 = fx1;
                        textBox2.AppendText(" Step 5 f2 = f1 => f2 = " + fx2);
                        textBox2.AppendText(Environment.NewLine);

                        x1 = a + (1 - r) * (b - a);
                        textBox2.AppendText(" Step 6 x1 = a + r * (b - a) => x2 = " + x1);
                        textBox2.AppendText(Environment.NewLine);

                        fx1 = func(x1);
                        textBox2.AppendText(" Step 7 f(x1) = " + fx1);
                        textBox2.AppendText(Environment.NewLine);

                    }

                } while (Math.Abs((b - a)) > tol);

                outX1.Text = x1.ToString();
                outAbsBA.Text = Math.Abs(b - a).ToString();

                outYf1.Text = fx1.ToString();
            }
            else
            {
                do
                {

                    if (k > 0)
                    {
                        textBox2.AppendText("true");
                        textBox2.AppendText(Environment.NewLine);
                    }
                    // Step 1
                    textBox2.AppendText("Iteration " + ++k);
                    textBox2.AppendText(Environment.NewLine);

                    textBox2.AppendText("Step 1 k = k + 1 = " + k);
                    textBox2.AppendText(Environment.NewLine);

                    // Step 2
                    textBox2.AppendText("Step 2 yf1 < yf2 => " + fx1 + " < " + fx2 + " - ");

                    if (fx1 > fx2)
                    {
                        textBox2.AppendText("true");
                        textBox2.AppendText(Environment.NewLine);

                        textBox2.AppendText(" Step 3 a = x1 => a = " + x1);
                        a = x1;
                        textBox2.AppendText(Environment.NewLine);

                        textBox2.AppendText(" Step 4 x1 = x2 => x1 = " + x2);
                        x1 = x2;
                        textBox2.AppendText(Environment.NewLine);

                        textBox2.AppendText(" Step 5 f1 = f2 => f1 = " + fx2);
                        fx1 = fx2;
                        textBox2.AppendText(Environment.NewLine);

                        x2 = a + r * (b - a);
                        textBox2.AppendText(" Step 6 x2 = a + r * (b - a) => x2 = " + x2);
                        textBox2.AppendText(Environment.NewLine);

                        fx2 = func(x2);
                    }
                    else
                    {
                        textBox2.AppendText("false");
                        textBox2.AppendText(Environment.NewLine);

                        b = x2;
                        textBox2.AppendText(" Step 3 b = x2 => b = " + b);
                        textBox2.AppendText(Environment.NewLine);

                        x2 = x1;
                        textBox2.AppendText(" Step 4 x2 = x1 => x2 = " + x2);
                        textBox2.AppendText(Environment.NewLine);

                        fx2 = fx1;
                        textBox2.AppendText(" Step 5 f2 = f1 => f2 = " + fx2);
                        textBox2.AppendText(Environment.NewLine);

                        x1 = a + (1 - r) * (b - a);
                        textBox2.AppendText(" Step 6 x1 = a + r * (b - a) => x2 = " + x1);
                        textBox2.AppendText(Environment.NewLine);

                        fx1 = func(x1);
                        textBox2.AppendText(" Step 7 f(x1) = " + fx1);
                        textBox2.AppendText(Environment.NewLine);

                    }

                } while (Math.Abs((b - a)) > tol);

                outX1.Text = x1.ToString();
                outAbsBA.Text = Math.Abs(b - a).ToString();

                outYf1.Text = fx1.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InA.Text = "";
            InB.Text = "";
            minCheckBox.Checked = false;
            textBox1.Text = "";
            tolerance.Text = "";
        }
            
    }
}
