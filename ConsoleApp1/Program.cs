using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            var number = 0;
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    number++;
                }
            }
            Console.WriteLine(number);
            int[,] array = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            var temp = 0;
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    for (int k = j + 1; k < array.GetUpperBound(1) +1; k++)
                    {
                        if (array[i, j] > array[i, k])
                        {
                            temp = array[i, j];
                            array[i, j] = array[i, k];
                            array[i, k] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
