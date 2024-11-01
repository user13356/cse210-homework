using System;

public class SimpleGoal : Goal

{
    public SimpleGoal()

    {

        _name = "Simple Goal name";

        _description = "Simple Goal Details";

        _goalPoints = 40;

        _status = false;

    }

    public SimpleGoal(string name, string description, int goalPoints, bool status)

    {
        _name = name;

        _description = description;

        _goalPoints = goalPoints;

        _status = status;

    }

    public override void CreateChildGoal()

    {

        CreateBaseGoal();

    }


    public override void RecordEvent()

    {

        if (_status == false) 

        {

            _status = true;

        } 

        else

        {

            Console.WriteLine("Please choose diffrent goal from list.");

        }

    }

    public override bool IsComplete()

    {

        if (_status == true) 

        {

            return true;

        } 

        else 

        {

            return false;

        }

    }

    public override void ListGoal()

    {

        string statusSymbol = "";

        bool status = IsComplete();

        if (status == true)

        {

            statusSymbol = "X";

        } 

        else
        
        {

            statusSymbol = " ";

        }

        Console.Write($"[{statusSymbol}] {_name} ({_description})");

    }

    
    public override int CalculateAGP()

    {

        bool status = IsComplete();

        int aGP = 0;

        if (status == true) 

        {

            aGP = _goalPoints;

        } 

        else

        {

            aGP = 0;

        }

        return aGP;

    }

    public override string SaveGoal()

    {

        string line = "";

        line = $"SimpleGoal:{_name},{_description}{_goalPoints},{IsComplete().ToString()}";

        return line;

    }

}
