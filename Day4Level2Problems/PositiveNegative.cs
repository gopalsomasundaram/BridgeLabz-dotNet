using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleAppTest.Day4Level2Problems
{
    internal class PositiveNegative
    {
        bool isPositive(int n)
        {
            if (n < 0) return false;
            else return true;
        }
        bool isEven(int n)
        {
            if (n % 2 == 0) return true;
            else return false;
        }
        int compare(int a,int b)
        {
            if (a > b)
            {
                return 1;
            }else if (a == b)
            {
                return 0;
            }
            else { return -1; }
        }
        public static void Main()
        {
            int[] arr = new int[5];
            var obj = new PositiveNegative();
            for(int i = 0; i < arr.Length; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach(int i in arr)
            {
                if (obj.isPositive(i))
                {
                    if (obj.isEven(i))
                    {
                        Console.WriteLine("is even");
                    }else Console.WriteLine("is odd");
                }
                else
                {
                    Console.WriteLine("is negative");
                }
            }
            int result = obj.compare(arr[0], arr[4]);
            if(result == 1)
            {
                Console.WriteLine("first is greater than last");
            }else if (result == 0)
            {
                Console.WriteLine("first and last are equal");
            }else
            {
                Console.WriteLine("first is smaller than last");
            }
        }
    }
}
