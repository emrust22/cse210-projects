using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {

        string response;
        do 
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;

            while (magicNumber != guess)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
        } while (response == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}