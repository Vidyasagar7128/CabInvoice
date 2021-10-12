using System;
using System.Collections.Generic;

namespace CabInvoice
{
    class Program
    {
        static Dictionary<string, RideRepository> invoiceIds = new Dictionary<string, RideRepository>();

        public static void ShowIds()
        {
            foreach (var id in invoiceIds)
            {
                Console.WriteLine($"InvoiceID: {id.Key}");
            }
        }
        public static void SetRide(string id)
        {
            if (invoiceIds.ContainsKey(id))
            {
                RideRepository rideRepository = invoiceIds[id];
                rideRepository.Repeat(id);
            }
            else
            {
                Console.WriteLine($"{id}: ID is not found");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Cab Invoice!");
            bool continueLoop = true;
            while (continueLoop)
            {
                Console.WriteLine(
                        "\nEnter 1. To Create Ride\nEnter 2. Check status for Invoice ID\nEnter 3. To Print Invoice ID\nEnter 0 To Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string rideID = new Random().Next(10000, 99999).ToString();
                        RideRepository ride = new RideRepository();
                        invoiceIds[rideID] = ride;
                        SetRide(rideID);
                        break;
                    case 2:
                        Console.Write("Check Invoice using InvoiceId: ");
                        String rides = Console.ReadLine();
                        SetRide(rides);
                        break;
                    case 3:
                        ShowIds();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        continueLoop = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
