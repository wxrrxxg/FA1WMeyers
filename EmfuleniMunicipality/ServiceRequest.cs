using System;

namespace EmfuleniMunicipalityApp
{
    public class ServiceRequest
    {
        // Properties
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }
        public int SeverityLevel { get; set; }
        public int EstimatedHours { get; set; }

        public double UrgencyScore { get; set; }

        public Resident Resident { get; set; }

        // Constructor
        public ServiceRequest(string requestType, int priority, int severity, int hours, Resident resident)
        {
            RequestType = requestType;
            PriorityLevel = priority;
            SeverityLevel = severity;
            EstimatedHours = hours;
            Resident = resident;
        }

        // Display request details
        public void DisplayRequest()
        {
            Console.WriteLine("Service Type: " + RequestType);
            Console.WriteLine("Priority Level: " + PriorityLevel);
            Console.WriteLine("Severity Level: " + SeverityLevel);
            Console.WriteLine("Estimated Hours: " + EstimatedHours);
            Console.WriteLine("Urgency Score: " + UrgencyScore);
        }
    }
}
