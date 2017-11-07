using System;
using System.Text;
namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder str = new StringBuilder();

            foreach (var ch in input)
            {
                int unicode = ch;
                str.Append(String.Format("\\u{0:x4}", unicode));

                //this also works:
                //str.Append("\\u" + ((int)ch).ToString("x4"));
            }

            Console.WriteLine(str);
        }
    }
}
