using System;

public class PromptGenerator 
{
public List<string> Prompts {get; set;}

    public PromptGenerator() {
        Prompts = new List<string> 
        {
            
            "What can i improve on what i did today?",
            "What do i need to do tomorrow?",
            "What new things have my children learnt today?",
            "Write something about my wife i really appriacte:",
            "What can i do to be more healthy today?" ,
            "Did you drink enough water today ?",
            "How can i help my family be happy everyday?",

        };
    }

    //Random generate prompt

    public string GenerateRandomPrompt() {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        return Prompts[index];
    }

}