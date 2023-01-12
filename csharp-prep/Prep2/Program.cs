using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse (gradePercentage);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine ($"Yor grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine ("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine ("I'm sorry you did not pass the coure, you will do it great next time");
        }



    }
}