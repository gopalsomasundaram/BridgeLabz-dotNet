using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class CheckNumber
    {
        public static void check()
        {
            int n = Convert.ToInt32 (Console.ReadLine());
            if (n == 0) Console.WriteLine("zero");
            else if (n < 0) Console.WriteLine("negative");
            else Console.WriteLine("positive");
        }
    }
}
