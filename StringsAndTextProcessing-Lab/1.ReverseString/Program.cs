using System;
using System.Linq;
namespace _1.ReverseString
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var reversed = input.Reverse();

            foreach (var ch in reversed)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
        }
    }
}
