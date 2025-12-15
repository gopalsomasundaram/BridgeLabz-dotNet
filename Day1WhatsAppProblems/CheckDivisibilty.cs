using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1WhatsAppProblems
{
    class CheckDivisibilty
    {
        public static void check() {
            int inp = Convert.ToInt32(Console.ReadLine());
            bool divBy3 = (inp % 3 == 0);
            bool divBy5 = (inp % 5 == 0);
            if ((divBy3 || divBy5) && !(divBy3 && divBy5))
            {
                Console.WriteLine("Condition is true");
            }
            else Console.WriteLine("Condition is false");
        }
    }
}
