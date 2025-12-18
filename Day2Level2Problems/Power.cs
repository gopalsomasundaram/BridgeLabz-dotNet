using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level2Problems
{
    internal class Power
    {
        public static void calc()
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter power:");
            int power = int.Parse(Console.ReadLine());
            int result = 1;
            for(int i = 0; i < power; ++i)
            {
                result *= num;
            }
            Console.WriteLine($"result: {result}");
        }
    }
}
