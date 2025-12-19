using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleAppTest.Day4Level1Problems
{
    internal class Trigonometry
    {
        public double[] calculateTrigonometricFunctions(double angle)
        {
            double radians = angle * Math.PI / 180;
            double[] arr = new double[3];
            arr[0] = Math.Sin(radians);
            arr[1] = Math.Cos(radians);
            arr[2] = Math.Tan(radians);
            return arr;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the Angle (in degrees):");
            double angle = double.Parse(Console.ReadLine());
            var obj = new Trigonometry();
            double[] result = obj.calculateTrigonometricFunctions(angle);
            Console.WriteLine($"Sine of given angle {result[0]}");
            Console.WriteLine($"Cos of given angle {result[1]}");
            Console.WriteLine($"Tan of given angle {result[2]}");
        }
    }
}
