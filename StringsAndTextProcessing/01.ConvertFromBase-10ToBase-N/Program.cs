using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _01.ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main()
        {
            List<BigInteger> nums = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
            BigInteger numToConvert = nums[1];
            int baseN = (int)nums[0];
            BigInteger remainder;
            string str = "";

            if (baseN >= 2 && baseN <= 10)
            {
                while (numToConvert > 0)
                {
                    remainder = numToConvert % baseN; 
                    numToConvert /= baseN; 

                    str = remainder.ToString() + str;
                }

                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
