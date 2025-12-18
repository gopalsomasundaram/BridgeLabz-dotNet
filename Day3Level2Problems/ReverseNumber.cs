using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level2Problems
{
    internal class ReverseNumber
    {
        public static void reverse()
        {
            int num = int.Parse(Console.ReadLine());
            int copy = num;
            int count = 0;
            while (copy!= 0)
            {
                count++;
                copy /= 10;
            }
            //Console.WriteLine(count);
            int[] arr = new int[count];
            int[] rev_arr = new int[count];
            for(int i = 0; i < count; ++i)
            {
                arr[i] = num % 10;
                num /= 10;
                rev_arr[count - 1 - i] = arr[i];
                Console.WriteLine(rev_arr[count - 1 - i]);
            }
        }
    }
}
