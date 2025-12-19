using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level2Problems
{
    internal class FactorsOfNumber
    {
        static int[] GetFactors(int n)
        {
            int count = 0;
            for(int i = 1; i < n; ++i)
            {
                if (n % i == 0) count++;
            }
            int[] result = new int[count];
            int index = 0;
            for (int i = 1; i < n; ++i)
            {
                if (n % i == 0) result[index++] = i ;
            }
            return result;
        }
        int SumOfFactors(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        int ProductOfFactors(int[] arr)
        {
            int product = 1;
            foreach(int i in arr)
            {
                product *= i;
            }
            return product;
        }
        int SumOfSquaresOfFactors(int[] arr)
        {
            int squaresSum = 0;
            foreach(int i in arr)
            {
                squaresSum += (int) Math.Pow(i, 2);
            }
            return squaresSum;
        }
        public static void Main()
        {
            Console.WriteLine("Enter positive number:");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            int[] result = GetFactors(n);
            Console.WriteLine("the factors of the given number are:");
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
            var obj = new FactorsOfNumber();
            Console.WriteLine($"The Sum of all factors is {obj.SumOfFactors(result)}");
            Console.WriteLine($"The Product of all factors is {obj.ProductOfFactors(result)}");
            Console.WriteLine($"The Sum of Squares of all factors is {obj.SumOfSquaresOfFactors(result)}");
        }
    }
}
