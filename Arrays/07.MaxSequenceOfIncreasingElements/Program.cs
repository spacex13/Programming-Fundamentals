using System;
using System.Linq;
namespace _07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestStart = start;
                        bestLen = len;
                    }
                }
                else
                {
                    start = i;
                    len = 1;
                }
            }

            for (int i = bestStart; i < bestLen + bestStart; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
