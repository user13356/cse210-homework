using System;
using System.Threading;

public class Activity

{
    private string _name;

    private string _description;

    private int _duration;

    public void SetName(string name) => _name = name;

    public void SetDescription(string description) => _description = description;

    public void SetDuration(int duration) => _duration = duration;

    public int GetDuration() => _duration;

    protected DateTime GetFutureTime(int durationInSeconds)

    {

        return DateTime.Now.AddSeconds(durationInSeconds);

    }

    protected DateTime GetCurrentTime()

    {

        return DateTime.Now;

    }

    protected void GenerateCountdownTimer(int seconds = 5)

    {

        for (int i = seconds; i > 0; i--)

        {

            Console.Write(i + "...");

            // Wait for 1 second
            Thread.Sleep(1000);

            // Clear the console for the next count 
            Console.Clear();

        }

        Console.WriteLine("Time's up!");

    }

    protected void GenerateSpinner(int seconds)

    {

        string spinner = "|/-\\";

        // Adjust for spinner speed
        for (int i = 0; i < seconds * 5; i++)

        {

            Console.Write(spinner[i % spinner.Length]);
            Console.Write("\r");
            Thread.Sleep(450);

        }

        Console.WriteLine();

    }


    public void RunActivity()

    {

        // Code to run the activity

    }

    public void EndActivity()

    {

        // Code to end the activity

    }
    
}