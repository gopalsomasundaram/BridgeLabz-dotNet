using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level1Problems
{
    internal class AtheleteRuns
    {
        double rounds(int a, int b, int c)
        {
            double perimeter = a + b + c;
            return (5 /perimeter);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the 3 sides of the triagle");
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());
            int side3 = int.Parse(Console.ReadLine());
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            var obj = new AtheleteRuns();
            double result = obj.rounds(side1, side2, side3);
            Console.WriteLine($"The Athelete needs to run {result:f} rounds");
        }
    }
}
