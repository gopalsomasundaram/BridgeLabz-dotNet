using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1Level2Problems
{
    class TemperatureConversion
    {
        public static void ctof()
        {
            double celsius = Convert.ToDouble(Console.ReadLine());
            double farenheit = ((celsius * 9 / 5)+32);
            Console.WriteLine($"{celsius:f} celsius is {farenheit:f} farenheit");
        }
        public static void ftoc()
        {
            double farenheit = Convert.ToDouble(Console.ReadLine());
            double  celsius = ((farenheit-32)*5/9);
            Console.WriteLine($"{celsius:f} celsius is {farenheit:f} farenheit");
        }
    }
}
