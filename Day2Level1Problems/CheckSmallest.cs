using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class CheckSmallest
    {
        public static void check()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            if (x < y && x < z) { Console.WriteLine($"first number {x} is smallest"); }
            else Console.WriteLine($"first Number {x} is not the smallest");
        }
    }
}
