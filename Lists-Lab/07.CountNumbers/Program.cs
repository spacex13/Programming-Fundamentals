using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.CountNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbers.Sort();

            int count = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }

                if (numbers[i] != numbers[i + 1] || i == numbers.Count - 2)
                {
                    Console.WriteLine("{0} -> {1}", numbers[i], count);
                    count = 1;
                }
            }
        }
    }
}
