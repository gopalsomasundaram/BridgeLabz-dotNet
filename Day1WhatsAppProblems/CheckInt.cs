using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1WhatsAppProblems
{
    class CheckInt
    {
        public static void check() {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 0) Console.WriteLine(x * -1);
            else Console.WriteLine(x);
        }
    }
}
