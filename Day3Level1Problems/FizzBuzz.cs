using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleAppTest.Day3Level1Problems
{
    internal class FizzBuzz
    {
        public static void start()
        {
            int num = int.Parse(Console.ReadLine());
            if (num <= 0) { Console.WriteLine("Invalid Number"); return; }
            string[] arr = new string[num];
            for(int i = 0; i < num; ++i)
            {
                if ((i % 3==0) && (i % 5==0))
                {
                    arr[i] = "FizzBuzz";
                    continue;
                }
                else if(i%3 == 0)
                {
                    arr[i] = "Fizz";
                    continue;

                }
                else if (i % 5 == 0)
                {
                    arr[i] = "Buzz";
                    continue;
                }
                else
                {
                    arr[i] = i.ToString();
                }
            }
            for(int i = 0; i < num; ++i)
            {
                Console.WriteLine($"Position {i + 1} = {arr[i]}");
            }
        }
    }
}
