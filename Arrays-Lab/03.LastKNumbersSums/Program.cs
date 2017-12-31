using System;
namespace _03.LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] seq = new long[n];
            seq[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                int startIndex = Math.Max(0, i - k);
                for (int j = startIndex; j < i; j++)
                {
                    sum += seq[j];
                }
                seq[i] = sum;
            }

            Console.WriteLine(String.Join(" ", seq));
        }

    }
}
