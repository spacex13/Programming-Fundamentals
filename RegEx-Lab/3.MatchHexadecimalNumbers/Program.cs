using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace _3.MatchHexadecimalNumbers
{
    class Program
    {
        static void Main()
        {
            string regex = @"\b(?:0x)?([0-9A-F]+)\b";
            var numbers = Console.ReadLine();
            var matchedNumbers = Regex.Matches(numbers, regex).Cast<Match>().Select(x => x.Value.Trim()).ToArray();
 
            Console.WriteLine(String.Join(" ", matchedNumbers));
        }
    }
}
