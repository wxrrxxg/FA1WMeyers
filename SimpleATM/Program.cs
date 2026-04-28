using System;

namespace ATMSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("      CTU SIMPLE ATM SYSTEM      \n");

            // Ask for user name
            Console.Write("HI, WHAT IS YOUR NAME? ");
            string name = Console.ReadLine();

            Console.WriteLine("\nWELCOME " + name.ToUpper() + "!");

            // Variables
            double balance;
            double withdrawal;

            // Input + validation for balance
            Console.Write("Enter account balance: ");
            while (!double.TryParse(Console.ReadLine(), out balance))
            {
                Console.Write("Invalid input. Enter a numeric value: ");
            }

            // Input + validation for withdrawal
            Console.Write("Enter withdrawal amount: ");
            while (!double.TryParse(Console.ReadLine(), out withdrawal))
            {
                Console.Write("Invalid input. Enter a numeric value: ");
            }

            // Check if withdrawal is valid
            if (withdrawal <= balance)
            {
                double updatedBalance = balance - withdrawal;

                Console.WriteLine("\nWithdrawal successful!");
                Console.WriteLine("Updated Balance: " + updatedBalance);
                Console.WriteLine("Transaction Time: " + DateTime.Now);
            }
            else
            {
                Console.WriteLine("\nInsufficient funds!");
                Console.WriteLine("Transaction failed at: " + DateTime.Now);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}