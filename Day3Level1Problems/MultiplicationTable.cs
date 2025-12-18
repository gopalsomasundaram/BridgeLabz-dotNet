using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level1Problems
{
    internal class MultiplicationTable
    {
        public static void printTables()
        {
            int n = int.Parse(Console.ReadLine());
            int[] table = new int[10];
            for(int i = 1; i <= 10; i++)
            {
                table[i-1] = i * n;
                Console.WriteLine($"{n} * {i} = {table[i-1]}");
            }
        }
    }
}
