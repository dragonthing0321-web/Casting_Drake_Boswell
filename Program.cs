using System;

class Program
{
    static void Main()
    {
        // This program asks the user for their favorite lucky number and responds with a message based on the number entered.
        Console.WriteLine("Enter your favorite lucky number please!");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            // The switch statement evaluates the user's input and provides a response based on the lucky number they entered.
            switch (number)
            {
                case 7:
                    Console.WriteLine("7 is often considered the luckiest number in many cultures!");
                    break;
                case 3:
                    Console.WriteLine("3 is a powerful number, often associated with creativity and growth!");
                    break;
                case 8:
                    Console.WriteLine("8 is a symbol of prosperity and success in many cultures!");
                    break;
                default:
                    Console.WriteLine("That's an interesting choice! Every number has its own unique charm.");
                    break;
                case 67:
                    Console.WriteLine("67? Really? What's next? 89?");
                    break;
            }
            Console.WriteLine($"Such a unique lucky number: {number}!");
        }
        else
        {
            // If the user enters an invalid input that cannot be parsed as an integer, the program will display an error message.
            Console.WriteLine("Invalid input. Please enter a valid integer.");

        }
        // This part of the program asks the user whether they think cats are better than dogs and responds accordingly.
        Console.WriteLine("Cats are better than dogs (true/false)");
        if (bool.TryParse(Console.ReadLine(), out bool catsAreBetter))
        {
            if (catsAreBetter)
            {
                Console.WriteLine("You are a cat person!");
            }
            else
            {
                Console.WriteLine("You are a dog person!");
            }
        }
        else
        {
            // If the user enters an invalid input that cannot be parsed as a boolean, the program will display an error message.
            Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");



        }
    }
}
