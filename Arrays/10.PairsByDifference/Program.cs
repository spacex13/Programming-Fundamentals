using System;
using System.Linq;

namespace _10.PairsByDifference
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int pairs = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) == diff)
                    {
                        pairs++;
                    }
                }
            }
            Console.WriteLine(pairs);
        }
    }
}
