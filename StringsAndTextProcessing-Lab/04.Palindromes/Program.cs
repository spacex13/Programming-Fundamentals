using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.Palindromes
{
    class Program
    {
        static void Main()
        {
            string[] delimeters = { " ", ",", ".", "?", "!" };
            string[] input = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();

            foreach (var word in input)
            {
                char[] reverse = word.ToCharArray();
                Array.Reverse(reverse);
                string palindrome = new string(reverse);

                if (word.Equals(palindrome))
                {
                    if (!palindromes.Contains(word))
                    {
                        palindromes.Add(word);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
        }
    }
}
