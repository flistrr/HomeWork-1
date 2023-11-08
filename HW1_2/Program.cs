using System;

namespace HW1_2
{
    public class Evaluation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you, {0}?", name);
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Hello {name}, you are {age} years old :)");
        }
    }
}
