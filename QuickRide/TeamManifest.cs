using System;
using System.Collections.Generic;

namespace QuickRide
{
    public static class TeamManifest
    {
        // EXERCISE 1: Each team member appends their details on their feature branch
        public static readonly List<string> Members = new List<string>
        {
            "Developer 1: [Insert Name] - Role: Domain Entities",
            "Developer 2: [Insert Name] - Role: Dispatch Service",
            "Developer 3: [Insert Name] - Role: Billing Service",
            "Developer 4: Quadri Bashiru Kolawole - Student ID: 9082146 - Role: AAA Unit Test Suite",
            "Developer 5: [Insert Name] - Role: UI Abstraction (Optional)"
        };

        public static void PrintManifest()
        {
            Console.WriteLine("--- Team Roster & Role Assignments ---");
            foreach (var m in Members)
            {
                Console.WriteLine($"  * {m}");
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}
