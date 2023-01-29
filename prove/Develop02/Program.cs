using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal(); 
        Prompt generator = new Prompt();

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine();
        
        int userChoice = 0;
        
        while (userChoice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display an entry");
            Console.WriteLine("3. Load entries from a file");
            Console.WriteLine("4. Save entries to a file");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            string optionSelected = Console.ReadLine();
            userChoice = int.Parse(optionSelected);
            Console.WriteLine();

            if (userChoice == 1)
            {
                //Get a new prompt and display it.
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);

                //Get the user's respond text.
                Console.Write("- ");
                string response = Console.ReadLine();

                //Get the current date and save it as string.
                DateTime currentTime =  DateTime.Now;
                string date =  currentTime.ToShortDateString();

                //Create an entry object.
                Entry theEntry = new Entry(); 
                theEntry._date = date;
                theEntry._prompt = prompt;
                theEntry._text = response;
            
                //Add it to the Journal.
                theJournal.AddEntry(theEntry);

                Console.WriteLine();
                Console.WriteLine("Your entry was saved!");
                Console.WriteLine();
                
            }
            else if (userChoice == 2)
            {
                theJournal.Display();
                Console.WriteLine();
            }
            else if (userChoice == 3)
            {
                Console.Write("What is the name of the file? ");
                string loadfile = Console.ReadLine();
                theJournal.Load(loadfile);
            }
            else if (userChoice == 4)
            {
                Console.Write("What is the name of the file? ");
                string savefile = Console.ReadLine();
                theJournal.Save(savefile);
            }
            else if (userChoice == 5) 
            {
                Console.WriteLine("Goodbye! See you tomorrow!");
                break;
            }
            else 
            {
                //not valid input
                Console.WriteLine("Please enter a valid menu number.");
                Console.WriteLine();
            }
        }
    }
}