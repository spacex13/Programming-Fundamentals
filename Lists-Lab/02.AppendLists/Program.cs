using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.AppendLists
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            string[] tokens = input.Split('|').ToArray();

            List<int> result = new List<int>();

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                int[] elements = tokens[i]
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                result.AddRange(elements);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
