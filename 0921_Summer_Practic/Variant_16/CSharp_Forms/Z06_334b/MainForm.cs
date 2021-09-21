using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Z06_334b
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            double result = 0;

            // Рассчёт результата.
            for (int i = 1; i <= 100; i++)
                for (int j = 1; j <= 60; j++)
                    result += System.Math.Sin(Math.Pow(i, 3) + Math.Pow(j, 4));

            // Вывод на экран.
            tbResult.Text = result.ToString();
        }
    }
}
