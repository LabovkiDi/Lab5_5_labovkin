using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_5_labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество N строк = количеству столбцов массива");
            //чтобы получить двумерный массив заданного вида нажмите 5 
                       int N = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[N, N];


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = 1 - (i + j) % 2; /*остается либо 0, либо 1*/
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
