using System;

namespace _11._5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (b - a < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int num1 = a; num1 <= b; num1++)
                {
                    for (int num2 = a; num2 <= b; num2++)
                    {
                        for (int num3 = a; num3 <= b; num3++)
                        {
                            for (int num4 = a; num4 <= b; num4++)
                            {
                                for (int num5 = a; num5 <= b; num5++)
                                {
                                    if (num1 < num2 && num2 < num3 && num3 < num4 && num4 < num5)
                                    {
                                        Console.WriteLine($"{num1} {num2} {num3} {num4} {num5}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
