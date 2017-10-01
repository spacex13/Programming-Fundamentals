using System;
namespace _17.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= endIndex; i++)
            {
                char unicode = (char)i;
                Console.Write(unicode + " ");
            }
            Console.WriteLine();
        }
    }
}
