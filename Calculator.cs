using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return (x - y);
        }
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numbers are {x} and {y}\naddition: {Add(x,y)}\nSubtraction: {Subtract(x,y)}");
        }
    }
}
