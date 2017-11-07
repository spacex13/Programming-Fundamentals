using System;
namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            string word1 = input[0];
            string word2 = input[1];

            SumOfChars(word1, word2);
        }

        static void SumOfChars(string word1, string word2)
        {
            char[] words1 = word1.ToCharArray();
            char[] words2 = word2.ToCharArray();
            int sum = 0;

            if (words1.Length == words2.Length)
            {
                for (int i = 0; i < words2.Length; i++)
                {
                    sum += words1[i] * words2[i];
                }
            }
            else
            {
                if (words1.Length > words2.Length)
                {
                    for (int i = 0; i < words2.Length; i++)
                    {
                        sum += words1[i] * words2[i];
                    }
                    for (int i = words2.Length; i < words1.Length; i++)
                    {
                        sum += words1[i];
                    }
                }
                else if (words1.Length < words2.Length)
                {
                    for (int i = 0; i < words1.Length; i++)
                    {
                        sum += words1[i] * words2[i];
                    }
                    for (int i = words1.Length; i < words2.Length; i++)
                    {
                        sum += words2[i];
                    }
                }
            }

            Console.WriteLine(sum);
        }

    }
}
