using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
