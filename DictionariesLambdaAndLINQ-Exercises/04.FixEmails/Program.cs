using System;
using System.Collections.Generic;
namespace _04.FixEmails
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            int line = 1;
            string name = "";
            string email = "";
            var emails = new Dictionary<string, string>();

            while (input != "stop")
            {
                if (line % 2 != 0)
                {
                    name = input;
                }
                else
                {
                    email = input;
                    emails[name] = email;
                    if (emails[name].EndsWith("us") || emails[name].EndsWith("uk"))
                    {
                        emails.Remove(name);
                    }
                }

                line++;
                input = Console.ReadLine();
            }

            foreach (var person in emails)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
