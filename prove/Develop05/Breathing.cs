using System;

public class BreathingExercise : Activity

{
    public BreathingExercise()

    {

        SetName("Breathing Exercise");

        SetDescription("Thank you for taking the time to use the program to calm your spirit and open your mind to new clear thoughts.");

    }

    public void StartBreathingExercise()

    {
        DateTime futureTime = GetFutureTime(GetDuration());

        DateTime currentTime = DateTime.Now;

        Console.WriteLine("\nLet's begin the breathing exercise.");

        while (currentTime < futureTime) 

        {

            Console.WriteLine();
            Console.Write("Inhale... ");

            // Duration for inhalation
            GenerateCountdownTimer(2); 

            Console.WriteLine("Hold... ");

            // Delay for holding breath
            GenerateCountdownTimer(2); 

            Console.Write("Exhale... ");

            // Duration for exhalation
            GenerateCountdownTimer(2); 

            Console.WriteLine();

            Console.Write("Inhale... ");

            // Duration for inhalation
            GenerateCountdownTimer(2); 

            Console.WriteLine("Hold... ");

            // Delay for holding breath after exhale
            GenerateCountdownTimer(2); 

            Console.Write("Exhale... ");

            // Duration for exhalation
            GenerateCountdownTimer(2); 

            // Update current time after each cycle
            currentTime = DateTime.Now; 

        }

        Console.WriteLine("Well done! You've completed the breathing exercise.");

    }

    private void GenerateCountdownTimer(int seconds)

    {
        for (int i = seconds; i > 0; i--)

        {

            // Display the countdown number    
            Console.Write($"{i} "); 

            // Show spinner for 2 second per countdown
            GenerateSpinner(2); 

        }

        // Move to the next line after countdown
        Console.WriteLine(); 

    }

    private void GenerateSpinner(int duration)

    {

        string[] spinner = new string[] { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        int spinnerIndex = 0;

        while (DateTime.Now < endTime)

        {
            // Display current spinner frame
            Console.Write(spinner[spinnerIndex]); 

            // Move cursor back
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); 

            // Sleep for 500 milliseconds
            System.Threading.Thread.Sleep(500); 

            // Update spinner index
            spinnerIndex = (spinnerIndex + 1) % spinner.Length; 
        }

        Console.WriteLine(); 

    }
}