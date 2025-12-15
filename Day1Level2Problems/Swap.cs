using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1Level2Problems
{
    class Swap
    {
        public static void swapVars()
        {
            int var1 = Convert.ToInt32(Console.ReadLine());
            int var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"swapped: {var2} {var1}");
        }
    }
}
