using System;

class Question6
{
    static void Main()
    {
        // Prompt user for input
        Console.Write("Enter a number: ");

        // Read user input as a string
        string userInput = Console.ReadLine();

        // Parse the input to a double
        if (double.TryParse(userInput, out double number))
        {
            // Output the entered number
            Console.WriteLine($"You entered: {number}");

            // Check whether the number is positive, negative, or zero
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
