using System;
using System.Runtime.ExceptionServices;
using System.Text;
namespace _07.MultiplyBigNumber
{
    class Program
    {
        static void Main()
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            StringBuilder sum = new StringBuilder();
            num1 = num1.TrimStart(new char[] { '0' });

            char[] array1 = num1.ToCharArray();
            char[] array2 = num2.ToCharArray();
            int number2 = Convert.ToInt32(array2[0]) - 48;

            int overflow = 0;
            for (int i = array1.Length - 1; i >= 0; i--)
            {
                int number1 = Convert.ToInt32(array1[i]) - 48;
                int lastSum = number1 * number2 + overflow;

                if (lastSum >= 10)
                {
                    overflow = lastSum / 10;
                    lastSum = lastSum % 10;
                }
                else
                {
                    overflow = 0;
                }
                sum.Append(lastSum);
            }

            if (overflow != 0)
            {
                sum.Append(overflow);
            }

            if (num2 == "0")
            {
                Console.WriteLine("0");
            }
            else
            {
                char[] result = sum.ToString().ToCharArray();
                Array.Reverse(result);
                Console.WriteLine(new string(result));
            }
        }
    }
}
