using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level2Problems
{
    internal class BMI
    {
        public static void calculate()
        {
            Console.WriteLine("Enter the weight in Kgs:");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height in Cm:");
            double height = double.Parse(Console.ReadLine());
            height /= 100;
            double bmi = weight / Math.Pow(height, 2);
            if (bmi <= 18.4) Console.WriteLine("Underweight");
            else if (bmi >= 18.5 && bmi <= 24.9) Console.WriteLine("Normal");
            else if (bmi >= 25.0 && bmi <= 39.9) Console.WriteLine("Overweight");
            else { Console.WriteLine("Obses"); }
        }
    }
}
