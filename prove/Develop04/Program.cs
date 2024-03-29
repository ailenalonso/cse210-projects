using System;

class Program
{
    static void Main(string[] args)
    {
        int opt = 0;

        // As exceeding requitemnts the program handle duplicated prompts and questions.
        while (opt != 4)
        {
            opt = Menu();
            ChooseActivities(opt);

        }
    }

    static int Menu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflecting activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Quit");
        Console.Write("Select a choice from the menu: ");

        return int.TryParse(Console.ReadLine(), out int i) ? i : 4;
    }

    static void ChooseActivities(int option)
    {
        switch (option)
        {
            case 1:
                {
                    BreathingActivity bAct = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                    bAct.DisplayStartingMessage();
                    bAct.BreathingExercise();
                    bAct.DisplayClosingMessage();
                    break;
                }
            case 2:
                {
                    ReflectionActivity rAct = new ReflectionActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                    rAct.DisplayStartingMessage();
                    rAct.ReflectionExercise();
                    rAct.DisplayClosingMessage();
                    break;
                }
            case 3:
                {
                    ListingActivity lAct = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                    lAct.DisplayStartingMessage();
                    lAct.ListingExercise();
                    lAct.DisplayClosingMessage();
                    break;
                }
            default:
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
        }
    }
}