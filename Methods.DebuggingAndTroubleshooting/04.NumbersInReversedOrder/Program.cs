using System;
namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            int count = 0;

            while (num != (int)num)
            {
                num *= 10;
                count++;
            }

            bool getOut = true;
            int lastDigt = 0;
            if (count > 0)
            {
                while (num > 1)
                {
                    if (getOut)
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            lastDigt = (int) num % 10;
                            Console.Write(lastDigt);
                            num /= 10;
                            if (i == count)
                            {
                                Console.Write(".");
                                getOut = false;
                            }
                        }
                    }
                    lastDigt = (int)num % 10;
                    Console.Write(lastDigt);
                    num /= 10;
                }
            }
            else
            {
                while (num > 1)
                {
                    lastDigt = (int)num % 10;
                    Console.Write(lastDigt);
                    num /= 10;
                }
            }
            Console.WriteLine();
        }
    }
}
