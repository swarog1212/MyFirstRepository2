using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 4.3.14
            int[][] array = new int[3][];
            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };
            foreach (var item in array)
            {
                foreach (var itemArray in item)
                {
                    Console.Write(itemArray + " ");
                }
            }
            // Задание 4.3.15
            int[] arr = new int[] { 5, -6, 3, 89, -34, -46, 8, -87, 45 };
            int numbers = 0;
            Console.WriteLine("Массив из 8-и элементов:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    numbers++;
                }
            }
            Console.WriteLine("Количество положительных чисел = " + numbers);
        }
    }
}
