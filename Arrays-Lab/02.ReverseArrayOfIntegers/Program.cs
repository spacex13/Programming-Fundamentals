using System;
using System.Linq;

namespace _02.ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            int[] arr = new int[numbers]; 
            for (int i = 0; i < numbers; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] reversed = new int[numbers];
            for (int i = 0; i < numbers; i++)
            {
                reversed[i] = arr[numbers - 1 - i];
            }

            Console.WriteLine(String.Join(" ", reversed));
        }
    }
}
