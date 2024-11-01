using System;

using System.IO;

public class GoalsTracker

{

    private List<Goal> _goals = new List<Goal>();

    private int _accumulatedPoints = 0;

    public int GetAccumulatedPoints() 

    {

        int points = _accumulatedPoints;
        return points;

    }

    public void SaveGoals()

    {

        string fileName = "";

        Console.Write("What is the filename? ");

        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))

        {

            int totalAGP = GetAccumulatedPoints();

            outputFile.WriteLine(totalAGP.ToString());
            
            foreach(Goal goal in _goals)

            {

                outputFile.WriteLine(goal.SaveGoal());

            }

        }

    }
    
    // Import goals to view them
    public void LoadGoals()

    {

        _goals.Clear(); 

        string fileName = "";

        Console.Write("Enter the name you want for a file? ");

        fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);


        _accumulatedPoints = Convert.ToInt32(lines[0]);

        for (int i = 1; i < lines.Count(); i++ )

        {

            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal") {

                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));

                _goals.Add(simpleGoal);             

            } 
            
            else if (parts[0] == "EternalGoal") 
            
            {

                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));

                _goals.Add(eternalGoal);

            } 
            
            else if (parts[0] == "ChecklistGoal") 

            {
                
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));

                _goals.Add(checklistGoal);

            }
        }

    }

    public void ListGoals()
    {
        Console.WriteLine("Here are the goals:");

        for (int i = 0; i < _goals.Count(); i++) 

        {

            Console.Write($"{i + 1}. ");

            _goals[i].ListGoal();

            Console.Write("\n");

        }

        Console.WriteLine();

    }

    public void addGoal(Goal goal)

    {

        _goals.Add(goal);

    }

    public int CalculateTotalAGP()

    {

        int totalAGP = _accumulatedPoints;

        foreach(Goal goal in _goals)
        
        {

            totalAGP += goal.CalculateAGP();

        }

        _accumulatedPoints = totalAGP;

        return totalAGP;

    }

    public void RecordEventInTracker()
    

    {
        string goalIndex = "";

        Console.Write("What goal did i complete when thinking about my future ? ");

        goalIndex = Console.ReadLine();

        int goalIndexInt = Convert.ToInt32(goalIndex) - 1;

        if (_goals[goalIndexInt].IsComplete() == false) 

        {

            _goals[goalIndexInt].RecordEvent();

            int pointsEarned = _goals[goalIndexInt].CalculateAGP();

            _accumulatedPoints += pointsEarned;

            Console.WriteLine($"Great work getting your goal completed {pointsEarned.ToString()} points!");
            Console.WriteLine($"Your total is {_accumulatedPoints} points");

        } 
        
        else
        
        {

            Console.WriteLine(" Goal selected been already completed.");

        }

    }

}