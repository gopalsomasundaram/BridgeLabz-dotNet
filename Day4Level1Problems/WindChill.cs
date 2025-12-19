using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level1Problems
{
    internal class WindChill
    {
        public double CalculateWindChill(double temperature, double windSpeed)
        {
            double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
            return windChill;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the temperature:");
            double temp = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the windSpeed:");
            double windSpeed = double.Parse(Console.ReadLine());
            var obj = new WindChill();
            Console.WriteLine($"The wind chill is {obj.CalculateWindChill(temp, windSpeed):f}");
        }
    }
}
