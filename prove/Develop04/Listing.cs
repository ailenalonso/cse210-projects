public class Listing
{
    private List<Prompt> _promptList = new List<Prompt>();
    private List<Prompt> _promptHistory = new List<Prompt>();
    private List<string> _answersByPrompt = new List<string>();

    public Listing()
    {
        this._promptList.Add(new Prompt("How do you feel blessed this week?"));
        this._promptList.Add(new Prompt("When have you felt the Holy Ghost this month?"));
        this._promptList.Add(new Prompt("what times did you feel happiness in the last month??"));
        this._promptList.Add(new Prompt("Who are some of the people who help you in your day to day?"));
        this._promptList.Add(new Prompt("What are some of your greatest strengths?"));
    }

    public string GetRandomPrompt()
    {
        Prompt p = handleDuplicatedPrompt(); 

        //Returns the prompt as string.
        return p.GetPrompt(); 
    }

    public void SaveAnswerToPrompt(string q)
    {
        this._answersByPrompt.Add(q);
    }

    public int AnswersByPromptSize()
    {
        return this._answersByPrompt.Count();
    }

    private Prompt handleDuplicatedPrompt()
    {
        // Restart the list.
        if (this._promptList.Count() == 0)
        {
            Console.WriteLine("We've run out of prompts. You'll start getting repeated ones now.");
            RecyclePromptHistory();
        }

        // Gets a random prompt.
        int index = new Random().Next(0, this._promptList.Count() - 1);
        Prompt prompt = this._promptList[index];

        // Removes from the list to don't repeat it until finished.
        this._promptList.Remove(prompt);
        // Add prompts to history to access later.
        this._promptHistory.Add(prompt);

        return prompt;
    }

    private void RecyclePromptHistory()
    {
        // Access to everything on the history.
        this._promptList.AddRange(this._promptHistory);
        // Clears the list.
        this._promptHistory.Clear();
    }
}