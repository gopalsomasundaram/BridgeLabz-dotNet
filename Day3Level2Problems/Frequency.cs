using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level2Problems
{
    internal class Frequency
    {
        public static void getFreq()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int copy = n;
            while (copy != 0)
            {
                count++;
                copy /= 10;
            }
            int[] arr = new int[count];
            for(int i = 0; i < count; ++i)
            {
                arr[i] = n % 10;
                n /= 10;
            }
            int[] frequencyArr = new int[10];
            foreach (int i in arr)
            {
                frequencyArr[i]++;
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}->{frequencyArr[i]}");
            }
        }
    }
}
