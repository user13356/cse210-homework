using System;

public class Journal 

{
public List <Entry> entries;
public PromptGenerator promptGenerator;

    //Adding  input to entry
    public Journal() 
    
    {
        entries = new List<Entry>();

        //Start prompt
        promptGenerator = new PromptGenerator();
    }

    //New entry added 
    public void AddEntry() 
    
    {
        string prompt = promptGenerator.GenerateRandomPrompt();
        Console.Write("Please enter date(dd/mm/yyyy): ");
        string dateInput = Console.ReadLine();
        Console.WriteLine($"Today's Prompt: {prompt}");
        Console.Write("> ");
        string content = Console.ReadLine();
    }

    public void DisplayEntries() 
    {
        foreach (Entry entry in entries) 
        {
            entry.DisplayEntry();
        }
    }

    //Data saved to file
    public void SaveToFile() 
    {
        Console.WriteLine("Data saved to file: ");
        string filename = "je.txt";
        try
        {
            using (StreamWriter writer = new StreamWriter(filename)) 
            {
                foreach (Entry entry in entries) 
                {
                    writer.Write($"{entry.DateCreated}\n{entry.Content}");
                }
            }
            Console.WriteLine($"Journal entries saved to {filename}");
        } 

            catch (Exception e) 
        
        {
            Console.WriteLine($"Error saving entries to {filename}: {e.Message}");
        }
    }

    //Enter file name to view data.
    public void LoadFromFile() 
    {
        Console.Write("Please enter file to load data? : ");
        String filename = Console.ReadLine();
        
        {
            using (StreamReader reader = new StreamReader(filename)) 
            {
                while (!reader.EndOfStream) 
                {
                    string dateString = reader.ReadLine();
                    string content = reader.ReadLine();
                    Entry entry = new Entry(dateString, content);
                    entries.Add(entry);
                }
            } 
        }
        
        {
            Console.WriteLine($"Error loading data failed from :filename:");
        }
    }

}