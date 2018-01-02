using System;
using System.Text.RegularExpressions;
namespace _5.MatchNumbers
{
    class Program
    {
        static void Main()
        {
            string regex = @"(^|(?<=\s))(\-)?([0-9]+)(\.?[0-9]*)($|(?=\s))";
            var inputNums = Console.ReadLine();
            var numbers = Regex.Matches(inputNums, regex);

            foreach (Match num in numbers)
            {
                Console.Write(num.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
