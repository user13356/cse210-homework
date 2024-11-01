using System;

class Program

{

    //Excercise values from August 2024
    static void Main(string[] args)

    {

        List<Exercise> exerciseList = new List<Exercise>();
        
        Running running = new Running("August 22, 2024", 20, 2);

        exerciseList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("August 25, 2024", 45, 10);

        exerciseList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("August 27, 2024", 12, 10);

        exerciseList.Add(swimming);

        Console.WriteLine("Exercises:");

        Console.WriteLine();

        foreach (Exercise exercise in exerciseList)
        
        {

            Console.WriteLine(exercise.GetSummary());

        }

    }

}
