using System; 

public class Prompt
{
    public List<string>_prompts; 
    public Prompt()
    {
        _prompts = new List<string> () 
        {
        "What makes me feel blessed today?",
        "One thing that makes me smile today",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        };
    }

    public string GetRandomPrompt()
    {
                var random = new Random();
        int index = random.Next(_prompts.Count);
        return (_prompts[index]);
    }
}