using System;

class Program
{
    static void Main()
    {
        // Display the welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user to enter package weight and convert it to an integer
        Console.WriteLine("Please enter the package weight:");
        int weight = Convert.ToInt32(Console.ReadLine());

        // Check if the package weight is greater than 50
        if (weight > 50)
        {
            // Display error message and end the program if weight is too heavy
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt user to enter package width and convert it to an integer
        Console.WriteLine("Please enter the package width:");
        int width = Convert.ToInt32(Console.ReadLine());

        // Prompt user to enter package height and convert it to an integer
        Console.WriteLine("Please enter the package height:");
        int height = Convert.ToInt32(Console.ReadLine());

        // Prompt user to enter package length and convert it to an integer
        Console.WriteLine("Please enter the package length:");
        int length = Convert.ToInt32(Console.ReadLine());

        // Check if the sum of dimensions is greater than 50
        if (width + height + length > 50)
        {
            // Display error message and end the program if package is too big
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate the shipping quote by multiplying dimensions and weight, then dividing by 100
        double quote = ((width * height * length) * weight) / 100.0;

        // Display the quote formatted as currency with two decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

        // Thank the user for using the service
        Console.WriteLine("Thank you!");
    }
}
