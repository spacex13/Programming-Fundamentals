using System;
namespace _03.EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigitName(num));
        }

        static string GetLastDigitName(long num)
        {
            long lastDigit = Math.Abs(num % 10);
            string name = String.Empty;

            switch (lastDigit)
            {
                case 1: name = "one"; break;
                case 2: name = "two"; break;
                case 3: name = "three"; break;
                case 4: name = "four"; break;
                case 5: name = "five"; break;
                case 6: name = "six"; break;
                case 7: name = "seven"; break;
                case 8: name = "eight"; break;
                case 9: name = "nine"; break;
                case 0: name = "zero"; break;
            }
            return name;
        }
    }
}
