using System;

class Program

{
    static void Main(string[] args)

    {

        string menuSelected = "";

        GoalsTracker goals = new GoalsTracker();

    while (menuSelected != "6")
    
    {

        int points = goals.GetAccumulatedPoints();

        Console.WriteLine($"My total {points} points.");

        Console.WriteLine();

        Console.WriteLine("+=+=+ Menu Options +=+=+:");

        Console.WriteLine("  1. Please enter new goal");

        Console.WriteLine("  2. Show saved Goals");

        Console.WriteLine("  3. Entered Goals");

        Console.WriteLine("  4. Retrieved saved Goals");

        Console.WriteLine("  5. Capture current Event");

        Console.WriteLine("  6. Exit");

        Console.Write("Please select a menu option: ");

        menuSelected = Console.ReadLine();

        switch (menuSelected) 

        {

            case "1":

                Console.WriteLine("Diffrent Goals : ");

                Console.WriteLine("  1. Simple to do Goal");

                Console.WriteLine("  2. Eternal life Goal");

                Console.WriteLine("  3. Checklist Goal");

                Console.Write("How can i assit to create a new goal ? ");

                string goalType = Console.ReadLine();

                switch (goalType) 

                {

                    case "1":

                        SimpleGoal newSimpleGoal = new SimpleGoal();

                        newSimpleGoal.CreateChildGoal();

                        goals.addGoal(newSimpleGoal);

                        break;
                    
                    case "2":

                        EternalGoal newEternalGoal = new EternalGoal();

                        newEternalGoal.CreateChildGoal();

                        goals.addGoal(newEternalGoal);

                        break;

                    case "3":

                        ChecklistGoal newChecklistGoal = new ChecklistGoal();

                        newChecklistGoal.CreateChildGoal();

                        goals.addGoal(newChecklistGoal);

                        break;
                    
                    default:

                        Console.WriteLine("Goal error. Please enter again.");

                        break;

                }

                break;

            case "2":

                goals.ListGoals();

                break;

            case "3":

                goals.SaveGoals();

                break;

            case "4":

                goals.LoadGoals();

                break;

            case "5":

                goals.RecordEventInTracker();

                break;

            case "6":

                Environment.Exit(0);

                break;

            default:

                Console.WriteLine("Please select correct menu option.");

                break;

            }

        }

    }

}
