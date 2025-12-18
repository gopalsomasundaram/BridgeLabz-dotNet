using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class PrintOddEven
    {
        public static void start()
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i < n; ++i)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is even");
                }
                else { Console.WriteLine($"{i} is odd"); }
            }
        }
    }
}
