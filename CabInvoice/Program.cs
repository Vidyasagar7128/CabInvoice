using System;
using System.Collections.Generic;

namespace CabInvoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Cab Invoice!");
            RideRepository rideRepository = new RideRepository();
            rideRepository.Repeat();
        }
    }
}
