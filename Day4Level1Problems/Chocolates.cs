using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level1Problems
{
    internal class Chocolates
    {
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int[] arr = new int[2];
            arr[0] = number / divisor;
            arr[1] = number % divisor;
            return arr;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the number of Chocolates:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbebr of Children:");
            int divisor = int.Parse(Console.ReadLine());
            if(num<=0||divisor<=0) { Console.WriteLine("Invalid Input");return; }
            int[] result = FindRemainderAndQuotient(num, divisor);
            Console.WriteLine($"the Quotient is {result[0]} and the Remainder is {result[1]}");
        }
    }
}
