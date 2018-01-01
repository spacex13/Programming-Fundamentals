using System;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";

            object combineWords  = word1 + " " + word2;
            string text = (string)combineWords;
            Console.WriteLine(text);
        }
    }
}
