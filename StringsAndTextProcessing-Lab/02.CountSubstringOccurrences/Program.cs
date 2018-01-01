using System;
namespace _02.CountSubstringOccurrences
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string substring = Console.ReadLine().ToLower();
            int count = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (i + substring.Length > input.Length)
                {
                    break;
                }
                string phrase = input.Substring(i, substring.Length);
                if (phrase == substring)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
