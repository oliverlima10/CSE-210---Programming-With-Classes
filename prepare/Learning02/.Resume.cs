using System;
using System.Collections.Generic

public class Resume 
{
    public string _givenName = "";
    public string _lastName = "";
    public List<Job>_Jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{_givenName} {_lastName}");
        Console.WriteLine("Jobs");
        foreach (Job job in _Jobs)
        {
            job.Display();
        }
    }
}