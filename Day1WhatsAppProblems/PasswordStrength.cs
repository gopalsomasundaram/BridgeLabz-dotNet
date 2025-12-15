using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleAppTest.Day1WhatsAppProblems
{
    class PasswordStrength
    {
        public static void checkStrength()
        {
            string passwd = Console.ReadLine();
            int passing = 0;
            if (CheckDigit(passwd)) passing++;
            if (CheckLength(passwd)) passing++;
            if (CheckSpecialChar(passwd)) passing++;
            if (passing <= 1) Console.WriteLine("Weak");
            else if (passing == 2) Console.WriteLine("Medium");
            else Console.WriteLine("Strong");
        }
        static bool CheckLength(string passwd)
        {
            if (passwd.Length >= 8) return true;
            else return false;
        }
        static bool CheckDigit(string passwd)
        {
            if (passwd.Any(char.IsDigit)) { return true; }
            else return false;
        }
        static bool CheckSpecialChar(string passwd)
        {
            char[] SpecialChars = "!@#$%^&*(){}[]:;'\"<,>.?/".ToCharArray();
            if (passwd.IndexOfAny(SpecialChars) != -1)
            {
                return true;
            }
            else { return false; }
        }
    }
}
