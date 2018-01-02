using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace _2.MatchPhoneNumber
{
    class Program
    {
        static void Main()
        {
            string regex =  @"(\+359)\s2\s(\d{3})\s(\d{4})\b|(\+359)\-2\-(\d{3})\-(\d{4})\b";
            var phones = Console.ReadLine();
            var phoneMatches = Regex.Matches(phones, regex);

            var matchedPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(String.Join(", ", matchedPhones));
        }
    }
}
