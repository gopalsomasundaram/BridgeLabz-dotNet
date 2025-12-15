using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1Level2Problems
{
    class Travelling
    {
        public static void show()
        {
            string fromCity, viaCity, toCity;
            int distanceFromToVia, distanceViaToFinal;
            int timeTaken;
            Console.Write("Enter city you are travelling from: ");
            fromCity = Console.ReadLine();
            Console.Write("Enter city you are travelling Via: ");
            viaCity = Console.ReadLine();
            Console.Write("Enter city you are travelling to: ");
            toCity = Console.ReadLine();
            Console.Write($"distance from {fromCity} to {viaCity}: ");
            distanceFromToVia = Convert.ToInt32(Console.ReadLine());
            Console.Write($"distance from {viaCity} to {toCity}: ");
            distanceViaToFinal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the time taken to travel in minutes: ");
            timeTaken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You are travelling from {fromCity} to {toCity} via {viaCity}");
            Console.WriteLine($"{viaCity} is a distance of {distanceFromToVia} away from {fromCity}");
            Console.WriteLine($"{toCity} is a distane of {distanceViaToFinal} away from {viaCity}");
            Console.WriteLine($"The trip takes {timeTaken/60} hours and {timeTaken%60} minutes");
        }
    }
}
