using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class CheckSpring
    {
        public static void check()
        {
            int month = Convert.ToInt32(Console.ReadLine());
            int day = Convert.ToInt32(Console.ReadLine());
            if ((month > 3) && (month < 6))
            {
                Console.WriteLine("It is a spring season");
                return;
            }
            if (((month == 3) && (day >= 20)) || ((month == 6) && (day <= 20)))
            {
                Console.WriteLine("It is a spring season");
                return;
            }
            else Console.WriteLine("It is not a spring season");
            
        }
    }
}
