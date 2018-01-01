using System;
using System.Linq;

namespace _03.TextFilter
{
    class Program
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();

            for (int j = 0; j < bannedWords.Length; j++)
            {
                if (text.Contains(bannedWords[j]))
                {
                    string replacement = new string('*', bannedWords[j].Length);
                    text = text.Replace(bannedWords[j], replacement);
                }
            }

            Console.WriteLine(text);
        }
    }
}
