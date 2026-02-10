namespace GuessTheNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Guess the Number: Loop Trio ===\n");

        int maxNumber = ReadIntInRange("Enter max value (10-100): ", 10, 100);
        int totalRounds = ReadIntInRange("Enter number of rounds (1-3): ", 1, 3);

        int totalGuessesAcrossRounds = 0;
        Random random = new Random();

        for (int i = 1; i <= totalRounds; i++)
        {
            Console.WriteLine($"\n Round {i}");
            int secretNumber = random.Next(1, maxNumber + 1);
            int currentGuess = 0;
            int roundGuesses = 0;

            while (currentGuess != secretNumber)
            {
                Console.Write($"Guess a number between 1 and {maxNumber}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out currentGuess))
                {
                    roundGuesses++;

                    if (currentGuess < secretNumber)
                    {
                        Console.WriteLine("Too low!");
                    }
                    else if (currentGuess > secretNumber)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else
                    {
                        Console.WriteLine($"Correct! You got it in {roundGuesses} guesses!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            totalGuessesAcrossRounds += roundGuesses;
        }

        Console.WriteLine("\nRESULTS");
        Console.WriteLine($"Total Guesses: {totalGuessesAcrossRounds}");
        Console.WriteLine("Thanks for playing!");
    }

    static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid = false;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out value) && value >= min && value <= max)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
            }

        } while (!isValid);

        return value;
    }
}

// TODO 1: Complete the helper method named ReadIntInRange
// Why: It avoids repeating the same input-validation code for max value and rounds.
// TODO 2: Get a valid max value (10-100) using ReadIntInRange
// Prompt: "Enter a max value (10-100): "
// Hint: int.TryParse() and range check (value >= 10 && value <= 100)
// Store result in an int named maxValue
// TODO 3: Get a valid number of rounds (1-3) using ReadIntInRange
// Prompt: "How many rounds? (1-3): "
// Hint: int.TryParse() and range check (value >= 1 && value <= 3)
// Store result in an int named rounds
// TODO 4: Use a for loop to repeat the game for each round
// Example: for (int round = 1; round <= rounds; round++)
// NOTE: The round header, secret number, and guessing loop are inside this for loop.
// TODO 5: Display the round header (inside the for loop)
// Example: Console.WriteLine($"\nRound {round} of {rounds}");
// TODO 6: Generate a secret number in the range 1..max (inclusive)
// Hint: Random random = new Random(maxValue + round);
// Hint: int secret = random.Next(1, maxValue + 1);
// NOTE: This should be inside the for loop so each round has a new secret.
// TODO 7: Initialize guess tracking variables (inside the for loop)
// Hint: int guess = 0; int guessCount = 0;
// TODO 8: Use a while loop to keep asking until the guess is correct
// Hint: while (guess != secret) { ... }
// NOTE: Everything related to a single guess goes inside this while loop.
// TODO 9: Read a guess and validate that it is a number (inside the while loop)
// Prompt: $"Guess a number (1-{maxValue}): "
// Hint: int.TryParse() and continue the loop if invalid
// Hint: if parsing fails, skip feedback and ask again
// TODO 10: Update guessCount and provide feedback (inside the while loop)
// Track guessCount and print: "Too low.", "Too high.", or
// "Correct! You got it in X guesses."
// TODO 11: Print a closing message after all rounds finish
// Example: "Thanks for playing!"
// private static int ReadIntInRange(string prompt, int min, int max)
// {
// Requirements:
// - Use a do-while loop
// - Use int.TryParse() for input
// - Repeat until the value is in range
// -- Hint: !isValid || value < min || value > max
// }
