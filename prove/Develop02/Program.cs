using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        //New entry
        Journal journal = new Journal();

        //Intro screen
        Console.WriteLine("Hi user, please select Journal options below to proceed");
    
        while (true) 
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            //Select action
            Console.Write("Please select an option (1-5) ");
            string choice = Console.ReadLine();

            //Calling classses, adding strings, input display.
            switch (choice) 
            {
                
                case "1":
                journal.AddEntry();
                break;

                
                case "2":
                journal.DisplayEntries();
                break;

                
                case "3":
                journal.LoadFromFile();
                break;

                
                case "4":
                journal.SaveToFile();
                break;

                
                case "5":
                Console.WriteLine("See you again soon!");
                return;

                
                default:
                Console.WriteLine("Please make new selectionn from 1-5.");
                break;
            }
        }
    }
}