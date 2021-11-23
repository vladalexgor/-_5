using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_App3
{
    class Program
    {
        //Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
        static void Main(string[] args)
        {
            // n - количество элементов массива; a - начальный диапазон рандомных чисел, b - конечный диапазон.
            const int n = 10;
            const int n1 = n / 2;
            const int n2 = n;
            const int a = -50;
            const int b = 50;
            Random X = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = X.Next(a, b);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < (n1 - 1); i++)
            {
                for (int j = i + 1; j < n1; j++)
                {
                    if (array[i] > array[j])
                    {
                        int N = array[i];
                        array[i] = array[j];
                        array[j] = N;
                    }
                }
            }
            for (int i = n1; i < (n2-1); i++)
            {
                for (int j = i + 1; j < n2; j++)
                {
                    if (array[i] < array[j])
                    {
                        int N = array[i];
                        array[i] = array[j];
                        array[j] = N;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
