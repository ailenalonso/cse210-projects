using System;

class Program
{
    static Scripture service = new Scripture();

    static void Main(string[] args)
    {
        Reference reference;
        
        // The program read a JSON file and prompts the user to choose a scripture as exeeding requirements.
        int userInput = showLibraryAndGetUserInput();
        if (userInput == 0) reference = service.ChooseRandom();
        else reference = service.ChooseOne(userInput - 1);

        continuousHidding(reference);
    }

    static int showLibraryAndGetUserInput()
    {
        service.DisplayLibrary();
        Console.WriteLine("0 — Random Scripture.\n");

        Console.Write("Please enter the desired index: ");
        string userInput = Console.ReadLine();
        if (userInput != "") return int.Parse(userInput);

        return 0;
    }

    static void continuousHidding(Reference original)
    {
        Word.getInstance().RandomlyHideWords(original);
    }
}