using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level2Problems
{
    internal class FizzBuzz
    {
        public static void start()
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) { Console.WriteLine("Invalid Number");return; }
            for(int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                    continue;
                }
            }
        }
    }
}
