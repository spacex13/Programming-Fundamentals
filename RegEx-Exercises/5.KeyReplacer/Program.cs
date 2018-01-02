using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _5.KeyReplacer
{
    class Program
    {
        static void Main()
        {
            string pattern = @"([\w]+)[\|\\\<]{1}.*[\|\\\<]{1}([\w]+)";

            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();

            Regex regex = new Regex(pattern);

            Match match = regex.Match(keyString);

            string start = match.Groups[1].Value;
            string end = match.Groups[2].Value;

            string pattern2 = $@"{start}(?!{end})(.*?){end}";

            Regex r = new Regex(pattern2);
            MatchCollection collection = r.Matches(textString);

            StringBuilder str = new StringBuilder();

            if (collection.Count == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                foreach (Match c in collection)
                {
                    var message = c.Groups[1];
                    str.Append(message);
                }

                Console.WriteLine(str);
            }        
        }
    }
}
