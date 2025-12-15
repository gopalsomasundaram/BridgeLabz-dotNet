using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1Level2Problems
{
    class DoubleOpt
    {
        public static void calculate()
        {
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double c = Convert.ToInt32(Console.ReadLine());
            double result1 = a + b * c;
            double result2 = a * b + c;
            double result3 = c + a / b;
            double result4 = a % b + c;
            Console.WriteLine($"The result of double operations are {result1}, {result2}, {result3} and {result4}");
        }
    }
}
