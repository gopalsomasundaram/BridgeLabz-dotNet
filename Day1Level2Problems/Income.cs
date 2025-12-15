using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1Level2Problems
{
    class Income
    {
        public static void calculate()
        {
            int salary = Convert.ToInt32(Console.ReadLine());
            int bonus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {salary+bonus}");
        }
    }
}
