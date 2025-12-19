using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level2Problems
{
    internal class SumNMultipleMethods
    {
        int SumOfNRecursive(int n)
        {
            if (n == 1) return 1;
            else return n + SumOfNRecursive(n - 1);
        }
        int SumOfNFormula(int n)
        {
            return (n * (n + 1) / 2);
        }
        public static void Main()
        {
            Console.WriteLine("Enter Natural Number: ");
            int n = int.Parse(Console.ReadLine());
            if(n<=0) { Console.WriteLine("Invalid Input");return; }
            var obj = new SumNMultipleMethods();
            int resultRecursion = obj.SumOfNRecursive(n);
            int resultFormula = obj.SumOfNFormula(n);
            if(resultRecursion == resultFormula)
            {
                Console.WriteLine($"result from recursion and formula are same : {resultRecursion}");
            }
            else
            {
                Console.WriteLine($"Result from recursion and formula are not the same\nFormula: {resultFormula}\nRecursion: {resultRecursion}");
            }
        }
    }
}
