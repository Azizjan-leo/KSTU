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
using Mathos.Parser;
using Mathos;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        public ExpressionParser parser = new ExpressionParser();
        public MathParser parser2 = new MathParser();
        public MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
       
        
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

        public void button1_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(textBox3.Text, System.Globalization.NumberStyles.Any), fx0 = func(x0), tol = double.Parse(textBox5.Text, System.Globalization.NumberStyles.Any), H = tol, fx1, x1;
            int k = 0;

            textBox2.Text = "";

            textBox2.AppendText("Step 1: H = tol => H = " + H);
            textBox2.AppendText(Environment.NewLine);

            fx0 = func(x0);
            textBox2.AppendText("Step 2: f(x0) = " + fx0);
            textBox2.AppendText(Environment.NewLine);

            x1 = x0 + H;
            textBox2.AppendText("Step 3: x1 = x0 + H => x1 = " + x0 + " + " + H + " = " + x1);
            textBox2.AppendText(Environment.NewLine);

            fx1 = func(x1);
            textBox2.AppendText("Step 4: f(x1) = " + fx1);
            textBox2.AppendText(Environment.NewLine);

            textBox2.AppendText("Step 5: k = 0");
            textBox2.AppendText(Environment.NewLine);
            textBox2.AppendText(Environment.NewLine);
            if (checkBoxMin.Checked)
            {
                do
                {
                    if (k > 0)
                    {
                        textBox2.AppendText("false");
                        textBox2.AppendText(Environment.NewLine);
                    }

                    //x^3+x^2-8*x-8
                    textBox2.AppendText("Iteration " + ++k + ":");
                    textBox2.AppendText(Environment.NewLine);

                    textBox2.AppendText(" Step 1: k = k + 1 = " + k);
                    textBox2.AppendText(Environment.NewLine);

                    textBox2.AppendText(" Step 2: yf1 <= yf0 - ");
                    if (fx1 >= fx0)
                    {
                        textBox2.AppendText("true");
                        textBox2.AppendText(Environment.NewLine);

                        fx1 = fx0;
                        textBox2.AppendText(" Step 3: yf1 = yf0 => yf1 = " + fx1);


                        x1 = x0;
                        textBox2.AppendText("; x1 = x0 => x1 = " + x1);

                        break;
                    }
                    else
                    {
                        textBox2.AppendText("false");
                        textBox2.AppendText(Environment.NewLine);

                        textBox2.AppendText(" Step 3: x0 = x1 => x0 = " + x1 + "; yf0 = yf1 => yf0 = " + fx1);
                        x0 = x1; fx0 = fx1;
                        textBox2.AppendText(Environment.NewLine);

                        x1 = x1 + H;
                        textBox2.AppendText(" Step 4: x1 = x1 + H => x1 = " + x1);
                        textBox2.AppendText(Environment.NewLine);

                        fx1 = func(x1);
                        textBox2.AppendText(" Step 5: f(x1) = " + fx1);
                        textBox2.AppendText(Environment.NewLine);

                        textBox2.AppendText(" Step 6: yf1 <= yf0 - ");
                    }
                } while (true);
            }
            else
            {
                do
                {
                    if (k > 0)
                    {
                        textBox2.AppendText("false");
                        textBox2.AppendText(Environment.NewLine);
                    }

                    //x^3+x^2-8*x-8
                    textBox2.AppendText("Iteration " + ++k + ":");
                    textBox2.AppendText(Environment.NewLine);

                    textBox2.AppendText(" Step 1: k = k + 1 = " + k);
                    textBox2.AppendText(Environment.NewLine);

                    textBox2.AppendText(" Step 2: yf1 <= yf0 - ");
                    if (fx1 <= fx0)
                    {
                        textBox2.AppendText("true");
                        textBox2.AppendText(Environment.NewLine);

                        fx1 = fx0;
                        textBox2.AppendText(" Step 3: yf1 = yf0 => yf1 = " + fx1);


                        x1 = x0;
                        textBox2.AppendText("; x1 = x0 => x1 = " + x1);

                        break;
                    }
                    else
                    {
                        textBox2.AppendText("false");
                        textBox2.AppendText(Environment.NewLine);

                        textBox2.AppendText(" Step 3: x0 = x1 => x0 = " + x1 + "; yf0 = yf1 => yf0 = " + fx1);
                        x0 = x1; fx0 = fx1;
                        textBox2.AppendText(Environment.NewLine);

                        x1 = x1 + H;
                        textBox2.AppendText(" Step 4: x1 = x1 + H => x1 = " + x1);
                        textBox2.AppendText(Environment.NewLine);

                        fx1 = func(x1);
                        textBox2.AppendText(" Step 5: f(x1) = " + fx1);
                        textBox2.AppendText(Environment.NewLine);

                        textBox2.AppendText(" Step 6: yf1 <= yf0 - ");
                        
                    }
                } while (true);
            }
            SolY.Text = fx1.ToString();
            SolX.Text = x1.ToString();
            AbsH.Text = Math.Abs(H).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            checkBoxMin.Checked = false;
        }
    }
}
