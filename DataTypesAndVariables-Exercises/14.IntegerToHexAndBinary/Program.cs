using System;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexadecimalNumber = decimalNumber.ToString("X");
            string binaryNumber = Convert.ToString(decimalNumber, 2);

            Console.WriteLine(hexadecimalNumber);
            Console.WriteLine(binaryNumber);
        }
    }
}
