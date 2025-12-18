using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level3Problems
{
    internal class Abundant
    {
        public static void check()
        {
            Console.WriteLine("Enter number to check if Abundant: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum > n) Console.WriteLine($"{n} is abundant");
            else Console.WriteLine($"{n} is not abundant");
        }
    }
}
