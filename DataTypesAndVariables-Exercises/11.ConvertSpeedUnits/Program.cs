using System;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float totalSeconds = hours * 3600 + minutes * 60 + seconds;
            float metersPerSecond = distanceInMeters / totalSeconds;
            float kilometersPerHour = (float)(distanceInMeters * 0.001) / (totalSeconds / 3600);
            float miles = distanceInMeters / 1609f;
            float milesPerHour = miles / (totalSeconds / 3600f);

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
