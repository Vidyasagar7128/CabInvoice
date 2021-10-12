using System;
using System.Collections.Generic;

namespace CabInvoice
{
    class Program
    {
        public static double CabRide(double km, double kmLowPrice)
        {
            double kmPrice = km * kmLowPrice;
            double timePrice = km * 1.0;
            double total = kmPrice + timePrice;
            Console.WriteLine($"Kilometer Price: {kmPrice} Time Price: {timePrice} Total: {total}");
            Cab cab = new Cab()
            {
                kilometer = kmPrice,
                minute = timePrice,
                cost = total
            };
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Cab Invoice!");
            Console.Write("Enter Distance in Kilometer(KM): ");
            double km = double.Parse(Console.ReadLine());
            if (km > 0.5)
                Console.WriteLine($"Total Fare: {CabRide(km, 10)}");
            else
                Console.WriteLine($"Total Fare: {CabRide(km, 5)}");
        }
    }
}
