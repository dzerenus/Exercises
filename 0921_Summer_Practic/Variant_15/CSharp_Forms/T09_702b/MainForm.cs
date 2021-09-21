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
        List<double> iNums = new List<double>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOkN_Click(object sender, EventArgs e)
        {
            int n = 0;

            if (!Int32.TryParse(tbN.Text, out n)) MessageBox.Show("Ошибка ввода N!");

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
        }
    }
}
