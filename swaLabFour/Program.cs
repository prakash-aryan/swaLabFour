using System;

namespace swaLabFour
{
    class SingletonPatternTester
    {
        static void Main(string[] args)
        {
            // Get HOD instance
            HOD csHOD = HOD.getInstance();

            // Set profile information
            csHOD.setName("Prakash Aryan");
            csHOD.setDateOfBirth("2001"); 
            csHOD.setJoiningDate("September 2023");
            csHOD.setDepartment("Computer Science");
            csHOD.setHighestQualification("Master of Engineering in Software Systems, BITS Pilani Dubai Campus");
            csHOD.setResearchInterest1("Robotics and Robot Operating System (ROS1 and ROS2)");
            csHOD.setResearchInterest2("Machine Learning & AI - LLMs, Computer Vision, Deep Learning");
            csHOD.setResearchInterest3("Extended Reality (XR) and Human-Robot Interaction");
            csHOD.setCurrentDesignation("Teaching Assistant (Lab), BITS Pilani Dubai Campus");
            csHOD.setPastDesignation1("Unity and Artificial Intelligence Developer Intern, Sparkslab Technology");
            csHOD.setPastDesignation2("Software Developer, Al Ghwasa Technical Equipment Trading LLC");
            csHOD.setAchievement1("Developed VR/MR apps for robot control with 20+ simulations in MetaQuest 3");
            csHOD.setAchievement2("Implemented SLAM algorithms achieving 95% accuracy in unknown environments");
            csHOD.setAchievement3("Created and deployed custom ROS2 packages improving modularity and scalability");
            csHOD.setCompetency1("Expertise in multiple programming languages including Python, C++, C#, JavaScript");
            csHOD.setCompetency2("Advanced knowledge in Robotics, SLAM, Navigation Stack, and Robot Operating System");
            csHOD.setCompetency3("Proficient in Machine Learning, AI, and Extended Reality technologies");

            // Display the profile
            csHOD.showProfile();

            // Demonstrate singleton behavior
            HOD anotherInstance = HOD.getInstance();
            Console.WriteLine("\nDemonstrating Singleton Pattern:");
            Console.WriteLine($"Are both instances the same? {ReferenceEquals(csHOD, anotherInstance)}");

            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}