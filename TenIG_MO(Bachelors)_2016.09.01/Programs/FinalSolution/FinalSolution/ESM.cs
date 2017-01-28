using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;

namespace FinalSolution
{
    
    public partial class ESM : Form
    {
        public ESM()
        {
            InitializeComponent();
        }

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

        public bool getError()
        {
            
            bool err = false;
            textBox2.Text = "";
            if ((!checkBoxMax.Checked && !checkBoxMin.Checked) || (checkBoxMax.Checked && checkBoxMin.Checked))
            {
                textBox2.AppendText("Choose what to find (min or max)" + Environment.NewLine);
                err = true;
            }
                if (textBox1.Text == "")
                {
                    textBox2.AppendText("There are no function to solve (f(x))" +Environment.NewLine);
                err = true;
            }
                if (textBox3.Text == "")
                {
                textBox2.AppendText("Enter first point (x0)" + Environment.NewLine);
                err = true;
            }
            if (textBox5.Text == "")
            {
                textBox2.AppendText("Enter tolerance value (tol)" + Environment.NewLine);
                err = true;
            }
            if (textBoxKMax.Text == "")
            {
                textBox2.AppendText("Enter maximum value of iterations (kMax)" + Environment.NewLine);
                err = true;
            }
            return err;
        }

        private void Start_Btn_Click(object sender, EventArgs e)
        {
            if (!getError())
            {
                double x0 = double.Parse(textBox3.Text, System.Globalization.NumberStyles.Any), fx0 = func(x0), tol = double.Parse(textBox5.Text, System.Globalization.NumberStyles.Any), H = tol, fx1, x1;
                int k = 0; bool solved = false;
                int kMax = int.Parse(textBoxKMax.Text);
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
                            solved = true;
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
                    } while (!solved && k < kMax);
                }
                else if (checkBoxMax.Checked)
                {
                    do
                    {
                        
                        if (k > 0)
                        {
                            textBox2.AppendText("false");
                            textBox2.AppendText(Environment.NewLine);
                        }

                        //x^3+x^2-8*x-8  max in point: x1*= –2.0; min in point: x2*= 1.33; find a minimum;
                        ++k;
                        textBox2.AppendText("Iteration " + k + ":");
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
                            solved = true;
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
                    } while ( (!solved) && k < kMax);
                }
                    SolY.Text = fx1.ToString();
                    SolX.Text = x1.ToString();
                    AbsH.Text = String.Format(Math.Abs(H).ToString(), "0e0");
            }
        }
    }
}
