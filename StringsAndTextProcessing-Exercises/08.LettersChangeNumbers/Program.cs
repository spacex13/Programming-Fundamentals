using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main()
        {

            string[] input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string text = input[i];
                string firstLletter = input[i].First().ToString();
                string lastLetter = input[i].Last().ToString();
                var num = new String(input[i].Skip(0).Take(input.Length - 3).Where(c => Char.IsDigit(c)).ToArray());

                Console.WriteLine(num);

            }


        }


        static void CheckLetterCase(string letter, int num)
        {
            if (letter == letter.ToLower())
            {
                int ch = Convert.ToInt32(letter) - 96;

            }
            else if (letter != letter.ToLower())
            {
                int ch = Convert.ToInt32(letter) - 64;

            }

        }
    }
}
