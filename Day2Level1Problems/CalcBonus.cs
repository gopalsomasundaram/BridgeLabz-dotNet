using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class CalcBonus
    {
        public static void calc()
        {
            double salary = double.Parse(Console.ReadLine());
            double years = double.Parse(Console.ReadLine());
            if(years > 5)
            {
                Console.WriteLine($"bonus: {salary*0.05}");
            }
            else
            {
                Console.WriteLine("Not eligible for bonus");
            }
        }
    }
}
