using System;
using System.Windows.Forms;

namespace Z09_705
{
    public partial class MainForm : Form
    {   
        private void btnWork_Click(object sender, System.EventArgs e)
        {
            // Матрица A.
            var A = new TextBox[,] {
                { tbA0, tbA1, tbA2 },
                { tbA3, tbA4, tbA5 },
                { tbA6, tbA7, tbA8 }
            };

            // Матрица B.
            var B = new TextBox[,] {
                { tbB1, tbB2, tbB3 },
                { tbB4, tbB5, tbB6 },
                { tbB7, tbB8, tbB9 }
            };

            // Матрица C.
            var C = new TextBox[,] {
                { tbC1, tbC2, tbC3 },
                { tbC4, tbC5, tbC6 },
                { tbC7, tbC8, tbC9 }
            };

            // Матрица результата.
            var R = new TextBox[,] {
                { tbR1, tbR2, tbR3 },
                { tbR4, tbR5, tbR6 },
                { tbR7, tbR8, tbR9 }
            };

            // Целочисленные матрицы.
            var AInt = new double[3, 3];
            var BInt = new double[3, 3];
            var CInt = new double[3, 3];
            var RInt = new double[3, 3];
            var TInt = new double[3, 3];

            var isOk = true;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (!double.TryParse(A[i, j].Text, out AInt[i, j])) isOk = false;
                    if (!double.TryParse(B[i, j].Text, out BInt[i, j])) isOk = false;
                }

            if (!isOk)
            {
                R[1, 1].Text = "Error!";
                return;
            }

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    CInt[i, j] = 1.0 / (2 + i + j);
                    C[i, j].Text = CInt[i, j].ToString();
                }

            var eMat = new double[A.Length, A.Length];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (i == j) eMat[i, j] = 1;
                    else eMat[i, j] = 0;
                }

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    BInt[i, j] -= eMat[i, j];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    RInt[i, j] = 0;

                    for (int g = 0; g < 3; g++)
                        RInt[j, i] += (BInt[i, g] * AInt[g, j]);
                }

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    TInt[i, j] = RInt[i, j] + CInt[i, j];
                    R[i, j].Text = TInt[i, j].ToString();
                }

        }

        public MainForm()
        {   
            InitializeComponent();

        }
    }
}
