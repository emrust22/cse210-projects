using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentInput = Console.ReadLine();
        int grade = int.Parse(gradePercentInput);
        
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80 && grade <= 89)
        {
            letter = "B";
        }
        else if (grade >=70 && grade <= 79)
        {
            letter = "C";
        }
        else if (grade >=60 && grade <= 69)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed.");
        }
    }
}