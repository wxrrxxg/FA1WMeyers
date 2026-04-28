using System;

namespace EmfuleniMunicipalityApp
{
    public class UtilitiesManager
    {
        // Calculate urgency score
        public double CalculateUrgency(int priority, int severity)
        {
            return priority * severity;
        }

        // Generate full report
        public void GenerateReport(ServiceRequest request)
        {
            Console.WriteLine("\n==== SERVICE REPORT ====");

            request.Resident.DisplayResident();
            request.DisplayRequest();
        }
    }
}
