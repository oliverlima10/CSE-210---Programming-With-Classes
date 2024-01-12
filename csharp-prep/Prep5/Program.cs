using System;

class Program
{

    static void Main(string[] args)
    {
       DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayMessage(userName, squaredNumber); 
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program")
    }

    static void PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ")
        int number = int.Parse(Console.ReadLine());

        return number; 
    }

    static int SquareNumber(int number)
    {
        int square = number * number ;

        return number;
    }

    static void DisplayMessage(string name, int square)

    {
        Console.WriteLine($"{name}, the square of your number is {square}")
    }

}