using System;
namespace _18.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            bool canFit = false;
            string typesThatFit = String.Empty;

            if (sbyte.TryParse(num, out sbyte sbyteNum))
            {
                typesThatFit += "* sbyte" + Environment.NewLine;
                canFit = true;
            }
            if (byte.TryParse(num, out byte byteNum))
            {
                typesThatFit += "* byte" + Environment.NewLine;
                canFit = true;
            }
            if (short.TryParse(num, out short shortNum))
            {
                typesThatFit += "* short" + Environment.NewLine;
                canFit = true;
            }
            if (ushort.TryParse(num, out ushort ushortNum))
            {
                typesThatFit += "* ushort" + Environment.NewLine;
                canFit = true;
            }
            if (int.TryParse(num, out int intNum))
            {
                typesThatFit += "* int" + Environment.NewLine;
                canFit = true;
            }
            if (uint.TryParse(num, out uint uintNum))
            {
                typesThatFit += "* uint" + Environment.NewLine;
                canFit = true;
            }
            if (long.TryParse(num, out long longNum))
            {
                typesThatFit += "* long";
                canFit = true;
            }

            if (canFit)
            {
                Console.WriteLine($"{num} can fit in:");
                Console.WriteLine(typesThatFit);
            }
            else
            {
                Console.WriteLine($"{num} can't fit in any type");
            }
        }
    }
}
