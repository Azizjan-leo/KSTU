using System;
using System.Windows.Forms;
using mszi.Classes;

namespace mszi
{
    public partial class AnalyticTransformationForm : Form
    {
        public AnalyticTransformationForm()
        {
            InitializeComponent();
        }
        private void btnAnalyticTransformationEnter_Click(object sender, EventArgs e)
        {
            if (txbxInputText.Text != "" && txbxKeyMatrix.Text != "")
            {
                double[,] keyMatrix;
                double[] wordVector;
                double[,] inverseMatrix;
                string inputText = txbxInputText.Text;
                string[] array = txbxKeyMatrix.Text.Trim().Replace("\r\n", "/").Split('/');
                int n = array.Length;
                if (n < 2)
                {
                    MessageBox.Show("Введите матрицу с размерностью больше 2", "Оповещение", MessageBoxButtons.OK);
                    return;
                }
                //заполнение матрицы
                keyMatrix = new double[n, n];
                for (int i = 0; i < array.Length; i++)
                {
                    string[] arrayrow = array[i].Split(' ');
                    if (arrayrow.Length != n)
                    {
                        MessageBox.Show("Матрица должна быть квадратной", "Оповещение", MessageBoxButtons.OK);
                        return;
                    }
                    for (int j = 0; j < arrayrow.Length; j++)
                    {
                        keyMatrix[i, j] = Convert.ToDouble(arrayrow[j]);
                    }
                    int k = 0;
                    
                }





            }
            
            
            
        }

        private void MatrixMMFunc()
        {
            //Matrix matrix=new Matrix();
            //matrix.SetMatrix(txbxKeyMatrix.Text);
            //if (rdbtnEncrypt.Checked)
            //{
            //    txbxOutputText.Text=matrix.Code(txbxInputText.Text);
            //}
            //else
            //{
            //    matrix.Decode(matrix.Code(txbxInputText.Text));
            //}
            
        }
    
    }
}
