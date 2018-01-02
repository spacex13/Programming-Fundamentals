using System;
using System.Linq;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input[i] = 2 * input[i];
                    input.Remove(input[i + 1]);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
