using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level1Problems
{
    internal class CheckNumber
    {
        int CheckNum(int n)
        {
            if (n == 0) return 0;
            else if (n < 0) return -1;
            else return 1;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number to be checked");
            int n = int.Parse(Console.ReadLine());
            var obj = new CheckNumber();
            int result = obj.CheckNum(n);
            if (result == 0) Console.WriteLine("number is zero");
            else if (result == 1) Console.WriteLine("number is positive");
            else Console.WriteLine("number is negative");
        }
    }
}
