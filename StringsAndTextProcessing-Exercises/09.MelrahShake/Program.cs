using System;
namespace _09.MelrahShake
{
    class Program
    {
        static void Main()
        {
            string characters = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                int indexFirst = characters.IndexOf(pattern);
                int indexLast = characters.LastIndexOf(pattern);

                if (indexFirst >= 0 && indexLast >= 0 || indexFirst != indexLast)
                {
                    characters = characters.Remove(indexLast, pattern.Length);
                    characters = characters.Remove(indexFirst, pattern.Length);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    break;
                }

                pattern = pattern.Remove(pattern.Length / 2, 1);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(characters);
        }
    }
}
