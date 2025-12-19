using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level1Problems
{
    internal class SumOfNaturalNumbers
    {
        int calculateSum(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n;
                n--;
            }
            return sum;
        }
        public static void Main()
        {
            Console.WriteLine("Enter a natural number:");
            int n = int.Parse(Console.ReadLine());
            if(n<=0) { Console.WriteLine("Invalid Input");return; }
            var obj = new  SumOfNaturalNumbers();
            Console.WriteLine($"Sum of natural numbers upto {n} is {obj.calculateSum(n)}");
        }
    }
}
