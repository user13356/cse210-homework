using System;

class Program
{
    static void Main(string[] args)
    {
        // User input number below to guess magic number.

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess !=magicNumber)

        {
            Console.Write("Guess a number? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You found the magic number! Well done.");
            }
            
        }
    }
}