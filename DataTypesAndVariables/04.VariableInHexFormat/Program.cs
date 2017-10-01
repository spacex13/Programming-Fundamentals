using System;
namespace _04.VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalNumber = Console.ReadLine();
            var decimalNumber = Convert.ToInt32(hexadecimalNumber, 16);
            Console.WriteLine(decimalNumber);
        }
    }
}
