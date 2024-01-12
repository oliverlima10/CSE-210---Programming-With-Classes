using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a List number. Type 0 to finish");
        
        int userNumber = -1;

        while (userNumber != 0)
        {
             Console.Write("Enter with a number: ");
             string userAnswer = Console.ReadLine();
             userNumber = int.Parse(userAnswer);

             if (userNumber !=0)
             {
                numbers.Add(userNumber);
             }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The total sum is {sum}");

        float avarageNumbers = (float(sum)) / numbers.Count; 
        Console.WriteLine($"The avarage among the numbers is {avarageNumbers}")

        int maxNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine($"The max is: {maxNumber}");
        
    

    }
}