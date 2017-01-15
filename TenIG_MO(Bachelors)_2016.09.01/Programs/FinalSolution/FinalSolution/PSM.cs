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
    public partial class PSM : Form
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

        public PSM()
        {
            InitializeComponent();
        }

        private void Start_Btn_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(textBox3.Text, System.Globalization.NumberStyles.Any), fx0 = func(x0), fx1, x1, Epsilon = double.Parse(textBox5.Text, System.Globalization.NumberStyles.Any), H0 = double.Parse(textBox6.Text, System.Globalization.NumberStyles.Any), H1 = H0, R = double.Parse(textBox7.Text, System.Globalization.NumberStyles.Any);
            int k = 0;
            textBox2.Text = "";

            textBox2.AppendText("Step 1: f(x0) = " + fx0);
            textBox2.AppendText(Environment.NewLine);

            textBox2.AppendText("Step 2 H1 = H0 => H1 = " + H1);
            textBox2.AppendText(Environment.NewLine);

            x1 = x0 + H1;
            textBox2.AppendText("Step 3 x1 = x0 + H1 => x1 = " + x0 + " + " + H1 + " = " + x1);
            textBox2.AppendText(Environment.NewLine);

            fx1 = func(x1);
            textBox2.AppendText("Step 4 Function(x1) = " + fx1);
            textBox2.AppendText(Environment.NewLine);

            k = 0;
            textBox2.AppendText("Step 5 k = " + k);
            textBox2.AppendText(Environment.NewLine);

            if (!minCheckBox.Checked)
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
                    textBox2.AppendText("Step 2 yf1 <= yf0 => " + fx1 + " <= " + fx0 + " - ");

                    if (fx1 <= fx0)
                    {
                        textBox2.AppendText("true");
                        textBox2.AppendText(Environment.NewLine);

                        textBox2.AppendText(" Step 3 ABS(H0) < Epsilon/R => " + Math.Abs(H0) + " < " + Epsilon + "/" + R + " - ");

                        if (Math.Abs(H0) < (Epsilon / R))
                        {
                            textBox2.AppendText("true");
                            textBox2.AppendText(Environment.NewLine);

                            H1 = H0;
                            textBox2.AppendText(" Step 4 H1 = H0 => H1 = " + H0);
                            textBox2.AppendText(Environment.NewLine);

                            x1 = x0;
                            textBox2.AppendText(" Step 5 x1 = x0 => x1 = " + x1);
                            textBox2.AppendText(Environment.NewLine);

                            fx1 = fx0;
                            textBox2.AppendText(" Step 6 yf1 = yf0 => yf1 = " + fx1);
                            textBox2.AppendText(Environment.NewLine);
                            break;
                        }
                        else
                        {
                            textBox2.AppendText("false");
                            textBox2.AppendText(Environment.NewLine);

                            H1 = -H0 / R;
                            textBox2.AppendText(" Step 4 H1 = -H0 / R => H1 = " + -H0 + " / " + R + " = " + H1);
                            textBox2.AppendText(Environment.NewLine);

                            H0 = H1;
                            textBox2.AppendText(" Step 5 H0 = H1 => H0 = " + H0);
                            textBox2.AppendText(Environment.NewLine);



                            x0 = x1; fx0 = fx1;
                            textBox2.AppendText(" Step 6 x0 = x1 => x0 = " + x0 + ";\t yf0 = yf1 => yf0 = " + fx0);
                            textBox2.AppendText(Environment.NewLine);

                            x1 = x0 + H1;
                            textBox2.AppendText(" Step 7 x1 = x0 + H1 => x1 = " + x0 + " + " + H1 + " = " + x1);
                            textBox2.AppendText(Environment.NewLine);



                            fx1 = func(x1);
                            textBox2.AppendText(" Step 8 Function(x1) = " + fx1);
                            textBox2.AppendText(Environment.NewLine);

                            textBox2.AppendText(" Step 9 ");//if(k < k_Max)*/
                        }
                    }
                    else
                    {
                        textBox2.AppendText("false");
                        textBox2.AppendText(Environment.NewLine);

                        H1 = H0;
                        textBox2.AppendText(" Step 3 H1 = H0 => H1 = " + H1);
                        textBox2.AppendText(Environment.NewLine);

                        x0 = x1;
                        fx0 = fx1;
                        textBox2.AppendText(" Step 4 x0 = x1 => x0 = " + x0 + ";        yf0 = yf1 => yf0 = " + fx0);
                        textBox2.AppendText(Environment.NewLine);

                        x1 = x0 + H1;
                        textBox2.AppendText(" Step 5 x1 = x0 + H1 => x1 = " + x0 + " + " + H1 + " = " + x1);
                        textBox2.AppendText(Environment.NewLine);

                        fx1 = func(x1);
                        textBox2.AppendText(" Step 6 Function(x1) = " + fx1);


                        textBox2.AppendText(" Step 7 ");
                    }

                } while (true);
            else // to find min
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
                    textBox2.AppendText("Step 2 yf1 >= yf0 => " + fx1 + " <= " + fx0 + " - ");

                    if (fx1 >= fx0)
                    {
                        textBox2.AppendText("true");
                        textBox2.AppendText(Environment.NewLine);

                        textBox2.AppendText(" Step 3 ABS(H0) < Epsilon/R => " + Math.Abs(H0) + " < " + Epsilon + "/" + R + " - ");

                        if (Math.Abs(H0) < (Epsilon / R))
                        {
                            textBox2.AppendText("true");
                            textBox2.AppendText(Environment.NewLine);

                            H1 = H0;
                            textBox2.AppendText(" Step 4 H1 = H0 => H1 = " + H0);
                            textBox2.AppendText(Environment.NewLine);

                            x1 = x0;
                            textBox2.AppendText(" Step 5 x1 = x0 => x1 = " + x1);
                            textBox2.AppendText(Environment.NewLine);

                            fx1 = fx0;
                            textBox2.AppendText(" Step 6 yf1 = yf0 => yf1 = " + fx1);
                            textBox2.AppendText(Environment.NewLine);
                            break;
                        }
                        else
                        {
                            textBox2.AppendText("false");
                            textBox2.AppendText(Environment.NewLine);

                            H1 = -H0 / R;
                            textBox2.AppendText(" Step 4 H1 = -H0 / R => H1 = " + -H0 + " / " + R + " = " + H1);
                            textBox2.AppendText(Environment.NewLine);

                            H0 = H1;
                            textBox2.AppendText(" Step 5 H0 = H1 => H0 = " + H0);
                            textBox2.AppendText(Environment.NewLine);



                            x0 = x1; fx0 = fx1;
                            textBox2.AppendText(" Step 6 x0 = x1 => x0 = " + x0 + ";\t yf0 = yf1 => yf0 = " + fx0);
                            textBox2.AppendText(Environment.NewLine);

                            x1 = x0 + H1;
                            textBox2.AppendText(" Step 7 x1 = x0 + H1 => x1 = " + x0 + " + " + H1 + " = " + x1);
                            textBox2.AppendText(Environment.NewLine);



                            fx1 = func(x1);
                            textBox2.AppendText(" Step 8 Function(x1) = " + fx1);
                            textBox2.AppendText(Environment.NewLine);

                            textBox2.AppendText(" Step 9 ");//if(k < k_Max)*/
                        }
                    }
                    else
                    {
                        textBox2.AppendText("false");
                        textBox2.AppendText(Environment.NewLine);

                        H1 = H0;
                        textBox2.AppendText(" Step 3 H1 = H0 => H1 = " + H1);
                        textBox2.AppendText(Environment.NewLine);

                        x0 = x1;
                        fx0 = fx1;
                        textBox2.AppendText(" Step 4 x0 = x1 => x0 = " + x0 + ";        yf0 = yf1 => yf0 = " + fx0);
                        textBox2.AppendText(Environment.NewLine);

                        x1 = x0 + H1;
                        textBox2.AppendText(" Step 5 x1 = x0 + H1 => x1 = " + x0 + " + " + H1 + " = " + x1);
                        textBox2.AppendText(Environment.NewLine);

                        fx1 = func(x1);
                        textBox2.AppendText(" Step 6 Function(x1) = " + fx1);


                        textBox2.AppendText(" Step 7 ");
                    }

                } while (true);
            }
            outX1.Text = x1.ToString();
            outAbsH0.Text = Math.Abs(H0).ToString();
            outYf1.Text = fx1.ToString();
        }

        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            minCheckBox.Checked = false;
        }
    }
}
