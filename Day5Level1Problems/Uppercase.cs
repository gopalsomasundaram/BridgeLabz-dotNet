using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace ConsoleAppTest.Day5Level1Problems
{
    internal class Uppercase
    {
        static string ConvertToUpper(string test)
        {
            char[] arr = new char[test.Length];
            for(int i = 0; i < test.Length; ++i)
            {
                if (char.IsLower(test[i]))
                {
                    int temp = Convert.ToInt32(test[i]);
                    temp = temp - 32;
                    arr[i] = (char)temp;
                }
                else
                {
                    arr[i] = test[i];
                }
            }
            string result = string.Concat(arr);
            return result;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the string:");
            string a = Console.ReadLine();
            Console.WriteLine("Using char manipulation we get");
            string charManip = ConvertToUpper(a);
            Console.WriteLine(charManip);
            string upperFunc = a.ToUpper();
            Console.WriteLine("Using string method we get");
            Console.WriteLine(upperFunc);
            if(String.Equals(charManip, upperFunc))
            {
                Console.WriteLine("Result from both the functions are the same");
            }
            else
            {
                Console.WriteLine("Result from both the functions are not the same");
            }
        }
    }
}
