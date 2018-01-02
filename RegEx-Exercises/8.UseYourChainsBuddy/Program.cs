using System;
using System.Text;
using System.Text.RegularExpressions;
namespace _8.UseYourChainsBuddy
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(<p>(.*?)<\/p>)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            StringBuilder str = new StringBuilder();

            foreach (Match m in matches)
            {
                string text = m.Groups[2].Value;
                text = Regex.Replace(text, "[^a-z0-9]+", " ");
                text = Regex.Replace(text, @"\ +", " ");

                for (int i = 0; i < text.Length; i++)
                {
                    StringBuilder sb = new StringBuilder(text);

                    if (Char.IsLetter(text[i]))
                    {
                        if (text[i] + 13 <= 122)
                        {
                            sb[i] = (char) (text[i] + 13);
                        }
                        else
                        {
                            sb[i] = (char) (text[i] - 13);
                        }

                        text = sb.ToString();
                    }
                }

                str.Append(text);
            }

            Console.WriteLine(str);
        }    
    }
}
