using System;
using System.Linq;
namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int start = arr[0];
            int len = 1;
            int bestStart = arr[0];
            int bestLen = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    len++;
                }
                else
                {
                    start = arr[i];
                    len = 1;
                }

                if (len > bestLen)
                {
                    bestStart = start;
                    bestLen = len;
                }
            }

            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(bestStart + " ");
            }
            Console.WriteLine();
        }
    }
}
