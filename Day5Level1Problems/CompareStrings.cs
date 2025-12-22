using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day5Level1Problems
{
    internal class CompareStrings
    {
        static bool IsSameStringMethod1(string a, string b)
        {
            for(int i = 0; i < a.Length; ++i)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main()
        {
            string a, b;
            Console.WriteLine("Enter first string:");
            a = Console.ReadLine();
            Console.WriteLine("Enter the second string: ");
            b = Console.ReadLine();
            if (a.Length != b.Length)
            {
                Console.WriteLine("The strings are not of equal size, invalid input");
            }
            bool result = IsSameStringMethod1(a, b);
            if (result)
            {
                Console.WriteLine("The index method gives true");
            }
            else
            {
                Console.WriteLine("The index method gives false");
            }
            if (string.Equals(a, b))
            {
                Console.WriteLine("The string method gives true");
            }
            else
            {
                Console.WriteLine("The string method gives false");
            }
        }
    }
}
