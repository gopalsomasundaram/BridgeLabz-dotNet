using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ConsoleAppTest.Day2Level3Problems
{
    internal class Calculator
    {
        public static void calc()
        {
            Console.WriteLine("enter the numver of times you want to perform operations: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; ++i)
            {
                Console.WriteLine("Enter first number: ");
                double first = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                double second = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter operator (*,/,+,-): ");
                char op = char.Parse(Console.ReadLine());
                switch (op)
                {
                    case '*':
                        Console.WriteLine($"Result: {first * second:f}");
                        break;
                    case '/':
                        Console.WriteLine($"Result: {first / second:f}");
                        break;
                    case '+':
                        Console.WriteLine($"Result: {first + second:f}");
                        break;
                    case '-':
                        Console.WriteLine($"Result: {first - second:f}");
                        break;
                    default:
                        Console.WriteLine("Invalid Operator");
                        break;
                }
            }
        }
    }
}
