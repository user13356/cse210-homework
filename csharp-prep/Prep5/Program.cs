using System;

class Program
{
    static void Main(string[] args)
    //Program with multiple functions.
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResults(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to multiple functions program Prep5!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter first name: ");
        string name = Console.ReadLine();


        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter most favourable number of choice: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;

    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, your number squared is {square}: ");
    }
    
}