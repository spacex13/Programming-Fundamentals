using System;
using System.Text.RegularExpressions;
namespace _1.ExtractEmails
{
    class Program
    {
        static void Main()
        {
            string regex = @"(?<=\s|\^)([A-Za-z0-9]+[\w.-]*[A-Za-z0-9]+)@([a-z]+[a-z-.]+\.[a-z]+)\b";
            string input = Console.ReadLine();
            var emails = Regex.Matches(input, regex);

            foreach (Match email in emails)
            {
                Console.WriteLine(email.Value.Trim());
            }
        }
    }
}
