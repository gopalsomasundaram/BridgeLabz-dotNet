using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level1Problems
{
    internal class OddEvenArrays
    {
        public static void start()
        {
            int number = int.Parse(Console.ReadLine());
            if(number <= 0) { Console.WriteLine("Invalide number");return; }
            int size = number / 2 + 1;
            int[] oddArray = new int[size];
            int[] evenArray = new int[size];
            int oddIndex = 0, evenIndex = 0;
            for(int i = 1; i <= number; ++i)
            {
                if (i % 2 == 0)
                {
                    evenArray[evenIndex++] = i;
                }
                else oddArray[oddIndex++] = i;
            }
            Console.WriteLine("Even Array:");
            foreach (int i in evenArray)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("Odd Array:");
            foreach (int i in oddArray)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
