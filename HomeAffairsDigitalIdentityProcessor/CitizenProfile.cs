using System;

namespace HomeAffairsDigitalIdentityProcessor
{
    public class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }
        public string CitizenshipStatus { get; set; }

        public CitizenProfile(string name, string id, string status)
        {
            FullName = name;
            IDNumber = id;
            CitizenshipStatus = status;
            Age = CalculateAge();
        }

        private int CalculateAge()
        {
            try
            {
                string yearPart = IDNumber.Substring(0, 2);
                string monthPart = IDNumber.Substring(2, 2);
                string dayPart = IDNumber.Substring(4, 2);

                int year = int.Parse(yearPart);
                int month = int.Parse(monthPart);
                int day = int.Parse(dayPart);

                int fullYear = (year <= DateTime.Now.Year % 100) ? 2000 + year : 1900 + year;

                DateTime birthDate = new DateTime(fullYear, month, day);

                int age = DateTime.Now.Year - birthDate.Year;

                if (DateTime.Now < birthDate.AddYears(age))
                    age--;

                return age;
            }
            catch
            {
                return -1;
            }
        }

        public string ValidateID()
        {
            if (IDNumber.Length != 13)
                return "Invalid ID. Must be 13 digits.";

            if (!long.TryParse(IDNumber, out _))
                return "Invalid ID. Must be numeric.";

            if (Age < 0)
                return "Invalid ID. Birth date incorrect.";

            return $"Valid ID. Citizen is {Age} years old.";
        }
    }
}