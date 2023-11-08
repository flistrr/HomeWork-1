using System;

namespace Task1
{
    internal class Program
    {
        public class Evaluation
        {
            public static void Main(string[] args)
            {
                var leg = Console.ReadLine();
                int a;
                bool success = Int32.TryParse(leg, out a);
                if (success)
                {
                    double area = a * a;
                    double perimiter = a * 4;
                    Console.WriteLine("Area: {0}", area);
                    Console.WriteLine("Perimeter: {0}", perimiter);
                }
                else
                {
                    Console.WriteLine("Please, enter an integer value");
                }
            }
        }


    }
}