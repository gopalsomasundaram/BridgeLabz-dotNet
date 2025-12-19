using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level1Problems
{
    internal class FindLargestSmallest
    {
        public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {
            int[] result = new int[2];
            if (number1 < number2)
            {
                if (number1 < number3) result[0] = number1;
                else result[0] = number3;
            }
            else
            {
                if (number2 < number3) result[0] = number2;
                else result[0] = number3;
            }
            if (number1 > number2)
            {
                if (number1 > number3) result[1] = number1;
                else result[1] = number3;
            }
            else
            {
                if (number2 > number3) result[1] = number2;
                else result[1] = number3;
            }
            return result;
        }
        public static void Main()
        {
            Console.WriteLine("Enter 3 numbers:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int[] result = FindSmallestAndLargest(n1, n2, n3);
            Console.WriteLine($"the smallest is {result[0]} and the largest is {result[1]}");
        }
    }
}
