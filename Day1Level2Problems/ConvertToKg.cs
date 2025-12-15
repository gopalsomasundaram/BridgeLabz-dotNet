using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1Level2Problems
{
    class ConvertToKg
    {
        public static void calc()
        {
            double pounds = Convert.ToDouble(Console.ReadLine());
            double kilograms = pounds / 2.2;
            Console.WriteLine($"The weight of the person in pounds is {pounds} and in kg is {kilograms}");
        }
    }
}
