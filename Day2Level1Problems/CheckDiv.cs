using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    class CheckDiv
    {
        public static void check()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 5 == 0) { Console.WriteLine($"{x} is divisible by 5"); }
            else Console.WriteLine($"{x} is not divisible by 5");
        }
    }
}
