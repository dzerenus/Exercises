using System;

namespace Z07_264
{
    class Program
    {
        static void Main(string[] args)
        {
            // Входные данные.
            Console.WriteLine("Введите строку: ");
            string a = Console.ReadLine();

            // Переменные для открывающих и закрывающих скобок.
            int numOpen = 999;
            int numClos = 999;

            while (true)
            {   
                // Анализ на наличие скобок.
                for (int i = 0; i < a.Length; i++)
                {
                   // Поиск открывающих скобок.
                    if (a[i] == '(') numOpen = i;
    
                    if (a[i] == ')' && numOpen != 999)
                    {
                        numClos = i; 
                        break;
                    }
                }

                // Удаление текста.
                if (numClos != 999) 
                {
                    a = a.Remove(numOpen, numClos-numOpen+1);
                    numOpen = 999;
                    numClos = 999;
                }
                
                else break;
            }

            Console.WriteLine("Result: " + a);
        }
    }
}
