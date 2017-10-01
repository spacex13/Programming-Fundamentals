using System;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            if (Char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }
            else if (input == 'a' || input == 'o' || input == 'e' || input == 'i' || input == 'u' || input == 'y')
            {
                Console.WriteLine("vowel"); 
            }
            else
            {
                Console.WriteLine("other");
            }    
        }
    }
}
