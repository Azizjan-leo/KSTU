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
    public partial class GSM : Form
    {
        public ExpressionParser parser = new ExpressionParser();


        public void GSM_Load(object sender, EventArgs e)
        {
            parser.Values.Add("x", 0);
        }


        public double func(double x)
        {
            parser.Values.Remove("x");
            parser.Values.Add("x", x);
            return parser.Parse(InFx.Text);

        }
       
        //x^3+x^2-8*x-8
        public GSM()
        {
            InitializeComponent();
        }

        public bool getError()
        {

            bool err = false;
            Calcs.Text = "";
            if ((!minCheckBox.Checked && !maxCheckBox.Checked) || (minCheckBox.Checked && maxCheckBox.Checked))
            {
                Calcs.AppendText("Choose what to find (min or max)" + Environment.NewLine);
                err = true;
            }
            if (InFx.Text == "")
            {
                Calcs.AppendText("There are no function to solve (f(x))" + Environment.NewLine);
                err = true;
            }
            if (InA.Text == "")
            {
                Calcs.AppendText("Enter left point (A)" + Environment.NewLine);
                err = true;
            }
            if (InB.Text == "")
            {
                Calcs.AppendText("Enter right point (B)" + Environment.NewLine);
                err = true;
            }
            if (InTol.Text == "")
            {
                Calcs.AppendText("Enter tolerance value (tol)" + Environment.NewLine);
                err = true;
            }
            if(InKMax.Text == "")
            {
                Calcs.AppendText("Enter maximum value of iterations (kMax)" + Environment.NewLine);
                err = true;
            }
            return err;
        }

        private void Start_Btn_Click(object sender, EventArgs e)
        {
            if (!getError())
            {
                double a = double.Parse(InA.Text, System.Globalization.NumberStyles.Any), b = double.Parse(InB.Text, System.Globalization.NumberStyles.Any), tol = double.Parse(InTol.Text, System.Globalization.NumberStyles.Any), x1, x2, fx1, fx2, r;
                int k = 0, kMax = int.Parse(InKMax.Text);
                Calcs.Text = "";

                r = (Math.Sqrt(5.0) - 1) / 2;
                Calcs.AppendText(" Step 1 r = (5^1/2 - 1) / 2 =  " + r);
                Calcs.AppendText(Environment.NewLine);

                x1 = a + (1 - r) * (b - a);
                Calcs.AppendText(" Step 2 x1 = a + (1 - r) * (b - a) => x1 =  " + x1);
                Calcs.AppendText(Environment.NewLine);

                fx1 = func(x1);
                Calcs.AppendText(" Step 3 f(x1) = " + fx1);
                Calcs.AppendText(Environment.NewLine);

                x2 = a + r * (b - a);
                Calcs.AppendText(" Step 4 x2 = a + r * (b - a) => x2 = " + x2);
                Calcs.AppendText(Environment.NewLine);

                fx2 = func(x2);
                Calcs.AppendText(" Step 5 f(x2) = ");

                k = 0;
                Calcs.AppendText(Environment.NewLine);
                if (!minCheckBox.Checked)
                {
                    do
                    {

                        if (k > 0)
                        {
                            Calcs.AppendText("true");
                            Calcs.AppendText(Environment.NewLine);
                        }
                        // Step 1
                        Calcs.AppendText("Iteration " + ++k);
                        Calcs.AppendText(Environment.NewLine);

                        Calcs.AppendText(" Step 1 k = k + 1 = " + k);
                        Calcs.AppendText(Environment.NewLine);

                        // Step 2
                        Calcs.AppendText(" Step 2 yf1 < yf2 => " + fx1 + " < " + fx2 + " - ");

                        if (fx1 < fx2)
                        {
                            Calcs.AppendText("true");
                            Calcs.AppendText(Environment.NewLine);

                            Calcs.AppendText(" Step 3 a = x1 => a = " + x1);
                            a = x1;
                            Calcs.AppendText(Environment.NewLine);

                            Calcs.AppendText(" Step 4 x1 = x2 => x1 = " + x2);
                            x1 = x2;
                            Calcs.AppendText(Environment.NewLine);

                            Calcs.AppendText(" Step 5 f1 = f2 => f1 = " + fx2);
                            fx1 = fx2;
                            Calcs.AppendText(Environment.NewLine);

                            x2 = a + r * (b - a);
                            Calcs.AppendText(" Step 6 x2 = a + r * (b - a) => x2 = " + x2);
                            Calcs.AppendText(Environment.NewLine);

                            fx2 = func(x2);
                        }
                        else
                        {
                            Calcs.AppendText("false");
                            Calcs.AppendText(Environment.NewLine);

                            b = x2;
                            Calcs.AppendText(" Step 3 b = x2 => b = " + b);
                            Calcs.AppendText(Environment.NewLine);

                            x2 = x1;
                            Calcs.AppendText(" Step 4 x2 = x1 => x2 = " + x2);
                            Calcs.AppendText(Environment.NewLine);

                            fx2 = fx1;
                            Calcs.AppendText(" Step 5 f2 = f1 => f2 = " + fx2);
                            Calcs.AppendText(Environment.NewLine);

                            x1 = a + (1 - r) * (b - a);
                            Calcs.AppendText(" Step 6 x1 = a + r * (b - a) => x2 = " + x1);
                            Calcs.AppendText(Environment.NewLine);

                            fx1 = func(x1);
                            Calcs.AppendText(" Step 7 f(x1) = " + fx1);
                            Calcs.AppendText(Environment.NewLine);

                        }

                    } while ((Math.Abs((b - a)) > tol) && k < kMax);

                    outX1.Text = x1.ToString();
                    outAbsBA.Text = Math.Abs(b - a).ToString();

                    SolY.Text = fx1.ToString();
                }
                else
                {
                    do
                    {

                        if (k > 0)
                        {
                            Calcs.AppendText("true");
                            Calcs.AppendText(Environment.NewLine);
                        }
                        // Step 1
                        Calcs.AppendText("Iteration " + ++k);
                        Calcs.AppendText(Environment.NewLine);

                        Calcs.AppendText(" Step 1 k = k + 1 = " + k);
                        Calcs.AppendText(Environment.NewLine);

                        // Step 2
                        Calcs.AppendText(" Step 2 yf1 < yf2 => " + fx1 + " < " + fx2 + " - ");

                        if (fx1 > fx2)
                        {
                            Calcs.AppendText("true");
                            Calcs.AppendText(Environment.NewLine);

                            Calcs.AppendText(" Step 3 a = x1 => a = " + x1);
                            a = x1;
                            Calcs.AppendText(Environment.NewLine);

                            Calcs.AppendText(" Step 4 x1 = x2 => x1 = " + x2);
                            x1 = x2;
                            Calcs.AppendText(Environment.NewLine);

                            Calcs.AppendText(" Step 5 f1 = f2 => f1 = " + fx2);
                            fx1 = fx2;
                            Calcs.AppendText(Environment.NewLine);

                            x2 = a + r * (b - a);
                            Calcs.AppendText(" Step 6 x2 = a + r * (b - a) => x2 = " + x2);
                            Calcs.AppendText(Environment.NewLine);

                            fx2 = func(x2);
                        }
                        else
                        {
                            Calcs.AppendText("false");
                            Calcs.AppendText(Environment.NewLine);

                            b = x2;
                            Calcs.AppendText(" Step 3 b = x2 => b = " + b);
                            Calcs.AppendText(Environment.NewLine);

                            x2 = x1;
                            Calcs.AppendText(" Step 4 x2 = x1 => x2 = " + x2);
                            Calcs.AppendText(Environment.NewLine);

                            fx2 = fx1;
                            Calcs.AppendText(" Step 5 f2 = f1 => f2 = " + fx2);
                            Calcs.AppendText(Environment.NewLine);

                            x1 = a + (1 - r) * (b - a);
                            Calcs.AppendText(" Step 6 x1 = a + r * (b - a) => x2 = " + x1);
                            Calcs.AppendText(Environment.NewLine);

                            fx1 = func(x1);
                            Calcs.AppendText(" Step 7 f(x1) = " + fx1);
                            Calcs.AppendText(Environment.NewLine);

                        }

                    } while ((Math.Abs((b - a)) > tol) && k < kMax);

                    outX1.Text = x1.ToString();
                    outAbsBA.Text = Math.Abs(b - a).ToString();

                    SolY.Text = fx1.ToString();
                }
            }
        }

   private void button2_Click_1(object sender, EventArgs e)
        {
            minCheckBox.Checked = false;
            maxCheckBox.Checked = false;
            Calcs.Text = "";
            outX1.Text = "";
            outAbsBA.Text = "";
            SolY.Text = "";
        }
    }
}