using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1WhatsAppProblems
{
    class SimplifyIf
    {
        //example if for checking if there user is member and bill is higher than threshold and sale is going on

        public static void deepIf()
        {
            bool userMemberStatus = Convert.ToBoolean(Console.ReadLine());
            int userBill = Convert.ToInt32(Console.ReadLine());
            bool isThereHolidaySale = Convert.ToBoolean(Console.ReadLine());
            if (userMemberStatus)
            {
                if(userBill >= 7500)
                {
                    if (isThereHolidaySale)
                    {
                        Console.WriteLine("The user is eligible for discount");
                    }
                    else { Console.WriteLine("User is not eligible for discount"); }
                }
                else{ Console.WriteLine("User is not eligible for discount"); }

            }else { Console.WriteLine("User is not eligible for discount"); }
        }
        public static void simpleIf()
        {
            bool userMemberStatus = Convert.ToBoolean(Console.ReadLine());
            int userBill = Convert.ToInt32(Console.ReadLine());
            bool isThereHolidaySale = Convert.ToBoolean(Console.ReadLine());
            if (userMemberStatus && isThereHolidaySale && (userBill >= 7500))
            {
                Console.WriteLine("The user is eligible for discount");
            }
            else { Console.WriteLine("The user is not eligible for discount"); }
        }
    }
}
