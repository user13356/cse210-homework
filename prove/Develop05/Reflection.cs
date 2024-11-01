using System;

using System.Collections.Generic;

public class ReflectingActivity : Activity

{

    private List<string> _prompts = new List<string> 

    { 

        "Reflect on a time you made a tough decision. What led you to that choice?",

        "Think of a moment when you learned something valuable from failure. What was it?",

        "Recall an instance when you had to adapt to a significant change. How did you cope?",

        "Consider a situation where you took a stand for your beliefs. What motivated you?",

        "Reflect on a time when you helped someone achieve their goal. How did it make you feel?",

        "Think about a challenge that pushed you out of your comfort zone. What did you discover about yourself?",

        "Recall a moment when you had to work as part of a team. What role did you play?",

        "Consider an experience that sparked a new passion or interest in your life. What was it?",

        "Think about a time when you felt truly proud of yourself. What led to that feeling?",

        "Reflect on a moment when you learned from someone else's perspective. What insights did you gain."

    };

    private List<string> _questions = new List<string> 

    {

        "What emotions did you experience during this event?",

        "How did this experience shape your understanding of yourself?",

        "What lessons did you learn that you can apply in the future?",

        "In what ways did this experience challenge your beliefs or values?",

        "How did your actions in this situation impact others around you?",

        "What would you do differently if faced with a similar situation again?",

        "What skills did you develop as a result of this experience?",

        "How has this experience influenced your relationships with others?",

        "What do you wish you had known before this experience?",

        "How can you use what you've learned in your current or future endeavors?"

    };

    public ReflectingActivity()

    {

        SetName("Reflecting Activity");

        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

    }

    public string GeneratePrompt()

    {

        Random random = new Random();

        int index = random.Next(0, _prompts.Count);

        return _prompts[index];

    }

    public string GenerateQuestion()

    {

        Random random = new Random();

        int index = random.Next(0, _questions.Count);

        return _questions[index];

    }

    public void PromptReflecting()

    {   
        string prompt = GeneratePrompt();

        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");

        Console.WriteLine();

        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();

        Console.WriteLine("Take a moment to think. When you're ready, press enter to enter your response.");

        Console.ReadLine(); 
        
        // User response
        Console.Write("Your response: ");

        string userResponse = Console.ReadLine();

        Console.WriteLine("Thank you for sharing your thoughts!");

        // You can save or process the user response here
        Console.WriteLine($"You entered: {userResponse}");

        Console.WriteLine();

        DateTime futureTime = GetFutureTime(GetDuration());

        DateTime currentTime = DateTime.Now;
        
        while (currentTime < futureTime)

        {

            string question = GenerateQuestion();

            Console.Write(question + " ");

            GenerateSpinner(15); 
            Console.WriteLine();

            // Update current time
            currentTime = DateTime.Now;

        }

    }

}