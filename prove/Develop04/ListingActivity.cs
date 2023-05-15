class ListingActivity : Activity
{
    public ListingActivity(string name, string description) : base(name, description) { }

    public void ListingExercise()
    {
        Listing service = new Listing();
        string prompt = service.GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("List as many thoughts you'll have to the following prompt:\n");
        Console.WriteLine($"  --- {prompt} ---\n");

        Console.Write("Starting in ");
        DisplaySeconds(4);
        Console.WriteLine();

        // Reset activity duration.
        SetDuration(GetDuration());
        while (!IsActivityTimedUp())
        {
            Console.Write("> ");
            service.SaveAnswerToPrompt(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {service.AnswersByPromptSize()} items");
    }
}