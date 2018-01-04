using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace _3.AnonymousVox
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var placeholder = Console.ReadLine()
                .Split(new string[] {"{", "}"}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var regex = @"([A-Za-z]+)(.+)\1";
            MatchCollection matches = Regex.Matches(text, regex);

            int i = 0;
            foreach (Match m in matches)
            {
                if (i < placeholder.Length && i < matches.Count)
                {
                    string gr = m.Groups[2].Value;
                    string replacer = placeholder[i];

                    text = ReplaceFirst(text, gr, replacer);
                    //text = Regex.Replace(text, gr, replacer);
                }
                i++;
            }

            Console.WriteLine(text);      
        }

        static string ReplaceFirst(string text, string oldValue, string newValue)
        {
            string oldValueSub = text.Substring(0, text.IndexOf(oldValue) + oldValue.Length);
            string newValueSub = oldValueSub.Replace(oldValue, newValue);

            return newValueSub + text.Substring(oldValueSub.Length);
        }
    }
}
