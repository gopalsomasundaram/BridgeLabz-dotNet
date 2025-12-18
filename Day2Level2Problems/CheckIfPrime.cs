using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level2Problems
{
    internal class CheckIfPrime
    {
        public static void check()
        {
            Console.WriteLine("Enter number to be checked if prime: ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 1) { Console.WriteLine("Invalid");return; }
            bool isPrime;
            int count = 0;
            for(int i = 2; i <= num; i++)
            {
                if (num % i == 0) { 
                    count+=1; 
                    //Console.WriteLine(i);
                }
            }
            //Console.WriteLine(count);
            if (count != 1) { isPrime = false; } else { isPrime = true; }
            if (isPrime) Console.WriteLine($"{num} is prime");
            else Console.WriteLine($"{num} is not prime");
        }
    }
}
