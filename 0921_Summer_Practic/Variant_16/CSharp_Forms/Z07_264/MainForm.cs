using System;
using System.Windows.Forms;

namespace Z07_264
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void btnWork_Click(object sender, EventArgs e)
        {   
            // Строки под ввод и результат.
            string input = rtbInput.Text;

            while (true)
            {   
                // Получаем индекса открывающих-закрывающих скобок.
                (int open, int close) indexes = FindOpenClose(input);

                // Если индекс закрывающейся не передан, выходим.
                if (indexes.close == -1) break;

                // Создаём новую строку по полученным индексам.
                else
                    input = input.Remove(indexes.open, indexes.close - indexes.open + 1);
            }

            rtbResult.Text = input;
        }

        /// <summary>
        /// Поиск индексов открытой-закрытой скобки в строке.
        /// </summary>
        /// <param name="input">Входная строка, в которой ищем.</param>
        /// <returns>Возвращает кортеж из двух индексов.</returns>
        private (int, int) FindOpenClose(string input)
        {   
            // Заготовка переменных.
            int open = -1;
            int close = -1;

            // Ищем открытие-закрытие.
            for (int i = 0; i < input.Length; i++)
            {
                if (open == -1 && input[i] == '(') open = i;
                if (open != -1 && input[i] == ')') close = i;
            }

            // Возвращаем индексы.
            return (open, close);
        }
    }
}
