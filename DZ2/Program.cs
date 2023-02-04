using System;
using System.Globalization;

namespace DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива n*n: ");
            int size = int.Parse(Console.ReadLine());
            int[,] numbers = new int[size, size];
            int counter = 0;
            Console.WriteLine("Заполните массив: ");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = int.Parse(Console.ReadLine());
                    if (numbers[i, j] < 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write($"{numbers[i, j]} \t");
                }
                Console.WriteLine();
            }
            if (counter > 0)
            {
                Console.WriteLine("Количество отрицательных элементов: " + counter);
                Console.WriteLine("Массив из отрицательных элементов: ");
                int[] otriz = new int[counter];
                int ind = 0;
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                        if (numbers[i, j] < 0)
                        {
                            otriz[ind] = numbers[i, j];
                            ind++;
                        }
                    }
                }
                for (int i = 0; i < otriz.Length; i++)
                {
                    Console.WriteLine(otriz[i]);
                }
            }
            else Console.WriteLine("Отрицательных элементов нет");

        }

    }
}
