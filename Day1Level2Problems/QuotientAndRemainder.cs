using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1Level2Problems
{
    class QuotientAndRemainder
    {
        public static void calculate()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Quotient is {num1/num2} and Remainder is {num1%num2} of two numbers {num1} and {num2}");
        }
    }
}
