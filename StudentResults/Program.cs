using System;

namespace StudentResultsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for student name
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            // Variables to store marks
            int subj1, subj2, subj3;

            // Input + validation for Subject 1
            Console.Write("Enter mark for Subject 1: ");
            while (!int.TryParse(Console.ReadLine(), out subj1))
            {
                Console.Write("Invalid input. Enter a numeric value: ");
            }

            // Input + validation for Subject 2
            Console.Write("Enter mark for Subject 2: ");
            while (!int.TryParse(Console.ReadLine(), out subj2))
            {
                Console.Write("Invalid input. Enter a numeric value: ");
            }

            // Input + validation for Subject 3
            Console.Write("Enter mark for Subject 3: ");
            while (!int.TryParse(Console.ReadLine(), out subj3))
            {
                Console.Write("Invalid input. Enter a numeric value: ");
            }

            // Calculate total
            int total = subj1 + subj2 + subj3;

            // Calculate average
            double average = total / 3.0;

            // Determine PASS or FAIL
            string result;
            if (average >= 50)
            {
                result = "PASS";
            }
            else
            {
                result = "FAIL";
            }

            // Display results (formatted like screenshot)
            Console.WriteLine("\n===== STUDENT RESULTS =====");
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Result Issued At: " + DateTime.Now);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}