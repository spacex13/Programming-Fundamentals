using System;

namespace _14.MagicLetter_OtherSolution_
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            for (char i = letter1; i <= letter2; i++)
            {
                for (char p = letter1; p <= letter2; p++)
                {
                    for (char k = letter1; k <= letter2; k++)
                    {
                        if (i != letter3 && p != letter3 && k != letter3)
                        {
                            i = Convert.ToChar(i);
                            p = Convert.ToChar(p);
                            k = Convert.ToChar(k);
                            Console.Write(i + "" + p + "" + k + " ");
                        }
                    }
                }
            }
        }
    }
}
