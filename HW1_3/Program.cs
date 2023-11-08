using System;

namespace HW1_3
{
    public class CircleCalculating
    {
        public const double PI = 3.14;
        public static void Main(string[] args)
        {
            var q = Console.ReadLine();
            double r;
            bool success = Double.TryParse(q, out r);
            double pi = PI;
            if (success)
            {
                double l = pi * r * 2;
                double a = pi * r * r;
                double v = 4 / 3 * pi * r * r * r;
                Console.WriteLine("length: {0}", Math.Round(l, 2));
                Console.WriteLine("area: {0}", Math.Round(a, 2));
                Console.WriteLine("volume: {0}", Math.Round(v, 2));
            }
            else
            {
                Console.WriteLine("Please, enter a double value");
            }
        }
    }
}
