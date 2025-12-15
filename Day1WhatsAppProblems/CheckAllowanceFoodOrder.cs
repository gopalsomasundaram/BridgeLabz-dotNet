using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1WhatsAppProblems
{
    class CheckAllowanceFoodOrder
    {
        public static void check()
        {
            bool isRestaurantOpen = Convert.ToBoolean(Console.ReadLine());
            bool isDeliveryPartner = Convert.ToBoolean(Console.ReadLine());
            int OrderAmount = Convert.ToInt32(Console.ReadLine());
            bool isCustomerPrime = Convert.ToBoolean(Console.ReadLine());
            if (isRestaurantOpen && isDeliveryPartner)
            {
                if (OrderAmount >= 200 || isCustomerPrime) Console.WriteLine("Order Accepted");
                else Console.WriteLine("Order Rejected");
            }
            else { Console.WriteLine("Order Rejected"); }
        }
    }
}
