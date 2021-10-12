using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoice
{
    class RideRepository
    {
        List<Cab> rides = new List<Cab>();
        public void Cabs()
        {
            Console.Write("Enter Distance in Kilometer(KM): ");
            double km = double.Parse(Console.ReadLine());
            if (km > 0.5)
                CabRide(km, 10);
            else
                CabRide(km, 5);
        }
        /// <summary>
        /// Calculate Fare & return it
        /// </summary>
        /// <param name="km"></param>
        /// <param name="kmLowPrice"></param>
        /// <returns></returns>
        public List<Cab> CabRide(double km, double kmLowPrice)
        {
            double kmPrice = km * kmLowPrice;
            double timePrice = km * 1.0;
            double total = kmPrice + timePrice;
            Cab cab = new Cab()
            {
                kilometer = kmPrice,
                minute = timePrice,
                cost = total
            };
            rides.Add(cab);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Kilometer Price: {kmPrice} Time Price: {timePrice} Total: {total}");
            Console.WriteLine("------------------------------------------------");
            return rides;
        }
        public void ShowInvoices()
        {
            int count = 0;
            Console.WriteLine("------------------------------------------------");
            foreach(Cab i in rides)
            {
                count++;
                Console.WriteLine($"{count}. Kilometer Price: {i.kilometer} Time Price: {i.minute} Total: {i.cost}");
                Console.WriteLine("------------------------------------------------");
            }
        }
        public void Repeat()
        {
            Console.WriteLine("1.Single Ride");
            Console.WriteLine("2.Multi Rides");
            Console.WriteLine("3.Create Invoice");
            Console.WriteLine("0.Exit");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Cabs();
                    break;
                case 2:
                    Cabs();
                    Repeat();
                    break;
                case 3:
                    ShowInvoices();
                    Repeat();
                    break;
                case 0:
                    Console.WriteLine("Exit");
                    break;
            }
        }
    }
}