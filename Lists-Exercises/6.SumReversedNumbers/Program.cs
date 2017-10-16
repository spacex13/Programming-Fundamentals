using System;
using System.Collections.Generic;
using System.Linq;
namespace _6.SumReversedNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                int rev = 0;
                while (sequence[i] > 0)
                {
                    int r = sequence[i] % 10;
                    rev = rev * 10 + r;
                    sequence[i] /= 10;
                }
                sum += rev;
            }

            Console.WriteLine(sum);
        }
    }
}
