using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day5Level1Problems
{
    internal class CharacterArray
    {
        static char[] GetCharArray(string str)
        {
            char[] result = new char[str.Length];
            for(int i = 0; i < str.Length; ++i)
            {
                result[i] = str[i];
            }
            return result;
        }
        public static void Main()
        {
            Console.WriteLine("Enter string:");
            string a = Console.ReadLine();
            char[] arr = GetCharArray(a);
            char[] funcMethod = a.ToCharArray();
            Console.WriteLine("Using ToCharArray we get the following:");
            for(int i = 0; i < a.Length; ++i)
            {
                Console.WriteLine(funcMethod[i]);
            }
            Console.WriteLine("Using custom method we get the following:");
            for(int i = 0; i < a.Length; ++i)
            {
                Console.WriteLine(arr[i]);
            }
            for(int i = 0; i < a.Length; ++i)
            {
                if (arr[i] != funcMethod[i])
                {
                    Console.WriteLine("Both results are not same");
                    return;
                }
            }
            Console.WriteLine("Both results are the same");
        }
    }
}
