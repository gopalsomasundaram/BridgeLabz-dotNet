using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level2Problems
{
    internal class BiggestFactor
    {
        public static void find()
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            int greatestFactor = 1;
            for(int i = n -1; i > 1; i--)
            {
                if(n%i == 0)
                {
                    greatestFactor = i;break;
                }
            }
            Console.WriteLine($"Greatest Factor of {n} is {greatestFactor}");
        }
    }
}
