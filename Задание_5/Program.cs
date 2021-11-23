using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    //Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательно 7 чисел:");
            int n = 7;
            double a = 0;
            double Sum = 0;
            double SA = 0;
            int[] array = new int [n];
            for (int i = 0; i < n; i++)
            {
                a = Convert.ToDouble(Console.ReadLine()); 
                Sum = Sum + a;
            }
            SA = Sum / n;
            Console.WriteLine("Среднее арифметическое введенных чисел: Sср = {0,2}", SA);
            Console.WriteLine("Для завершения нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
