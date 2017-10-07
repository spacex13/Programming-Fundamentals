using System;
namespace _01.Hello_Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            GetGreeting(name);
        }

        static void GetGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
