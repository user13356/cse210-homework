using System;

class Program

{
    static void Main(string[] args)

    {

        // Add Assignment Details.
        Assignment no1 = new Assignment("Janet Vogel", "Division");
        Console.WriteLine(no1.GetSummary());


        // Add Math Assignments Details.
        MathAssignment no2 = new MathAssignment("Peter Piper", "Subtraction", "5.1", "2-16");
        Console.WriteLine(no2.GetSummary());
        Console.WriteLine(no2.GetHomeworkList());


        // Add Writingassignment Details.
        WritingAssignment no3 = new WritingAssignment("Norman Vincent Peale", "The international bestseller by the father of positive thinking", "The Power of Positive Thinking");
        Console.WriteLine(no3.GetSummary());
        Console.WriteLine(no3.GetWritingInformation());

    }
    
}