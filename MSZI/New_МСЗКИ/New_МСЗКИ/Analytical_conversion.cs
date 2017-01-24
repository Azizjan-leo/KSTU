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
    public partial class Analytical_conversion : Form
    {
        int number;
        public double[,] KeyMatrix { get; set; }  
        public double[,] ReverseKeyMatrix { get; set; }
        public Analytical_conversion()
        {
            InitializeComponent();
            txbx_a11.Visible = false;
            txbx_a12.Visible = false;
            txbx_a13.Visible = false;
            txbx_a14.Visible = false;
            txbx_a21.Visible = false;
            txbx_a22.Visible = false;
            txbx_a23.Visible = false;
            txbx_a24.Visible = false;
            txbx_a31.Visible = false;
            txbx_a32.Visible = false;
            txbx_a33.Visible = false;
            txbx_a34.Visible = false;
            txbx_a41.Visible = false;
            txbx_a42.Visible = false;
            txbx_a43.Visible = false;
            txbx_a44.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = 0, s2 = 0;
            richTextBox2.Text = "";

            char[] Data = new char[0];

            for (int i = 1072; i <= 1103; i++)
            {
                Array.Resize(ref Data, Data.Length + 1);
                Data[Data.Length - 1] = (char)i;
            }

            Array.Resize(ref Data, Data.Length + 1);
            Data[Data.Length - 1] = ' ';

            char[] txt = richTextBox1.Text.ToLower().ToArray();
            int[] For_temp_table = new int[0];

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (txt.Length % 2 != 0)
                    {
                        Array.Resize(ref txt, txt.Length + 1);
                        txt[txt.Length - 1] = ' ';
                    }
                    s1 = 2;
                    Array.Resize(ref For_temp_table, For_temp_table.Length + 4);
                    For_temp_table[0] = int.Parse(txbx_a11.Text);
                    For_temp_table[1] = int.Parse(txbx_a12.Text);
                    For_temp_table[2] = int.Parse(txbx_a21.Text);
                    For_temp_table[3] = int.Parse(txbx_a22.Text);    
                    break;
                case 1:
                    if (txt.Length % 3 != 0)
                    {
                        int a = 3 - txt.Length % 3;
                        Array.Resize(ref txt, txt.Length + a);
                        for (int i = 1; i <= a; i++)
                        {
                            txt[txt.Length - i] = ' ';
                        }
                    }
                    s1 = 3;
                    Array.Resize(ref For_temp_table, For_temp_table.Length + 9);
                    For_temp_table[0] = int.Parse(txbx_a11.Text);
                    For_temp_table[1] = int.Parse(txbx_a12.Text);
                    For_temp_table[2] = int.Parse(txbx_a13.Text);
                    For_temp_table[3] = int.Parse(txbx_a21.Text);
                    For_temp_table[4] = int.Parse(txbx_a22.Text);
                    For_temp_table[5] = int.Parse(txbx_a23.Text);
                    For_temp_table[6] = int.Parse(txbx_a31.Text);
                    For_temp_table[7] = int.Parse(txbx_a32.Text);
                    For_temp_table[8] = int.Parse(txbx_a33.Text);
                    break;

                case 2:
                    if (txt.Length % 4 != 0)
                    {
                        int a = 4 - txt.Length % 4;
                        Array.Resize(ref txt, txt.Length + a);
                        for (int i = 1; i <= a; i++)
                        {
                            txt[txt.Length - i] = ' ';
                        }
                        
                    }
                    s1 = 4;
                    Array.Resize(ref For_temp_table, For_temp_table.Length + 16);
                    For_temp_table[0] = int.Parse(txbx_a11.Text);
                    For_temp_table[1] = int.Parse(txbx_a12.Text);
                    For_temp_table[2] = int.Parse(txbx_a13.Text);
                    For_temp_table[3] = int.Parse(txbx_a14.Text);
                    For_temp_table[4] = int.Parse(txbx_a21.Text);
                    For_temp_table[5] = int.Parse(txbx_a22.Text);
                    For_temp_table[6] = int.Parse(txbx_a23.Text);
                    For_temp_table[7] = int.Parse(txbx_a24.Text);
                    For_temp_table[8] = int.Parse(txbx_a31.Text);
                    For_temp_table[9] = int.Parse(txbx_a32.Text);
                    For_temp_table[10] = int.Parse(txbx_a33.Text);
                    For_temp_table[11] = int.Parse(txbx_a34.Text);
                    For_temp_table[12] = int.Parse(txbx_a41.Text);
                    For_temp_table[13] = int.Parse(txbx_a42.Text);
                    For_temp_table[14] = int.Parse(txbx_a43.Text);
                    For_temp_table[15] = int.Parse(txbx_a44.Text);
                    break;
            }

            int b = txt.Length;

            int[] mat = new int[b];


            for (int i = 0; i < b; i++)
            {
                int d = 0;

                for (int z = 0; z < Data.Length; z++)
                {
                    if (txt[i] == Data[z])
                    {
                        d = z;
                        mat[i] = d;
                    }
                }
            }

            s2 = txt.Length / s1;

            int[,] Main_table = new int[s2, s1];
            int[,] Temp_table = new int[s1, s1];
            int k = 0;
            for (int i = 0; i < s2; i++ )
            {
                for (int j = 0; j < s1; j++)
                {
                    Main_table[i, j] = mat[k];
                    k++;
                }
            }
            k = 0;
            for (int i = 0; i < s1; i++)
            {
                for (int j = 0; j < s1; j++)
                {
                    Temp_table[i, j] = For_temp_table[k];
                    k++;
                }
            }

            int[,] Out_table = new int[s1, s2];
            Out_table = MatrixMultiplication(Main_table, Temp_table, s1, s2);
            string For_Print = "";
            for (int i = 0; i < s1; i++)
            {
                for (int j = 0; j < s2; j++)
                {
                    For_Print += Out_table[i, j];
                    if(j < s2 - 1)
                        For_Print += "\t";
                }
                richTextBox2.Text += For_Print;
                if (i < s1 - 1)
                    richTextBox2.Text += "\r";
                For_Print = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    txbx_a11.Visible = true;
                    txbx_a12.Visible = true;
                    txbx_a13.Visible = false;
                    txbx_a14.Visible = false;
                    txbx_a21.Visible = true;
                    txbx_a22.Visible = true;
                    txbx_a23.Visible = false;
                    txbx_a24.Visible = false;
                    txbx_a31.Visible = false;
                    txbx_a32.Visible = false;
                    txbx_a33.Visible = false;
                    txbx_a34.Visible = false;
                    txbx_a41.Visible = false;
                    txbx_a42.Visible = false;
                    txbx_a43.Visible = false;
                    txbx_a44.Visible = false;
                    break;
                case 1:
                    txbx_a11.Visible = true;
                    txbx_a12.Visible = true;
                    txbx_a13.Visible = true;
                    txbx_a14.Visible = false;
                    txbx_a21.Visible = true;
                    txbx_a22.Visible = true;
                    txbx_a23.Visible = true;
                    txbx_a24.Visible = false;
                    txbx_a31.Visible = true;
                    txbx_a32.Visible = true;
                    txbx_a33.Visible = true;
                    txbx_a34.Visible = false;
                    txbx_a41.Visible = false;
                    txbx_a42.Visible = false;
                    txbx_a43.Visible = false;
                    txbx_a44.Visible = false;
                    break;

                case 2:
                    txbx_a11.Visible = true;
                    txbx_a12.Visible = true;
                    txbx_a13.Visible = true;
                    txbx_a14.Visible = true;
                    txbx_a21.Visible = true;
                    txbx_a22.Visible = true;
                    txbx_a23.Visible = true;
                    txbx_a24.Visible = true;
                    txbx_a31.Visible = true;
                    txbx_a32.Visible = true;
                    txbx_a33.Visible = true;
                    txbx_a34.Visible = true;
                    txbx_a41.Visible = true;
                    txbx_a42.Visible = true;
                    txbx_a43.Visible = true;
                    txbx_a44.Visible = true;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1 = 0, s2 = 0;
            richTextBox1.Text = "";

            char[] Data = new char[0];

            for (int i = 1072; i <= 1103; i++)
            {
                Array.Resize(ref Data, Data.Length + 1);
                Data[Data.Length - 1] = (char)i;
            }

            Array.Resize(ref Data, Data.Length + 1);
            Data[Data.Length - 1] = ' ';

            string[] txt = richTextBox2.Text.Split('\t', '\n');
            double[] Main_Matrix = new double[txt.Length];
            for (int i = 0; i < txt.Length; i++ )
            {
                Main_Matrix[i] = double.Parse(txt[i]);
            }
            int[] For_temp_table = new int[0];

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (Main_Matrix.Length % 2 != 0)
                    {
                        Array.Resize(ref txt, txt.Length + 1);
                        Main_Matrix[txt.Length - 1] = 0;
                    }
                    s1 = 2;
                    Array.Resize(ref For_temp_table, For_temp_table.Length + 4);
                    For_temp_table[0] = int.Parse(txbx_a11.Text);
                    For_temp_table[1] = int.Parse(txbx_a12.Text);
                    For_temp_table[2] = int.Parse(txbx_a21.Text);
                    For_temp_table[3] = int.Parse(txbx_a22.Text);
                    break;
                case 1:
                    if (Main_Matrix.Length % 3 != 0)
                    {
                        int a = 3 - txt.Length % 3;
                        Array.Resize(ref txt, txt.Length + a);
                        for (int i = 1; i <= a; i++)
                        {
                            Main_Matrix[txt.Length - i] = 0;
                        }
                    }
                    s1 = 3;
                    Array.Resize(ref For_temp_table, For_temp_table.Length + 9);
                    For_temp_table[0] = int.Parse(txbx_a11.Text);
                    For_temp_table[1] = int.Parse(txbx_a12.Text);
                    For_temp_table[2] = int.Parse(txbx_a13.Text);
                    For_temp_table[3] = int.Parse(txbx_a21.Text);
                    For_temp_table[4] = int.Parse(txbx_a22.Text);
                    For_temp_table[5] = int.Parse(txbx_a23.Text);
                    For_temp_table[6] = int.Parse(txbx_a31.Text);
                    For_temp_table[7] = int.Parse(txbx_a32.Text);
                    For_temp_table[8] = int.Parse(txbx_a33.Text);
                    break;

                case 2:
                    if (Main_Matrix.Length % 4 != 0)
                    {
                        int a = 4 - txt.Length % 4;
                        Array.Resize(ref txt, txt.Length + a);
                        for (int i = 1; i <= a; i++)
                        {
                            Main_Matrix[txt.Length - i] = 0;
                        }

                    }
                    s1 = 4;
                    Array.Resize(ref For_temp_table, For_temp_table.Length + 16);
                    For_temp_table[0] = int.Parse(txbx_a11.Text);
                    For_temp_table[1] = int.Parse(txbx_a12.Text);
                    For_temp_table[2] = int.Parse(txbx_a13.Text);
                    For_temp_table[3] = int.Parse(txbx_a14.Text);
                    For_temp_table[4] = int.Parse(txbx_a21.Text);
                    For_temp_table[5] = int.Parse(txbx_a22.Text);
                    For_temp_table[6] = int.Parse(txbx_a23.Text);
                    For_temp_table[7] = int.Parse(txbx_a24.Text);
                    For_temp_table[8] = int.Parse(txbx_a31.Text);
                    For_temp_table[9] = int.Parse(txbx_a32.Text);
                    For_temp_table[10] = int.Parse(txbx_a33.Text);
                    For_temp_table[11] = int.Parse(txbx_a34.Text);
                    For_temp_table[12] = int.Parse(txbx_a41.Text);
                    For_temp_table[13] = int.Parse(txbx_a42.Text);
                    For_temp_table[14] = int.Parse(txbx_a43.Text);
                    For_temp_table[15] = int.Parse(txbx_a44.Text);
                    break;
            }


            s2 = Main_Matrix.Length / s1;

            double[,] Main_table = new double[s2, s1];

            KeyMatrix = new double[s1, s1];
            ReverseKeyMatrix = new double[s1, s1];

            int k = 0;
            for (int i = 0; i < s1; i++)
            {
                for (int j = 0; j < s1; j++)
                {
                    KeyMatrix[i, j] = For_temp_table[k];
                    k++;
                }
            }

            SetReverseMatrix();

            k = 0;
            for (int i = 0; i < s1; i++)
            {
                for (int j = 0; j < s2; j++)
                {
                    Main_table[j, i] = Main_Matrix[k];
                    k++;
                }
            }

            double[,] Out_table = new double[s2, s1];
            int[,] Out_table1 = new int[s1, s2];
            Out_table = MatrixMultiplication1(Main_table, ReverseKeyMatrix, s1, s2);

            for (int i = 0; i < s1; i++)
            {
                for (int j = 0; j < s2; j++)
                {
                    Out_table1[i, j] = Convert.ToInt32(Out_table[i, j]);
                }
            }
            string For_Out = "";
            for (int i = 0; i < s2; i++)
            {
                for (int j = 0; j < s1; j++)
                {
                    For_Out += Convert.ToChar(Out_table1[j, i] + 1072);
                }
            }
            richTextBox1.Text = For_Out;
        }
        private int[,] MatrixMultiplication(int[,] First, int[,] Second, int s1, int s2)
         {
            int [,] Third = new int [s1, s2];
            for (int i = 0; i < s1; i++)
            {
                for (int j = 0; j < s2; j++)
                {
                    for (int k = 0; k < s1; k++)
                    {
                        Third[i, j] +=  Second[i, k] * First[j, k];
                    }
                }
            }
            return Third;
        }

        private double[,] MatrixMultiplication1(double[,] First, double[,] Second, int s1, int s2)
        {
            double[,] Third = new double[s1, s2];
            for (int i = 0; i < s1; i++)
            {
                for (int j = 0; j < s2; j++)
                {
                    for (int k = 0; k < s1; k++)
                    {
                        Third[i, j] += Second[i, k] * First[j, k];
                    }
                }
            }
            return Third;
        }

        public void SetReverseMatrix()
        {
            var n = (int)Math.Sqrt(KeyMatrix.Length);
            var ed = new double[n, n];
            double[,] or = (double[,])KeyMatrix.Clone();
            double item;
            for (var i = 0; i < n; i++)
                for (var j = 0; j < n; j++)
                    ed[i, j] = i == j ? 1 : 0;
            for (var k = 0; k < n; k++)
            {
                int i;
                if (or[k, k] == 0)
                {
                    for (i = k; i < n; i++)
                        if (or[i, k] != 0)
                        {
                            for (var j = 0; j < n; j++)
                            {
                                item = or[i, j];
                                or[i, j] = or[k, j];
                                or[k, j] = item;
                                item = ed[i, j];
                                ed[i, j] = ed[k, j];
                                ed[k, j] = item;
                            }
                            break;
                        }
                    if (i == n)
                        throw new Exception("Matrix is singular");
                }
                item = or[k, k];
                for (var j = 0; j < n; j++)
                {
                    or[k, j] = or[k, j] / item;
                    ed[k, j] = ed[k, j] / item;
                }
                for (i = k + 1; i < n; i++)
                {
                    item = or[i, k];
                    for (var j = 0; j < n; j++)
                    {
                        or[i, j] -= or[k, j] * item;
                        ed[i, j] -= ed[k, j] * item;
                    }
                }
            }
            for (var k = n - 1; k >= 1; k--)
            {
                for (var i = k - 1; i >= 0; i--)
                {
                    item = or[i, k];
                    for (var j = 0; j < n; j++)
                    {
                        or[i, j] -= or[k, j] * item;
                        ed[i, j] -= ed[k, j] * item;
                    }
                }
            }
            ReverseKeyMatrix = ed;
        }

        double[,] Inversion(double[,] Ar, int N)
        {
            double[,] A = new double[N, N];
            double temp;
            double[,] E = new double[N, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    E[i, j] = 0.0;
                    if (i == j)
                        E[i, j] = 1.0;
                }
            for (int k = 0; k < N; k++)
            {
                temp = Ar[k, k];
                for (int j = 0; j < N; j++)
                {
                    Ar[k, j] /= temp;
                    E[k, j] /= temp;
                }
                for (int i = k + 1; i < N; i++)
                {
                    temp = Ar[i, k];
                    for (int j = 0; j < N; j++)
                    {
                        Ar[i, j] -= Ar[k, j] * temp;
                        E[i, j] -= E[k, j] * temp;
                    }
                }
            }
            for (int k = N - 1; k > 0; k--)
            {
                for (int i = k - 1; i >= 0; i--)
                {
                    temp = Ar[i, k];
                    for (int j = 0; j < N; j++)
                    {
                        Ar[i, j] -= Ar[k, j] * temp;
                        E[i, j] -= E[k, j] * temp;
                    }
                }
            }
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    A[i, j] = Ar[i, j] = E[i, j];
            E = null;
            return A;
        }
    }
}