using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T06_334v
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BTNWork_Click(object sender, EventArgs e)
        {
            double result = 0;

            for (int i = 1; i <= 100; i++)
                for (int j = 1; j <= 100; j++)
                    result += ((double)(j - i + 1) / (i + j));

            textBox1.Text = result.ToString();
        }
    }
}
