# Singleton Pattern Implementation - HOD Profile

## Problem Statement
Design Pattern Implementation: SINGLETON PATTERN for Head of Department (HOD) Profile System.

The problem requires creating an object of class HOD containing a profile for the Head of Department in an educational institution. Since a department has a single HOD, the object needs to be created using the SINGLETON PATTERN design approach. The program contains:
- Class definition for HOD implementing singleton pattern
- Class SingletonPatternTester containing the main() method to test the singleton class

## Project Structure
```
swaLabFour/
├── HOD.cs                 # HOD class implementing singleton pattern
├── Program.cs             # SingletonPatternTester class with main method
└── README.md             # Project documentation
```

## Implementation Details
- Language: C# (.NET Framework)
- Design Pattern: Singleton (Creational Pattern)
- Thread-safe implementation
- Java-style method naming (getInstance(), setXXX(), showProfile())

## Features
1. Singleton HOD class with:
   - Private constructor
   - Static instance
   - Thread-safe getInstance() method
   - Setter methods for all profile fields
   - Profile display method

2. Profile information includes:
   - Personal details
   - Educational qualifications
   - Research interests
   - Current & past designations
   - Achievements
   - Special competencies

## How to Run

### Clone the Repository
```bash
git clone git@github.com:prakash-aryan/swaLabFour.git
cd swaLabFour
```

### Using Visual Studio
1. Open the solution file (swaLabFour.sln)
2. Build the solution (Ctrl + Shift + B)
3. Run the program (F5 or Ctrl + F5)

### Using Command Line
```bash
# Navigate to project directory
cd swaLabFour

# Build the project
dotnet build

# Run the project
dotnet run
```

## Output
The program will display:
1. Complete HOD profile with all details
2. Demonstration of singleton pattern behavior
