using System;

public class Entry 

{
public string DateCreated {get;}
public string Content {get;}

//Input data received from user

public Entry (string dateInput, string content) 
    {
    DateCreated = dateInput;
    Content = content;
    }

    //Content of Entry displayed

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {DateCreated}");
        Console.WriteLine($"Content: {Content}\n");
    }

}