using System;
using System.Collections.Generic;

namespace QuickRide
{
    // MONOLITHIC GOD-CLASS: Contains tight coupling, direct Console I/O, and hardcoded logic
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to BadQuickRide Campus Hailing ===");
            TeamManifest.PrintManifest();

            string riderName = "Connie Student";
            double distanceKm = 4.2;

            // Magic numbers in fare calculation
            double fare = CalculateFare(distanceKm, true);
            Console.WriteLine($"Rider {riderName} requested ride. Distance: {distanceKm}km. Fare: ${fare:F2}");

            // Procedural, non-deterministic driver matching
            string driver = MatchDriver();
            Console.WriteLine($"Driver {driver} assigned to {riderName}.");
        }

        public static double CalculateFare(double distance, bool isPeakHour)
        {
            double baseRate = 2.50;
            double perKm = 1.25;
            double total = baseRate + (distance * perKm);

            if (isPeakHour)
            {
                total *= 1.20; // 20% surge multiplier
            }

            return Math.Round(total, 2);
        }

        public static string MatchDriver()
        {
            string[] drivers = { "Alex (Prius)", "Sam (Civic)", "Taylor (Corolla)" };
            Random rnd = new Random();
            int idx = rnd.Next(0, drivers.Length);
            return drivers[idx];
        }
    }
}

