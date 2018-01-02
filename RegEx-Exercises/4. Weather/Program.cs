using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4.Weather
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, KeyValuePair<float, string>> res = new Dictionary<string, KeyValuePair<float, string>>();

            while (input != "end")
            {
                string pattern = @"([A-Z]{2})([0-9]+\.[0-9]+)([A-Za-z]+)\|";

                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string city = match.Groups[1].Value;
                    float t = float.Parse(match.Groups[2].Value);
                    string weather = match.Groups[3].Value;

                    if (!res.ContainsKey(city))
                    {
                        res.Add(city, new KeyValuePair<float, string>(t, weather));
                    }
                    else
                    {
                        res.Remove(city);
                        res.Add(city, new KeyValuePair<float, string>(t, weather));
                    }
                }
                input = Console.ReadLine();
            }

            var ordered = res.OrderBy(c => c.Value.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var city in ordered)
            {
                Console.WriteLine($"{city.Key} => {city.Value.Key:F2} => {city.Value.Value}");
            }
        }
    }
}
