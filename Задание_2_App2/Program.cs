using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_App2
{
    class Program
    {
        //Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. Определить сумму максимального и минимального элементов массива.
        static void Main(string[] args)
        {
            // n - количество элементов массива; a - начальный диапазон рандомных чисел, b - конечный диапазон.
            int n = 15;
            int a = 0;
            int b = 50;
            // Sum - сумма последовательности чисел, Max, Min, Sum - сумма максимального и минимального значения.
            int Sum = 0;
            int Max = a;
            int Min = b;
            Random X = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = X.Next(a, b);
                Console.Write("{0} ", array[i]);
                if (array[i] > Max)
                {
                    Max = array[i];
                }
                if (array[i] < Min)
                {
                    Min = array[i];
                }
            }
            Sum = Max + Min;
            Console.WriteLine();
            Console.WriteLine("Максимальное значение элементов массива: Max = {0}", Max);
            Console.WriteLine("Минимальное значение элементов массива: Min = {0}", Min);
            Console.WriteLine("Сумма максимального и минимального элементов массива равна: Sum = {0}", Sum);
            Console.WriteLine("Для завершения нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
