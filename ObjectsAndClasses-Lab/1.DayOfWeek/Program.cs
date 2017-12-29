using System;
using System.Globalization;
namespace _1.DayOfWeek
{
    class Program
    {
        static void Main()
        {
            string dateString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateString, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
