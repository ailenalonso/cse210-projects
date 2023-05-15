public class Reflection
{
    private List<Prompt> _promptList = new List<Prompt>();
    private List<Question> _questionList = new List<Question>();
    private List<Prompt> _promptHistory = new List<Prompt>();
    private List<Question> _questionHistory = new List<Question>();

    public Reflection()
    {
        // Initializing prompts List
        this._promptList.Add(new Prompt("Think of a time when someone helped you overcome a problem."));
        this._promptList.Add(new Prompt("Think of a time when you helped someone in need."));
        this._promptList.Add(new Prompt("Think of a time when you had to overcome yourself."));
        this._promptList.Add(new Prompt("Think of a time when you felt blessed."));

        // Initializing question List
        this._questionList.Add(new Question("How can this experience help you in the future?"));
        this._questionList.Add(new Question("What were your feelings after going through this moment?"));
        this._questionList.Add(new Question("Do you think you could help someone with your experience?"));
        this._questionList.Add(new Question("Have you learned something from this situation?"));
        this._questionList.Add(new Question("Would you have done something differently?"));
        this._questionList.Add(new Question("What is your favorite thing about this experience?"));
    }

    public string GetRandomPrompt()
    {
        Prompt p = handleDuplicatedPrompt();

        //Returns the prompt as string.
        return p.GetPrompt(); 
    }

    public string GetRandomQuestion()
    {
        Question q = handleDuplicatedQuestion(); 

        // Returns the prompt as string.
        return q.GetQuestion(); 
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

    private Question handleDuplicatedQuestion()
    {
        // Restart the list.
        if (this._questionList.Count() == 0)
        {
            Console.WriteLine("We've ran out of questions. You'll receive repeated questions from now!");
            RecycleQuestionHistory();
        }

        // Gets a random question.
        int index = new Random().Next(0, this._questionList.Count() - 1);
        Question prompt = this._questionList[index];

        // Removes from the list to don't repeat it until finished.
        this._questionList.Remove(prompt);
        // Add question to history to access later.
        this._questionHistory.Add(prompt);

        return prompt;
    }

    private void RecyclePromptHistory()
    {
        // Access to everything on the history.
        this._promptList.AddRange(this._promptHistory);
        // Clears the history.
        this._promptHistory.Clear();
    }

    private void RecycleQuestionHistory()
    {
        // Access to everything on the history.
        this._questionList.AddRange(this._questionHistory);
        // Clears the history.
        this._questionHistory.Clear();
    }
}