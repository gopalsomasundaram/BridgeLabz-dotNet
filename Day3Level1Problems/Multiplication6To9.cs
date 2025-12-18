using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level1Problems
{
    internal class Multiplication6To9
    {
        public static void computeTable()
        {
            int n = int.Parse(Console.ReadLine());
            int[] multiplicationResult = new int[4];
            int multiplyBy = 6;
            for(int i = 0; i < multiplicationResult.Length; i++)
            {
                multiplicationResult[i] = n * multiplyBy;
                Console.WriteLine($"{n} * {multiplyBy} = {multiplicationResult[i]}");
                multiplyBy++;
            }
        }
    }
}
