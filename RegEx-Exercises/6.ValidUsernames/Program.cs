using System;
using System.Text.RegularExpressions;

namespace _6.ValidUsernames
{
    class Program
    {
        static void Main()
        {
            string pattern = @"\b([a-zA-Z][\w]{2,24})\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            int maxSum = 0;
            string str1 = "";
            string str2 = "";

            for (int i = 1; i < matches.Count; i++)
            {
                string m1 = matches[i - 1].Groups[1].Value;
                string m2 = matches[i].Groups[1].Value;

                int sum1 = m1.Length;
                int sum2 = m2.Length;

                int currSum = sum1 + sum2;
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    str1 = m1;
                    str2 = m2;
                }            
            }

            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
