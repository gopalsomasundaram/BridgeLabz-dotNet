using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level1Problems
{
    internal class SimpleInterest
    {
        double CalcSimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time/ 100);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the principal");
            double principal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate");
            double rate = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time");
            double time = double.Parse(Console.ReadLine());
            if(principal<=0 || rate <= 0 || time<0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            SimpleInterest obj = new SimpleInterest();
            double result = obj.CalcSimpleInterest(principal,rate,time);
            Console.WriteLine($"The Simple Interest is {result:f} for Principal {principal}, Rate of Interest {rate} and Time {time}");
        }
    }
}
