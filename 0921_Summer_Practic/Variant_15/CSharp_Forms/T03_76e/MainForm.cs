using System;
using System.Windows.Forms;

namespace _03_76e
{
    public partial class MForm : Form
    {
        public MForm()
        {
            InitializeComponent();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            int xSize, ySize, xStart, yStart, xEnd, yEnd;

            bool res = true;

            if (!Int32.TryParse(tbSizeX.Text, out xSize)) res = false;
            if (!Int32.TryParse(tbSizeY.Text, out ySize)) res = false;
            if (!Int32.TryParse(tbStartX.Text, out xStart)) res = false;
            if (!Int32.TryParse(tbStartY.Text, out yStart)) res = false;
            if (!Int32.TryParse(tbEndX.Text, out xEnd)) res = false;
            if (!Int32.TryParse(tbEndY.Text, out yEnd)) res = false;

            if (!res || xStart >= xSize || yStart >= ySize || xSize < 0 || ySize < 0 ||
                xStart < 0 || yStart < 0 || xEnd < 0 || yEnd < 0|| xEnd >= xSize || yEnd >= ySize)
            {
                tbResult.Text = "Ошибка ввода данных!";
                return;
            }

            if ((xStart+yStart)%2 != (xEnd+yEnd)%2)
            {
                tbResult.Text = "Ходов нет, так как поля разного цвета";
                return;
            }

            int d1 = Math.Abs(xEnd - yStart);
            int d2 = Math.Abs(yEnd - xStart);

            if (d1 == d2)
                tbResult.Text = "Нужен один ход.";
            else
                tbResult.Text = $"Два хода. Сперва сдвинуться по диагонали на {Math.Sqrt(d1*d1+d2*d2)} кл., потом добраться до конца.";    
        }
    }
}
