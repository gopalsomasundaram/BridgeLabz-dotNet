using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class RemoveChar
    {
        static string RemChar(string str, char x)
        {
            return str.Replace(Convert.ToString(x), "");
        }
        public static void Main()
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the character you want to be removed:");
            char c = Convert.ToChar(Console.ReadLine());
            str = RemChar(str,c);
            Console.WriteLine($"Result: {str}");
        }
    }
}
