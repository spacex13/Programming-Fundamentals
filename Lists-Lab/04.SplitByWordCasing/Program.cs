using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main()
        {
            string[] separators = { ",", ";", ":", ".", "!", "(", ")", "\"", "'", "\\", "/", "[", "]", " " };
            var text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                int countLower = 0;
                int countUpper = 0;
                var word = text[i].ToCharArray();

                for (int j = 0; j < word.Length; j++)
                {
                    if (Char.IsUpper(word[j]))
                    {
                        countUpper++;
                    }
                    else if (Char.IsLower(word[j]))
                    {
                        countLower++;
                    }
                }

                if (word.Length == countLower)
                {
                    lowerCase.Add(text[i]);
                }
                else if (word.Length == countUpper)
                {
                    upperCase.Add(text[i]);
                }
                else
                {
                    mixedCase.Add(text[i]);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
