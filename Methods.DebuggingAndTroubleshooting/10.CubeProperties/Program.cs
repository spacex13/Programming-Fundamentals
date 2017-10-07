using System;
namespace _10.CubeProperties
{
    public class Program
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            Console.WriteLine("{0:F2}", GetParameterNumber(side, parameter));
        }

        public static double GetParameterNumber(double side, string parameter)
        {
            if (parameter == "face")
            {
                double face = Math.Sqrt(2 * side * side);
                return face;
            }
            if (parameter == "space")
            {
                double space = Math.Sqrt(3 * side * side);
                return space;
            }
            if (parameter == "volume")
            {
                double volume = side * side * side;
                return volume;
            }
            double area = 6 * side * side;
            return area;
        }
    }
}
