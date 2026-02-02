namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.WriteLine($"\nHello, {userName}! Welcome to Calculator Lite!\n");

        string decPrecision;

        do
        {
            Console.Write("Use decimal precision? (yes/no): ");
            decPrecision = Console.ReadLine().Trim().ToLower();

            if (decPrecision != "yes" && decPrecision != "no")
            {
                Console.Write("Invalid input.\n");
            }
        }
        while (decPrecision != "yes" && decPrecision != "no");

        bool showDecimals = decPrecision == "yes";

        // show decimals? if yes : if no
        string dec = showDecimals ? "F2" : "F0";

        double num1;
        double num2;

        if (showDecimals)
        {
            Console.Write("Enter the first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = double.Parse(Console.ReadLine());
        }
        else
        {
            Console.Write("Enter the first number: ");
            num1 = (double)int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = (double)int.Parse(Console.ReadLine());
        }



        // just for checking values entered
        Console.WriteLine();
        Console.WriteLine("=============================================");
        Console.WriteLine($"Decimal precision enabled: {decPrecision}");
        Console.WriteLine($"Number 1: {num1}");
        Console.WriteLine($"Number 2: {num2}");
        Console.WriteLine("=============================================");
        Console.WriteLine();

        Console.WriteLine("=== Results === ");
        Console.WriteLine();

        int count = 0;

        // operations
        double sum = num1 + num2;
        double subtraction = num1 - num2;
        double multiplication = num1 * num2;
        double division = num1 / num2;
        double modulus = num1 % num2;
        double average = (num1 + num2) / 2;
        double percentDif = ((num1 - num2) / num1) * 100;

        Console.WriteLine($"Sum: {num1.ToString(dec)} + {num2.ToString(dec)} = {sum.ToString(dec)}");
        count++;
        Console.WriteLine($"Subtraction: {num1.ToString(dec)} - {num2.ToString(dec)} = {subtraction.ToString(dec)}");
        count++;
        Console.WriteLine($"Multiplication: {num1.ToString(dec)} * {num2.ToString(dec)} = {multiplication.ToString(dec)}");
        count++;

        if (num2 == 0)
        {
            Console.WriteLine($"Division: Cannot divide by zero.");
        }
        else
        {
            Console.WriteLine($"Division: {num1.ToString(dec)} / {num2.ToString(dec)} = {division.ToString(dec)}");
            count++;
        }

        if (num2 == 0)
        {
            Console.WriteLine($"Modulus: Cannot divide by zero.");
        }
        else
        {
            Console.WriteLine($"Modulus: {num1.ToString(dec)} % {num2.ToString(dec)} = {modulus.ToString(dec)}");
            count++;
        }

        Console.WriteLine($"Average : ({num1.ToString(dec)} + {num2.ToString(dec)}) / 2 = {average.ToString(dec)}");
        count++;

        if (num1 == 0)
        {
            Console.WriteLine("Percentage difference: Cannot divide by zero.");
        }
        else
        {
            Console.WriteLine($"Percentage difference: (({num1.ToString(dec)} - {num2.ToString(dec)}) / {num1.ToString(dec)}) * 100 = {percentDif.ToString(dec)}%");
            count++;
        }

        Console.WriteLine();
        Console.WriteLine("=============================================");
        Console.WriteLine($"Performed {count} calculations for {userName}!");
        Console.WriteLine("Thank you for using Calculator Lite!");
        Console.WriteLine("=============================================");


        Console.Write("\nPress any key...");
        Console.ReadKey();

    }
}
