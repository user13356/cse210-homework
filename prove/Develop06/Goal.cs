using System;

public class Goal

{
    
    protected string _name;

    protected string _description;

    protected int _goalPoints;

    protected bool _status;

    public Goal() 

    {

        _name = "Testing Name";

        _description = "Output description";

        _goalPoints = 50;

        _status = false;

    }

    public Goal(string name, string description, int goalPoints)

    {
        _name = name;

        _description = description;

        _goalPoints = goalPoints;

    }

    //Create and start goal
    protected void CreateBaseGoal() 

    {   

        Console.Write("Please provide description of goal to enter ? ");

        _name = Console.ReadLine();
        
        Console.Write("Provide reduced lengh of goal ? ");

        _description = Console.ReadLine();
        
        Console.Write("How many points do i receive for goal ? ");

        string stringGoalPoints = (Console.ReadLine());

        _goalPoints = Convert.ToInt32(stringGoalPoints);

        _status = false;

    }
    // String for creating goal
    public virtual string SaveGoal()

    {

        string line = "";

        return line;

    }
    //Public void sub goal creation
    public virtual void CreateChildGoal()

    {


    }

    public virtual void RecordEvent() 

    {


    }


    public virtual bool IsComplete() 

    {

        return false;

    }

    public virtual void ListGoal()
    
    {


    }


    public virtual int CalculateAGP()

    {
        return 0;

    }

}