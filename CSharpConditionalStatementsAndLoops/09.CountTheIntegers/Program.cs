using System;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            try
            {
                while (true)
                {
                    int num = int.Parse(Console.ReadLine());
                    count++;
                }
            }
            catch
            {
                Console.WriteLine(count);
            }
        }
    }
}
