using System;

namespace EmfuleniMunicipalityApp
{
    public class Resident
    {
        // Properties
        public string Name { get; set; }
        public string Address { get; set; }
        public int AccountNumber { get; set; }
        public double MonthlyUsage { get; set; }

        // Constructor
        public Resident(string name, string address, int accountNumber, double monthlyUsage)
        {
            Name = name;
            Address = address;
            AccountNumber = accountNumber;
            MonthlyUsage = monthlyUsage;
        }

        // Method to display resident info
        public void DisplayResident()
        {
            Console.WriteLine("Resident: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Monthly Usage: " + MonthlyUsage);
        }
    }
}