using System;
using System.Collections.Generic;
using EmfuleniMunicipalityApp;

namespace EmfuleniMunicipalityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===\n");

            List<Resident> residents = new List<Resident>();

            Console.Write("How many residents do you want to register? ");
            int residentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < residentCount; i++)
            {
                Console.WriteLine($"\n--- Resident {i + 1} ---");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Account Number: ");
                int account = int.Parse(Console.ReadLine());

                Console.Write("Monthly Utility Usage (kWh or litres): ");
                double usage = double.Parse(Console.ReadLine());

                residents.Add(new Resident(name, address, account, usage));
            }

            List<ServiceRequest> requests = new List<ServiceRequest>();

            Console.Write("\nHow many service requests do you want to log? ");
            int requestCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < requestCount; i++)
            {
                Console.WriteLine($"\n--- Service Request {i + 1} ---");

                Console.Write("Select resident by number (1 to " + residents.Count + "): ");
                int index = int.Parse(Console.ReadLine()) - 1;

                Console.Write("Request Type (e.g., Water Outage, Burst Pipe): ");
                string type = Console.ReadLine();

                Console.Write("Priority Level (1-5): ");
                int priority = int.Parse(Console.ReadLine());

                Console.Write("Severity Level (1-10): ");
                int severity = int.Parse(Console.ReadLine());

                Console.Write("Estimated Resolution Hours: ");
                int hours = int.Parse(Console.ReadLine());

                ServiceRequest req = new ServiceRequest(type, priority, severity, hours, residents[index]);

                // 🔹 CALCULATIONS (MATCH YOUR SCREENSHOT)
                req.UrgencyScore = priority * severity;
                double adjustedResolution = hours + (severity / 2.0);
                double impactScore = residents[index].MonthlyUsage * severity;

                requests.Add(req);

                // 🔹 SERVICE REPORT OUTPUT
                Console.WriteLine("\n==== Service Report ====");
                Console.WriteLine("Resident: " + req.Resident.Name);
                Console.WriteLine("Service Type: " + req.RequestType);
                Console.WriteLine("Urgency Score: " + req.UrgencyScore);
                Console.WriteLine("Adjusted Resolution: " + adjustedResolution + " hours");
                Console.WriteLine("Household Impact Score: " + impactScore.ToString("F2"));
            }

            // 🔹 FINAL SUMMARY
            Console.WriteLine("\n==== FINAL MUNICIPAL SUMMARY ====");

            ServiceRequest highest = null;
            double highestAdjusted = 0;
            double highestImpact = 0;

            foreach (var req in requests)
            {
                double adjusted = req.EstimatedHours + (req.SeverityLevel / 2.0);
                double impact = req.Resident.MonthlyUsage * req.SeverityLevel;

                if (highest == null || req.UrgencyScore > highest.UrgencyScore)
                {
                    highest = req;
                    highestAdjusted = adjusted;
                    highestImpact = impact;
                }
            }

            Console.WriteLine("Highest priority issue:");
            Console.WriteLine("Resident: " + highest.Resident.Name);
            Console.WriteLine("Service Type: " + highest.RequestType);
            Console.WriteLine("Urgency Score: " + highest.UrgencyScore);
            Console.WriteLine("Adjusted Resolution: " + highestAdjusted + " hours");
            Console.WriteLine("Household Impact Score: " + highestImpact.ToString("F2"));

            Console.WriteLine("\nThank you for using the Emfuleni Municipality Service Desk.");
        }
    }
}