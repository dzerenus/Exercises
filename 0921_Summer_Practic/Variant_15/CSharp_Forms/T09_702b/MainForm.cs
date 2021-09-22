using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T09_702b
{
    public partial class MainForm : Form
    {
        List<double> INums = new List<double>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOkN_Click(object sender, EventArgs e)
        {
            int n = 0;
            INums.Clear();

            // Пытаемс перевести текст из поля N в число.
            if (!Int32.TryParse(tbN.Text, out n)) 
                MessageBox.Show("Ошибка ввода N!");

            // Если удаётся, то изменяем кол-во столбцов в таблице.
            else
            {
                if (n == 0) return;

                DGMatrix.Columns.Clear();
                DGMatrix.Rows.Clear();

                while (DGMatrix.Columns.Count < n)
                    DGMatrix.Columns.Add($"{n}", "");

                while (DGMatrix.Rows.Count < n)
                    DGMatrix.Rows.Add();
            }

            btnWork.Enabled = true;

            // Рассчитываем числа i.
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    INums.Add(1.0 / (i * i + 2));
                else
                    INums.Add(1.0 / i);
            }

            tbINumbers.Text = "[ ";
            for (int i = 0; i < n; i++)
                tbINumbers.Text += $"{INums[i]} ";
            tbINumbers.Text += "]";
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            int cols = DGMatrix.Columns.Count;
            int rows = DGMatrix.Rows.Count;

            var nums = new double[cols, rows];

            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                {
                    if (!Double.TryParse(DGMatrix[i, j].Value.ToString(), out nums[i, j]))
                    {
                        MessageBox.Show("Ошибка ввода матрицы!");
                        return;
                    }
                }

            var res = new double[cols];
            for (int i = 0; i < cols; i++)
            {
                res[i] = 0;

                for (int j = 0; j < cols; j++)
                    res[i] += nums[j, i] * INums[j];
            }

            tbResult.Text = "[ ";
            for (int i = 0; i < cols; i++)
                tbResult.Text += $"{res[i].ToString("#.##")} ";
            tbResult.Text += " ]";
        }
    }
}
