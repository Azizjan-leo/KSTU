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
    public partial class NSM : Form
    {
        public ExpressionParser parser = new ExpressionParser();


        public void GSM_Load(object sender, EventArgs e)
        {
            parser.Values.Add("x", 0);
        }


        public double diff_func(double x)
        {
            return (func(x + 0.00001 / 2) - func(x - 0.00001 / 2)) / 0.00001;
        }

        public double double_diff_func(double x)
        {
            return (diff_func(x + 0.00001 / 2) - diff_func(x - 0.00001 / 2)) / 0.00001;
        }

        public void NewLine()
        {
            textBox2.AppendText(Environment.NewLine);
        }

        public double func(double x)
        {

            parser.Values.Remove("x");
            parser.Values.Add("x", x);
            return parser.Parse(inFx.Text);

        }

        //x^3+x^2-8*x-8
        public NSM()
        {
            InitializeComponent();
        }

        public bool sign(double num1, double num2)
        {
            return num1 >= 0 && num2 >= 0 || num1 < 0 && num2 < 0;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            double RelError, DP = 0, DPO = 0, dfx1, ddfx1, x0 = double.Parse(inX0.Text, System.Globalization.NumberStyles.Any), R = double.Parse(inR.Text), Delta = double.Parse(inDelta.Text), fx1, fx0 = func(x0), dfx0, ddfx0, Epsilon = double.Parse(inEpsilon.Text, System.Globalization.NumberStyles.Any), x1;
            int k = 0, cond = 0, step = 0, d = 0, k_Max = int.Parse(inKMax.Text);

            textBox2.AppendText("Step 1 cond = 0");
            textBox2.AppendText(Environment.NewLine);


            textBox2.AppendText("Step 2 yfx0 = f(x0) = " + fx0);
            NewLine();

            dfx0 = diff_func(x0);
            textBox2.AppendText("Step 3 dfx0 = f'(x0) = " + dfx0);
            NewLine();

            ddfx0 = double_diff_func(x0);
            textBox2.AppendText("Step 4 ddfx0 = f''(x0) = " + ddfx0);
            NewLine();

            k = 0;

            do
            {
                if (k > 0) textBox2.AppendText("true");

                textBox2.AppendText("Iteration " + (k + 1));
                NewLine();

                textBox2.AppendText(" Step " + ++step + " k = k + 1 => k = " + k + " + 1 = " + ++k);
                NewLine();
                textBox2.AppendText(" Step 2 abs(ddfx0) <= Epsilon => " + Math.Abs(ddfx0) + " <= " + Epsilon + " - ");
                if (Math.Abs(ddfx0) <= Epsilon)
                {
                    textBox2.AppendText("true");
                    NewLine();

                    textBox2.AppendText(" Step 3 cond = 1");
                    NewLine();
                    cond = 1;
                }
                else
                {
                    textBox2.AppendText("false");
                    NewLine();

                    DP = dfx0 / ddfx0;
                    textBox2.AppendText(" Step 3 DP = dfx0 / ddfx0 => DP = " + dfx0 + " / " + ddfx0 + " = " + DP);
                    NewLine();
                }
                textBox2.AppendText(" Step 4 k == 1 => " + k + " = 1 - ");
                if (k == 1)
                {
                    textBox2.AppendText("true");
                    NewLine();
                    d = 1;

                    DPO = DP;
                    textBox2.AppendText(" Step 5 DPO = DP => DPO = " + DP);
                    NewLine();
                }
                else
                {
                    textBox2.AppendText("false");
                    NewLine();
                }
                textBox2.AppendText(" Step " + (4 + d) + " sign(DPO) == sign(DP) => sign(" + DPO + ") == sign(" + DP + ") - ");

                if (sign(DPO , DP))
                {
                    textBox2.AppendText("true");
                    NewLine();

                    x1 = x0 - DP;
                    textBox2.AppendText(" Step " + (5 + d) + " x1 = x0 - DP => " + "x1 = " + x0 + " - " + DP + " = " + x1 );
                    NewLine();
                }
                else
                {
                    textBox2.AppendText("false");
                    NewLine();

                    x1 = x0 - DP / R;
                    textBox2.AppendText(" Step " + (6 + d) + " x1 = x0 - DP / R => " + "x1 = " + x0 + " - " + DP + " / " + R + " = " + x1);
                    NewLine();
                }

                DPO = DP;
                textBox2.AppendText(" Step " + (7 + d) + " DPO = DP => DPO = " + DPO);
                NewLine();

                fx1 = func(x1);
                textBox2.AppendText(" Step " + (8 + d) + " yf1 = f(x1) = " + fx1);

                dfx1 = diff_func(x1);
                textBox2.AppendText(" Step " + (9 + d) + " dfx1 = f'(x1) = " + dfx1);
                NewLine();

                ddfx1 = double_diff_func(x1);
                textBox2.AppendText(" Step " + (10 + d) + " ddfx1 = f''(x1) = " + ddfx1);
                NewLine();

                RelError = 2 * Math.Abs(DP) / (Math.Abs(x1) + Epsilon);
                textBox2.AppendText(" Step " + (11 + d) + " RelError = 2 * abs(DP) / (abs(x1) + Epsilon) => RelError = 2 * abs(" + DP + ") / (abs(" + x1 + ") + " + Epsilon + ") = " + RelError);
                NewLine();

                textBox2.AppendText(" Step " + (12 + d) + " RelError < Delta => " + RelError + " < " + Delta + " - ");                if (RelError < Delta)
                {
                    textBox2.AppendText("true");
                    NewLine();
                    d++;

                    textBox2.AppendText(" Step " + (12 + d) + " cond <> 1 => " + cond + " <> 1 - ");
                    if (cond != 1)
                    {
                        textBox2.AppendText("true");
                        NewLine();
                        d++;

                        textBox2.AppendText(" Step " + (12 + d) + " cond = 2");
                        NewLine();
                        cond = 2;
                    }
                    else
                    {
                        textBox2.AppendText("false");
                        NewLine();
                    }
                }
                else
                {
                    textBox2.AppendText("false");
                    NewLine();
                }

                textBox2.AppendText(" Step " + (13 + d) + " x0 = x1 => x0 = " + x1 + "; dfx0 = dfx1 => dfx0 = " + dfx1 + "; ddfx0 = ddfx1 => ddfx0 = " + ddfx1 + ";");
                NewLine();
                x0 = x1; dfx0 = dfx1; ddfx0 = ddfx1;

                textBox2.AppendText(" Step " + (14 + d) + " k < k_Max & cond == 0 => " + k + " < " + k_Max + " & " + cond + " == 0 - ");
                NewLine();
            } while (k < k_Max & cond == 0);

            textBox2.AppendText("false");
            NewLine();

            NoutX1.Text = x1.ToString();
            outYf1.Text = fx1.ToString();
            outK.Text = k.ToString();
            outRelError.Text = RelError.ToString();
            outCond.Text = cond.ToString();

        }




        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            inDelta.Text = "";
            inX0.Text = "";
            inKMax.Text = "";
            inEpsilon.Text = "";
            inR.Text = "";
            inFx.Text = "";

            outCond.Text = "";
            outK.Text = "";
            outRelError.Text = "";
            outYf1.Text = "";
            NoutX1.Text = "";
            textBox2.Text = "";
        }
    }

}
