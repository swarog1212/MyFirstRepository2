using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myName = Console.ReadLine();

            /*foreach (var i in myName)
            {
                Console.Write("{0} ", i);
               
            }
            Console.WriteLine("Последняя буква вашего имени = {0}", myName[myName.Length - 1]);*/
            //for (int i = myName.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(myName[i]);
            //}
            /*int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };
            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                {
                    Console.Write(array[k, i] + " ");
                }
                Console.WriteLine();
            }*/
            /*var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length - 1; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        temp = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();*/
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
            sum = 0;
            
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
