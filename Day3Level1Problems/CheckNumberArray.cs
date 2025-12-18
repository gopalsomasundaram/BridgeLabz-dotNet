using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level1Problems
{
    internal class CheckNumberArray
    {
        public static void check()
        {
            int[] arr = new int[5];
            for(int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < arr.Length;i++)
            {
                if (arr[i] > 0)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Console.WriteLine($"{arr[i]} is even");
                    }
                    else Console.WriteLine($"{arr[i]} is odd");
                }
                else if (arr[i] == 0)
                {
                    Console.WriteLine($"{arr[i]} is zero");
                }
                else Console.WriteLine($"{arr[i]} is negative");
            }
            if (arr[0] < arr[arr.Length - 1])
            {
                Console.WriteLine("first is smaller than last element is array");
            }
            else if (arr[0] == arr[arr.Length - 1]) Console.WriteLine("first is equal to last element in array");
            else Console.WriteLine("first is bigger than last element in array");
        }
    }
}
