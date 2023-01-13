using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        int userNumber = -1;
        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            numbers.Add(userNumber);
        } while (userNumber!=0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}