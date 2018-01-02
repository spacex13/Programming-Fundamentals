using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _7.QueryMess
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"([^=?&]+)\=([^=?&]+)";
            string spaces = @"((%20|\+)+)";

            while (input != "END")
            {
                Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

                Regex regex = new Regex(pattern);
                MatchCollection collection = regex.Matches(input);

                foreach (Match m in collection)
                {
                    string field = m.Groups[1].Value;
                    field = Regex.Replace(field, spaces, word => " ").Trim();
                    string value = m.Groups[2].Value;
                    value = Regex.Replace(value, spaces, word => " ").Trim();

                    if (!dict.ContainsKey(field))
                    {
                        List<string> values = new List<string>();
                        values.Add(value);
                        dict.Add(field, values);           
                    }
                    else
                    {
                        dict[field].Add(value);
                    }
                }

                foreach (var pair in dict)
                {
                    Console.Write("{0}=[{1}]", pair.Key, String.Join(", ", pair.Value));
                }
                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}
