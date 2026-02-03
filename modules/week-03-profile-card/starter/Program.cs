namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        // - Hometown (city, state)
        // - Favorite color
        // - Dream job
        // Hint: string variableName = Console.ReadLine();
        string fullName;
        string city;
        string state;
        string favColor;
        string dreamJob;

        Console.Write("\nPlease inform your full name: ");
        fullName = Console.ReadLine();

        Console.Write("\nWhat's the city where you were born? ");
        city = Console.ReadLine();

        Console.Write("\nWhat state are you from? ");
        state = Console.ReadLine();

        Console.Write("\nWhat is your favorite color? ");
        favColor = Console.ReadLine();

        Console.Write("\nWhat is your dream job? ");
        dreamJob = Console.ReadLine();

        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        // - GPA (double, 0.0-4.0)
        // - Graduation year (int)
        // - Is full-time student? (bool from yes/no)
        // Hint: double gpa = double.Parse(Console.ReadLine());
        // Hint: bool isFullTime = answer.ToLower() == "yes";
        string major;
        double gpa;
        int gradYear;
        string ftStudent;

        Console.Write("\nWhat is your major? ");
        major = Console.ReadLine();

        Console.Write("\nWhat is your current GPA? ");
        gpa = double.Parse(Console.ReadLine());

        Console.Write("\nWhat is your graduation year? ");
        gradYear = int.Parse(Console.ReadLine());

        Console.Write("\nAre you a full-time student? (yes/no) ");
        ftStudent = Console.ReadLine().Trim().ToLower();

        bool fullTimeStudent;

        if (ftStudent == "yes")
        {
            fullTimeStudent = true;
        }
        else if (ftStudent == "no")
        {
            fullTimeStudent = false;
        }
        else
        {
            Console.WriteLine("Invalid answer. Selecting 'no' as default.");
            fullTimeStudent = false;
        }

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        // - Height in inches (double)
        // - Favorite number (int)
        int age;
        double heightInches;
        int favNumber;

        Console.Write("\nAge: ");
        age = int.Parse(Console.ReadLine());

        Console.Write("\nHeight in inches: ");
        heightInches = double.Parse(Console.ReadLine());

        Console.Write("\nWhat is your favorite number? ");
        favNumber = int.Parse(Console.ReadLine());

        // TODO: CALCULATE derived information
        // - Birth year = 2026 - age
        // - Years to graduation = graduationYear - 2026
        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        // - Is honor student? = gpa >= 3.5
        // - Age in months = age * 12
        int birthYear = 2026 - age;
        int yearsToGrad = gradYear - 2026;
        int heightFeet = (int)(heightInches / 12);
        double inches = heightInches % 12;
        bool honorStudent;
        int ageMonths = age * 12;

        if (gpa >= 3.5)
        {
            honorStudent = true;
        }
        else
        {
            honorStudent = false;
        }

        // TODO: DISPLAY formatted profile card
        // Use sections with headers:
        // - PERSONAL INFORMATION
        // - ACADEMIC DETAILS
        // - CALCULATED STATISTICS
        // Use proper alignment and formatting
        Console.WriteLine("\n╔═══════════════════════════════════════════╗");
        Console.WriteLine("║               Profile Card                ║");
        Console.WriteLine("╠═══════════════════════════════════════════╣");
        Console.WriteLine($"║{"PERSONAL INFORMATION",-43}║");
        Console.WriteLine($"║{"___________________________________________",-43}║");
        Console.WriteLine($"║{$"Student Name: {fullName}",-43}║");
        Console.WriteLine($"║{$"Hometown: {city} - {state}",-43}║");
        Console.WriteLine($"║{$"Favorite color: {favColor}",-43}║");
        Console.WriteLine($"║{$"Dream Job: {dreamJob}",-43}║");
        Console.WriteLine($"║{"",-43}║");
        Console.WriteLine($"║{$"ACADEMIC INFORMATION",-43}║");
        Console.WriteLine($"║{$"___________________________________________",-43}║");
        Console.WriteLine($"║{$"Major: {major}",-43}║");
        Console.WriteLine($"║{$"GPA: {gpa}",-43}║");
        Console.WriteLine($"║{$"Year of Graduation: {gradYear}",-43}║");
        Console.WriteLine($"║{$"Full-time student? {fullTimeStudent}",-43}║");
        Console.WriteLine($"║{"",-43}║");
        Console.WriteLine($"║{$"ADDITIONAL DETAILS",-43}║");
        Console.WriteLine($"║{$"___________________________________________",-43}║");
        Console.WriteLine($"║{$"Age: {age}",-43}║");
        Console.WriteLine($"║{$"Height: {heightFeet} ft {inches} in",-43}║");
        Console.WriteLine($"║{$"Favorite number: {favNumber}",-43}║");
        Console.WriteLine($"║{"",-43}║");
        Console.WriteLine($"║{$"CALCULATED STATISTICS",-43}║");
        Console.WriteLine($"║{$"___________________________________________",-43}║");
        Console.WriteLine($"║{$"Birth year: {birthYear}",-43}║");
        Console.WriteLine($"║{$"Years untiil graduation: {yearsToGrad}",-43}║");
        Console.WriteLine($"║{$"Height in feet: {heightFeet}",-43}║");
        Console.WriteLine($"║{$"Honor Student? {honorStudent}",-43}║");
        Console.WriteLine($"║{$"Age in months: {ageMonths}",-43}║");
        Console.WriteLine("╚═══════════════════════════════════════════╝");
        Console.WriteLine("\n════════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}