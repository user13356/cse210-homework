using System;

public class Resume
{
    public string _name;

    //List checking before use.

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //Using Job as custom data type.
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}