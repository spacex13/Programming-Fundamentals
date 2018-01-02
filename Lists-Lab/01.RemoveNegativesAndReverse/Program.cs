using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> positiveNums = new List<int>();

            foreach (var num in numbers)
            {
                if (num > 0)
                {
                    positiveNums.Add(num);
                }
            }
            positiveNums.Reverse();

            if (!positiveNums.Any())
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", positiveNums));
            }
        }
    }
}
