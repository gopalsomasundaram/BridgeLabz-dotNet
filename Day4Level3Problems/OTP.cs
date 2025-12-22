using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level3Problems
{
    internal class OTP
    {
        static int GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000,1000000);
        }
        static int[] CreateArray()
        {
            int[] arr = new int[10];
            for(int i = 0; i < 10; i++)
            {
                arr[i] = GenerateOTP();
                Console.WriteLine(arr[i]);
            }
            return arr;
        }
        static bool AllUnique(int[] arr)
        {
            for(int i = 0; i < 9; i++)
            {
                for(int j = i + 1; j < 10; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static void Main()
        {
            int[] arr = CreateArray();
            if (AllUnique(arr))
            {
                Console.WriteLine("All Generated values are unique");
            }
            else Console.WriteLine("There are same generated values");
        }
    }
}
