using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1Level2Problems
{
    class SimpleInterest
    {
        public static void calc()
        {
            int principal = Convert.ToInt32(Console.ReadLine());
            double rate = Convert.ToDouble(Console.ReadLine());
            int time = Convert.ToInt32(Console.ReadLine());
            double si = (principal * rate * time) / 100;
            Console.WriteLine($"The Simple Interest is {si:f} for Principal {principal}, Rate of Interest {rate:f} and Time {time}");
        }
    }
}
