using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level2Problems
{
    internal class LargestAndSecondReworked
    {
        public static void findLargestAndSecond()
        {
            long number = long.Parse(Console.ReadLine());
            int maxDigits = 10;
            int[] digits = new int[maxDigits];
            int index = 0, largestIndex = maxDigits-1, secondLargestIndex = maxDigits-1;
            while (number != 0)
            {
                if (index == maxDigits) {
                    int[] temp = new int[maxDigits];
                    temp = digits;
                    maxDigits += 10;
                    int[] biggerDigits = new int[maxDigits];
                    for (int i = 0; i < maxDigits-10; ++i)
                    {
                        biggerDigits[i] = temp[i];
                    }
                    digits = biggerDigits;
                }
                digits[index++] = Convert.ToInt32(number % 10);
                number /= 10;
            }
            foreach (int i in digits) {Console.WriteLine(i);}
            for (int i = 0; i < digits.Length; ++i)
            {
                if (digits[i] > digits[largestIndex]) {
                    secondLargestIndex = largestIndex;
                    largestIndex = i; 
                }
                if ((digits[i] > digits[secondLargestIndex]) && (i != largestIndex)) secondLargestIndex = i;
            }
            Console.WriteLine($"The largest is {digits[largestIndex]} and {digits[secondLargestIndex]}");
        }
    }
}
