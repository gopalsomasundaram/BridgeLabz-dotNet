using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1WhatsAppProblems
{
    class PositveOrNegative
    {
        public static void getSign() {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >> 31 == -1) Console.WriteLine("number is negative");
            else if (n >> 31 == 0) Console.WriteLine("Number is positive");
        }
    }
}
