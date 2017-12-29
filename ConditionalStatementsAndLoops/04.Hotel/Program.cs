﻿using System;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50 * nightsCount;
                doublePrice = 65 * nightsCount;
                suitePrice = 75 * nightsCount;

                if (nightsCount > 7)
                {
                    studioPrice = studioPrice - 5 * studioPrice / 100;
                    if (month == "October")
                        studioPrice = studioPrice - studioPrice / nightsCount;
                }

            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60 * nightsCount;
                doublePrice = 72 * nightsCount;
                suitePrice = 82 * nightsCount;

                if (nightsCount > 14)
                    doublePrice = doublePrice - 10 * doublePrice / 100;

                if (month == "September" && nightsCount > 7)
                {
                    studioPrice = studioPrice - studioPrice / nightsCount;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68 * nightsCount;
                doublePrice = 77 * nightsCount;
                suitePrice = 89 * nightsCount;

                if (nightsCount > 14)
                    suitePrice = suitePrice - 15 * suitePrice / 100;
            }

            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {doublePrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");
        }
    }
}
