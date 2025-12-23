using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class ToggleCase
    {
        static string CaseToggle(string str)
        {
            char[] arr = str.ToCharArray();
            for(int i = 0; i < arr.Length; ++i)
            {
                if (char.IsLower(arr[i]))
                {
                    arr[i] = char.ToUpper(arr[i]);
                }else if (char.IsUpper(arr[i]))
                {
                    arr[i] = char.ToLower(arr[i]);
                }
            }
            return string.Concat(arr);
        }
        public static void Main()
        {
            Console.WriteLine("Enter the String:");
            string input = Console.ReadLine();
            Console.WriteLine("The toggled case of the given string is: ");
            Console.WriteLine(CaseToggle(input));
        }
    }
}
