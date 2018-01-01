using System;
namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());  //totalPicsTaken
            double ft = double.Parse(Console.ReadLine());  //filterTimePerPic
            double ff = double.Parse(Console.ReadLine());  //filterFactorPercentage
            double ut = double.Parse(Console.ReadLine());  //uploadTimeForFilteredAPic

            double usefulPics = Math.Ceiling(n * ff / 100);
            double timeForFiltering = n * ft;
            double timeForUpload = usefulPics * ut;
            double totalTime = timeForFiltering + timeForUpload;

            long days = (long)totalTime / 86400;
            long hours = (long)(totalTime - days * 86400) / 3600;
            long minutes = (long)(totalTime - days * 86400 - hours * 3600) / 60;
            long seconds = (long)totalTime - days * 86400 - hours * 3600 - minutes * 60;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
