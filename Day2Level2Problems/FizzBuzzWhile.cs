using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level2Problems
{
    internal class FizzBuzzWhile
    {
        public static void start()
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) { Console.WriteLine("Invalid Number"); return; }
            int i = n;
            while (i <= n)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    i--;
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    i--;
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    i--;
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                    i--;
                    continue;
                }
            }
        }
    }
}
