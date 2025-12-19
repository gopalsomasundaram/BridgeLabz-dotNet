using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level1Problems
{
    internal class QuotientAndRemainder
    {
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int[] arr = new int[2];
            arr[0] = number/divisor;
            arr[1] = number%divisor;
            return arr;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the dividend:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor:");
            int divisor = int.Parse(Console.ReadLine());
            int[] result = FindRemainderAndQuotient(num, divisor);
            Console.WriteLine($"the Quotient is {result[0]} and the Remainder is {result[1]}");
        }
    }
}
