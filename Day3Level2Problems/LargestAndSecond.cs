using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level2Problems
{
    internal class LargestAndSecond
    {
        public static void findLargestAndSecond()
        {
            int number = int.Parse(Console.ReadLine());
            int maxDigits = 10;
            int[] digits = new int[maxDigits];
            int index = 0,largestIndex =0,secondLargestIndex =0;
            while (number != 0)
            {
                if (index + 1 == maxDigits) { digits[index] = number % 10; break; }
                digits[index++] = number%10;
                number /= 10;
            }
            for(int i = 0; i < digits.Length; ++i)
            {
                if (digits[i] > digits[largestIndex]) largestIndex = i;
                if ((digits[i] > digits[secondLargestIndex]) && (i != largestIndex)) secondLargestIndex = i;
            }
            Console.WriteLine($"The largest is {digits[largestIndex]} and {digits[secondLargestIndex]}");
        }
    }
}
