using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class ReverseString
    {
        static string Reverse(string test)
        {
            char[] arr = new char[test.Length];
            int index = test.Length-1;
            for(int i = 0; i < test.Length; ++i)
            {
                arr[index--] = test[i];
            }
            return string.Concat(arr);
        }
        public static void Main()
        {
            Console.WriteLine("Enter string to reverse");
            string str = Console.ReadLine();
            Console.WriteLine("reverses string");
            Console.WriteLine(Reverse(str));
        }
    }
}
