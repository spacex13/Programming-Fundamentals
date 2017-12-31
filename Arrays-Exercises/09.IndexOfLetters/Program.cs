using System;
namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = new char[26];

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(i + 97);
            }

            var word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j <= 26; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.WriteLine(word[i] + " -> " + j);
                        break;
                    }
                }
            }
        }
    }
}
