using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class Factorial
    {
        public static void calc()
        {
            int n = int.Parse(Console.ReadLine());
            if(n<0) { Console.WriteLine("Invalid number");return; }
            int result = 1;
            while (n != 1)
            {
                result *= n;
                n--;
            }
            Console.WriteLine($"the result of the factorial is {result}");
        }
    }
}
