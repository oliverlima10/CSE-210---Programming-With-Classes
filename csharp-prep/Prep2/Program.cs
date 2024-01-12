using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, write your percentage grade here: ");
        string userValue = Console.ReadLine();
        int grade = int.Parse(userValue);

        if (grade >= 90)
        {
            if (grade >= 95)
            {
                Console.WriteLine("Your grade is A+");
            }
            else
            {
                Console.WriteLine("Your grade is A-");
            }
        }
        else if (grade >= 80 && grade < 90)
        {
            if (grade >= 85 && grade < 90)
            {
                Console.WriteLine("Your grade is B+");
            }
            else
            {
                Console.WriteLine("Your grade is B-");
            }
        }
        else if (grade >= 70 && grade < 80)
        {
            if (grade >= 75 && grade < 80)
            {
                Console.WriteLine("Your grade is C+");
            }
            else
            {
                Console.WriteLine("Your grade is C-");
            }
        }
        else if (grade >= 60 && grade < 70)
        {
            if (grade >= 65 && grade < 70)
            {
                Console.WriteLine("Your grade is D+");
            }
            else
            {
                Console.WriteLine("Your grade is D-");
            }
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }
        


    }
}