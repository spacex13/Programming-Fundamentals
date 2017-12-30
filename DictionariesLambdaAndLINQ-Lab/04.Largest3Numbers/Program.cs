using System;
using System.Linq;
namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            nums = nums.OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
