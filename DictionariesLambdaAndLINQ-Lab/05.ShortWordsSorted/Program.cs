using System;
using System.Linq;
namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main()
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " ", "(", ")", "\"", "'", "/", "\\"};
            var text = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            text = text.Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToList();

            Console.WriteLine(String.Join(", ", text));
        }
    }
}
