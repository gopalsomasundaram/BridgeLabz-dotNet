using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class CheckLargest
    {
        public static void check()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            if(x>y)
            {
                if (x > z)
                {
                    Console.WriteLine($"{x} is the biggest");
                }
                else Console.WriteLine($"{z} is the biggest");
            }
            else
            {
                if (y > z) Console.WriteLine($"{y} is the biggest");
                else Console.WriteLine($"{z} is the biggest");
            }
        }
    }
}
