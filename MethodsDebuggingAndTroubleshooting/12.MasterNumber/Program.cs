﻿using System;
namespace _12.MasterNumber
{
    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPalindrome(int num)
        {
            string number = num.ToString();
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] == number[number.Length - 1 - i])
                    continue;
                else
                    return false;
            }
            return true;
        }

        public static bool SumOfDigits(int num)
        {
            int sum = 0;
            string number = num.ToString();
            for (int i = 1; i <= number.Length; i++)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 7 == 0)
                return true;

            return false;
        }

        public static bool ContainsEvenDigit(int num)
        {
            string number = num.ToString();
            for (int i = 0; i < number.Length; i++)
            {
                int digit = int.Parse(number[i].ToString());
                if (digit % 2 == 0)
                    return true;
            }
            return false;
        }
    }
}
