using System;
using System.Text;
namespace _06.SumBigNumbers
{
    class Program
    {
        static void Main()
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            StringBuilder sum = new StringBuilder();

            num1 = num1.TrimStart(new char[] { '0' });
            num2 = num2.TrimStart(new char[] { '0' });

            if (num1.Length > num2.Length)
            {
                int diff = num1.Length - num2.Length;
                var addZeros = new string('0', diff);
                num2 = num2.Insert(0, addZeros);
            }
            else if (num1.Length < num2.Length)
            {
                int diff = num2.Length - num1.Length;
                var addZeros = new string('0', diff);
                num1 = num1.Insert(0, addZeros);
            }

            char[] array1 = num1.ToCharArray();
            char[] array2 = num2.ToCharArray();

            int overflow = 0;
            for (int i = array1.Length - 1; i >= 0; i--)
            {
                int number1 = Convert.ToInt32(array1[i]) - 48;
                int number2 = Convert.ToInt32(array2[i]) - 48;
                int lastSum = number1 + number2 + overflow;

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

            for (int i = 0; i < sum.Length / 2; i++)
            {
                char old = sum[i];
                sum[i] = sum[sum.Length - 1 - i];
                sum[sum.Length - 1 - i] = old;
            }

            Console.WriteLine(sum);
        }
    }
}
