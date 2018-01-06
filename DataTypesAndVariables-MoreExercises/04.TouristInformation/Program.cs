using System;
namespace _04.TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double valueToConvert = double.Parse(Console.ReadLine());
            string metricValue = String.Empty;
            double convertedValue = 0;

            if (imperialUnit == "miles")
            {
                metricValue = "kilometers";
                convertedValue = valueToConvert * 1.6;
            }
            else if (imperialUnit == "inches")
            {
                metricValue = "centimeters";
                convertedValue = valueToConvert * 2.54;
            }
            else if (imperialUnit == "feet")
            {
                metricValue = "centimeters";
                convertedValue = valueToConvert * 30;
            }
            else if (imperialUnit == "yards")
            {
                metricValue = "meters";
                convertedValue = valueToConvert * 0.91;
            }
            else if (imperialUnit == "gallons")
            {
                metricValue = "liters";
                convertedValue = valueToConvert * 3.8;
            }
            Console.WriteLine($"{valueToConvert} {imperialUnit} = {convertedValue:F2} {metricValue}");
        }
    }
}
