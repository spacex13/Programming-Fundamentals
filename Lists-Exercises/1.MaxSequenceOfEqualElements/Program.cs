using System;
using System.Collections.Generic;
using System.Linq;
namespace _1.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = 1;
            int start = integers[0];
            int maxStart = integers[0];
            int maxCount = 1;

            for (int i = 1; i < integers.Count; i++)
            {
                if (integers[i] == integers[i - 1])
                {
                    count++;
                    start = integers[i];
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxStart = start;
                    }
                }
                else
                {
                    count = 1;
                    start = integers[i];
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write("{0} ", maxStart);
            }
            Console.WriteLine();

        }
    }
}
