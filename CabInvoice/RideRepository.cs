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
        /// <summary>
        /// Number of Rides
        /// Total Fare
        /// Average Fare per Ride
        /// </summary>
        public CabAverage EnhanceInvoice()
        {
            double totalFare = 0;
            int count = rides.Count;
            foreach(Cab cb in rides)
            {
                totalFare += cb.cost;
            }
            double average = totalFare / count;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine($"Total {count} Rides | Total Fare {totalFare} | Average Fare for {count} Rides is {(float) Math.Round(average, 2)}");
            Console.WriteLine("--------------------------------------------------------------------");
            CabAverage cabAverage = new CabAverage()
            {
                count = count,
                total = totalFare,
                average = average
            };
            return cabAverage;
        }
        public void Repeat()
        {
            Console.WriteLine("1.Single Ride");
            Console.WriteLine("2.Multi Rides");
            Console.WriteLine("3.Create Invoice");
            Console.WriteLine("4.Enhance Invoice");
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
                case 4:
                    EnhanceInvoice();
                    Repeat();
                    break;
                case 0:
                    Console.WriteLine("Exit");
                    break;
            }
        }
    }
}