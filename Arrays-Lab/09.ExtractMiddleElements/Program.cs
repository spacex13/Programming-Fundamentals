using System;
using System.Linq;

namespace _09.ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (arr.Length == 1)
            {
                Console.Write(arr[0]);
            }
            else if (arr.Length % 2 == 0)
            {
                int first = arr[arr.Length/2 - 1];
                int second = arr[arr.Length / 2];
                Console.Write("{0}, {1}", first, second);
            }
            else
            {
                int first = arr[arr.Length / 2 - 1];
                int second = arr[arr.Length / 2];
                int third = arr[arr.Length / 2 + 1];
                Console.Write("{0}, {1}, {2}", first, second, third);
            }
        }
    }
}
