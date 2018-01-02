using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace _2.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string[] text = Console.ReadLine().Split(new [] {'!', '.', '?'}, StringSplitOptions.RemoveEmptyEntries);
            //string regex = $@"\b([\w][\w\s-,:;]*\s{word}\s[\w\s-,:;]*)(?:[?.!])";

            foreach (var sentence in text)
            {
                string[] words = Regex.Split(sentence, "[^A-Za-z]");
                if (words.Contains(word))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
