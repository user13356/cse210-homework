using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter Number, 0 to exit and count total: ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            //Number 0 is used for exiting program

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }


        //Count numbers with total
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The total is: {sum}");

        //Second Part Count

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Thirds Part Find Highest Number

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}