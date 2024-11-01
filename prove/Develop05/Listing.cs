using System;

using System.Collections.Generic;

public class ListingActivity : Activity

{
    private List<string> _prompts = new List<string>

    {

        "Who are people that you appreciate?",

        "What are personal strengths of yours?",

        "Who are people that you have helped this week?",

        "When have you felt the Holy Ghost this month?",

        "Who are some of your personal heroes?",

        "What are some attributes that you admire in others?",
        
        "When was the last time you felt a deep sense of gratitude?",

    };

    // To store user responses
    private List<string> _responses; 

    public ListingActivity()

    {

        SetName("Listing Activity");

        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        
        // Initialize the responses list
        _responses = new List<string>();

    }

    public string GeneratePrompt()

    {

        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];

    }

    public void PromptListing()

    {

        string prompt = GeneratePrompt();

        Console.WriteLine();

        Console.WriteLine("List as many responses as you can to the following prompt:");

        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("Type 'exit' when you are done.");

        while (true)

        {

            Console.Write("> ");

            string response = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(response))

            {

                Console.WriteLine("Empty response ignored. Please enter a response or type 'exit' to finish.");

                // Ask for input again
                continue; 

            }

            if (response.ToLower() == "exit")

            {

                // Exit the loop if the user types "exit"    
                break; 

            }
            
            // Add response to the list
            _responses.Add(response); 

        }

        // After the user finishes inputting responses
        Console.WriteLine($"You listed {_responses.Count} responses. Great job!");

        Console.WriteLine("Your responses were:");

        foreach (var resp in _responses)

        {

            // Display each response
            Console.WriteLine($"- {resp}");

        }

    }

}