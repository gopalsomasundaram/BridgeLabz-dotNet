using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class MultiplicationTables
    {
        public static void print()
        {
            Console.Write("Enter number:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 6; i <= 9; ++i)
            {
                Console.WriteLine($"{n} * {i} = {n*i}");
            }
        }
    }
}
