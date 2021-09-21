using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z03_76d
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BTNWork_Click(object sender, EventArgs e)
        {   
            // Занимаем все необходимые переменные.
            int xSize, ySize, xStart, yStart, xEnd, yEnd;

            bool error = false; // Создаём bool под ошибку.
            
            // Переводим все текстовые поля в Integer.
            if (!Int32.TryParse(tbSizeX.Text, out xSize)) error = true;
            if (!Int32.TryParse(tbSizeY.Text, out ySize)) error = true;
            if (!Int32.TryParse(tbStartX.Text, out xStart)) error = true;
            if (!Int32.TryParse(tbStartY.Text, out yStart)) error = true;
            if (!Int32.TryParse(tbEndX.Text, out xEnd)) error = true;
            if (!Int32.TryParse(tbEndY.Text, out yEnd)) error = true;

            // Если в какой-то строке не было числа, то выводим сообщение об ошибке.
            if (error) tbResult.Text = "ОШИБКА! Неверный ввод данных, повторите ввод!";

            else
            {   
                // Координаты не могут быть больше размера поля.
                if (xStart >= xSize || xEnd >= xSize || yStart >= ySize || yEnd >= ySize)
                {
                    tbResult.Text = "ОШИБКА! Координаты не могут быть равны или превышать размер поля!";
                    return;
                }
                
                // Проверяем, можно ли добраться до цели за один ход.
                if (xStart == xEnd || yStart == yEnd || (xStart-yEnd == yStart-xEnd))
                    tbResult.Text = "До цели можно добраться за один ход.";
                
                // Если не получилось, рассчитываем за два хода.
                else
                {   
                    // Рассчитываем смещение.
                    int x = xEnd - xStart;
                    int y = yEnd - yStart;

                    tbResult.Text = $"Сперва сместиться по Х на {x} клеток, потом по Y на {y} клеток.";
                }

            }
        }
    }
}
