using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_App5
{
    class Program
    {
        //Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:
        //1 0 1 0 1
        //0 1 0 1 0
        //1 0 1 0 1
        //0 1 0 1 0
        //1 0 1 0 1
        static void Main(string[] args)
        {
            // N - целое число (сторона массива), вводимая пользователем.
            Console.Write("Введите целочисленное число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[N,N];
            for (int i = 0; i < N; i++)
            {
                if ((i % 2) == 0)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if ((j % 2) == 0)
                        {
                            A[i, j] = 1;
                            Console.Write("{0} ", A[i, j]);
                        }
                        else
                        {
                            A[i, j] = 0;
                            Console.Write("{0} ", A[i, j]);
                        }
                    }
                }
                else if ((i % 2) > 0)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if ((j % 2) == 0)
                        {
                            A[i, j] = 0;
                            Console.Write("{0} ", A[i, j]);
                        }
                        else
                        {
                            A[i, j] = 1;
                            Console.Write("{0} ", A[i, j]);
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Для завершения нажмите любую клавишу.");
            
            Console.ReadKey();
        }                     
    }
}
