using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Console.WriteLine("What is you guess? ");
        string userGuess = Console.ReadLine();
        
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is you guess? ")
            guess = int.Parse(Console.ReadLine())

            if (guess > magicNumber)
            {
                Console.WriteLine("Try Lower");

            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Try Higher");
            }

            else
            {
                Console.WriteLine("You guessed it");

            }

        }

       



    

    }
}