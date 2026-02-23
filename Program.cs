using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your favorite lucky number please!");
        if(int.TryParse(Console.ReadLine(), out int number))
        {
            switch(number)
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
            Console.WriteLine("Invalid input. Please enter a valid integer.");

        }
        Console.WriteLine("Do you have any other lucky numbers? (yes/no)");
        string response = Console.ReadLine().Trim().ToLower();
        {   if (response == "yes")
            {
                Console.WriteLine("Please enter your other lucky numbers!");
                string[] luckyNumbers = Console.ReadLine().Split(',');
                Console.WriteLine("Your other lucky numbers are very lucky! Here they are!");
                foreach (string luckyNumber in luckyNumbers)
                {
                    Console.WriteLine(luckyNumber.Trim());
                }
            }
            else
            {
                Console.WriteLine("Thank you for sharing your lucky number!");
            }
             
        }
    }
}