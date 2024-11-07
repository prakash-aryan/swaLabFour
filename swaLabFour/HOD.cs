using System;

namespace swaLabFour
{
    public class HOD
    {
        private static HOD instance;
        private static readonly object lockObject = new object();

        // Private fields
        private string name;
        private string dateOfBirth;
        private string joiningDate;
        private string department;
        private string highestQualification;
        private string researchInterest1;
        private string researchInterest2;
        private string researchInterest3;
        private string currentDesignation;
        private string pastDesignation1;
        private string pastDesignation2;
        private string achievement1;
        private string achievement2;
        private string achievement3;
        private string competency1;
        private string competency2;
        private string competency3;

        // Private constructor
        private HOD() { }

        // Singleton getInstance method
        public static HOD getInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new HOD();
                    }
                }
            }
            return instance;
        }

        // Setter methods
        public void setName(string value) { name = value; }
        public void setDateOfBirth(string value) { dateOfBirth = value; }
        public void setJoiningDate(string value) { joiningDate = value; }
        public void setDepartment(string value) { department = value; }
        public void setHighestQualification(string value) { highestQualification = value; }
        public void setResearchInterest1(string value) { researchInterest1 = value; }
        public void setResearchInterest2(string value) { researchInterest2 = value; }
        public void setResearchInterest3(string value) { researchInterest3 = value; }
        public void setCurrentDesignation(string value) { currentDesignation = value; }
        public void setPastDesignation1(string value) { pastDesignation1 = value; }
        public void setPastDesignation2(string value) { pastDesignation2 = value; }
        public void setAchievement1(string value) { achievement1 = value; }
        public void setAchievement2(string value) { achievement2 = value; }
        public void setAchievement3(string value) { achievement3 = value; }
        public void setCompetency1(string value) { competency1 = value; }
        public void setCompetency2(string value) { competency2 = value; }
        public void setCompetency3(string value) { competency3 = value; }

        // Method to display profile
        public void showProfile()
        {
            Console.WriteLine("\n=== HOD Profile ===");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Date of Birth: {dateOfBirth}");
            Console.WriteLine($"Date of Joining: {joiningDate}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Highest Qualification: {highestQualification}");
            Console.WriteLine("\nResearch Interests:");
            Console.WriteLine($"1. {researchInterest1}");
            Console.WriteLine($"2. {researchInterest2}");
            Console.WriteLine($"3. {researchInterest3}");
            Console.WriteLine($"\nCurrent Designation: {currentDesignation}");
            Console.WriteLine("\nPast Designations:");
            Console.WriteLine($"1. {pastDesignation1}");
            Console.WriteLine($"2. {pastDesignation2}");
            Console.WriteLine("\nNotable Achievements:");
            Console.WriteLine($"1. {achievement1}");
            Console.WriteLine($"2. {achievement2}");
            Console.WriteLine($"3. {achievement3}");
            Console.WriteLine("\nSpecial Competencies:");
            Console.WriteLine($"1. {competency1}");
            Console.WriteLine($"2. {competency2}");
            Console.WriteLine($"3. {competency3}");
        }
    }
}