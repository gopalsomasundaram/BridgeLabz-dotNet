using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level2Problems
{
    internal class Multiples
    {
        public static void find()
        {
            Console.WriteLine("Enter number below 100: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factors of given number are: ");
            for(int i = 100; i >= 1; i--)
            {
                if(n%i == 0)
                {
                    Console.WriteLine(i);
                    continue;
                }
            }
        }
    }
}
