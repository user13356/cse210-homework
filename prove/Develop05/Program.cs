using System;

// Include this for Thread.Sleep
using System.Threading; 

class Program

{
    static void Main(string[] args)

    {

        string input = "";

        int breathingExerciseLog = 0;

        // Log for reflecting exercises
        int reflectingExerciseLog = 0; 

        // Log for listing exercises
        int listingExerciseLog = 0; 

        void DisplayLog()

        {

            Console.WriteLine("Exercise Event Logged - Currently Active");

            Console.WriteLine($"Breathing Exercise: {breathingExerciseLog}");

            Console.WriteLine($"Reflecting Exercise: {reflectingExerciseLog}");

            Console.WriteLine($"Listing Exercise: {listingExerciseLog}");

            Console.WriteLine();

        }

        // Use "4" for exit
        while (input != "4")

        {

            Console.Clear();

            DisplayLog();

            Console.WriteLine("++ Please select a menu option to start ++");

            Console.WriteLine("1. Begin breathing exercise");

            Console.WriteLine("2. Start reflecting exercise");

            Console.WriteLine("3. Start listing activity");

            Console.WriteLine("4. Exit");

            Console.Write("Please select one of the following options available: ");

            input = Console.ReadLine();

            switch (input)

            {

                case "1":

                    BreathingExercise breathingExercise = new BreathingExercise();

                    Console.Write("Enter the duration for the breathing exercise in seconds: ");

                    if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)

                    {

                        // Set the duration for the exercise
                        breathingExercise.SetDuration(duration);

                        Console.WriteLine($"You have selected a duration of {duration} seconds.");

                    }

                    else

                    {

                        Console.WriteLine("Invalid duration entered. Using default of 10 seconds.");

                        // Set a default duration
                        breathingExercise.SetDuration(10);

                    }

                    // Delay before starting the exercise
                    Console.WriteLine("Preparing to start the breathing exercise...");

                    Console.WriteLine("Get ready...");

                    // Wait for 3 seconds
                    Thread.Sleep(3000); 

                    breathingExercise.StartBreathingExercise();

                    // Log the exercise
                    breathingExerciseLog++;

                    break;

                case "2":

                    ReflectingActivity reflectingActivity = new ReflectingActivity();

                    Console.WriteLine("Preparing to start the reflecting exercise...");

                    // Wait for 3 seconds before starting
                    Thread.Sleep(3000); 

                    reflectingActivity.RunActivity();
                    
                    // Start the reflecting activity
                    reflectingActivity.PromptReflecting();

                    // Log the reflecting exercise 
                    reflectingExerciseLog++; 
                    break;

                case "3":

                    ListingActivity listingActivity = new ListingActivity();

                    Console.WriteLine("Preparing to start the listing activity...");

                    // Wait for 2 seconds before starting
                    Thread.Sleep(2000); 

                    // Start the listing activity
                    listingActivity.PromptListing();

                    // Log the listing exercise
                    listingExerciseLog++; 
                    break;

                case "4":

                    Environment.Exit(0);

                    break;

                default:

                    Console.WriteLine("Please enter the number of the menu option.");

                    break;

            }

            Console.WriteLine("Press Enter to continue...");

            // Wait for user input 
            Console.ReadLine(); 

        }

    }
    
}