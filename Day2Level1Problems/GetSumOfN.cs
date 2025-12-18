using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class GetSumOfN
    {
        public static void check()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0) { return; Console.WriteLine($"The number {n} is not a natural number"); }
            int sum = 0;
            for(int i = 0; i <= n; ++i)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of {n} natural numbers is {sum}");
        }
    }
}
