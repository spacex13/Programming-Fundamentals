using System;
using System.Linq;
namespace _05.MagicExchangeableWords
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var word1 = input[0].ToCharArray().Distinct().ToArray();
            var word2 = input[1].ToCharArray().Distinct().ToArray();

            if (word1.Length == word2.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
