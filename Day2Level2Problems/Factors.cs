using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level2Problems
{
    internal class Factors
    {
        public static void findFactor()
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i < n; ++i)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{i} is a Factor");
                }
            }
        }
    }
}
