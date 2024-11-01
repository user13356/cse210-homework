using System;

public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _steps;
    private int _stepCounter;

    public ChecklistGoal()

    {

    }

    public ChecklistGoal(string name, string description, int goalPoints, int bonusPoints, int steps, int stepCounter)

    {
        _name = name;

        _description = description;

        _goalPoints = goalPoints;

        _bonusPoints = bonusPoints;

        _steps = steps;

        _stepCounter = stepCounter;

    }

    //Sub goal
    public override void CreateChildGoal()


    {

        CreateBaseGoal();

        Console.Write("What type of reward can i give myself when i reach my goal ? ");

        string stringChecklistSteps = Console.ReadLine();

        _steps = Convert.ToInt32(stringChecklistSteps);

    
    //Give large reward based on multiple goals    
        Console.Write("How would i be rewarded if many goals are completed ? ");

        string bonusPoints = Console.ReadLine();

        _bonusPoints = Convert.ToInt32(bonusPoints);

        _stepCounter = 0;

    }

    public override bool IsComplete() 

    {

        if (_stepCounter >= _steps)

        {

            return true;

        } 
        
        else 
        
        {

            return false;

        }

    }
    
    public override void RecordEvent()

    {

        _stepCounter ++;

    }

    public override int CalculateAGP()

    {

        int points = 0;

        points = _stepCounter * _goalPoints;

        bool status = IsComplete();

        if (status == true) 

        {

            points += _bonusPoints;

        }


        return points;

    }
    // Provide detail on goal to be displayed
    public override void ListGoal()

    {

        string statusSymbol = "";

        bool status = IsComplete();

        if (status == true) 
        
        {

            statusSymbol = "X";

        } else 
        
        {

            statusSymbol = " ";

        }

        Console.Write($"[{statusSymbol}] {_name} ({_description}) -- Nothing at the moment {_stepCounter}/{_steps}");

    }

    public override string SaveGoal()

    {

        string line = "";

        line = $"ChecklistGoal:" + _name + "," + _description + "," + _goalPoints.ToString() + "," + _bonusPoints.ToString() + "," + _steps.ToString() + "," + _stepCounter.ToString();

        return line;

    }
    

}