using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1Level2Problems
{
    class DivideChocolates
    {
        public static void calc()
        {
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number of chocolates each child gets is {numberOfChocolates/numberOfChildren} and the number of remaining chocolates is {numberOfChocolates%numberOfChildren}");
        }
    }
}
