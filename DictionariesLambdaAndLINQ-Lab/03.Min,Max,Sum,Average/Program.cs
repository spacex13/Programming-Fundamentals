using System;
using System.Linq;
namespace _03.Min_Max_Sum_Average
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}", array.Sum());
            Console.WriteLine("Min = {0}", array.Min());
            Console.WriteLine("Max = {0}", array.Max());
            Console.WriteLine("Average = {0}", array.Average());
        }
    }
}
