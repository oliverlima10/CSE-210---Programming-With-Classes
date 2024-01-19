using System;
using System.Collections.Generic

class Program
{
    static void Main(string[] args)
    {

        Resume resume = new Resume();

        resume ._givenName = "Oliver"
        resume .lastName = "Lima"

        Job job1 = new Job();
        
        job1 ._jobTitle = "Software Engineer";
        job1 ._company = "Apple";
        job1 ._startYear = "2002";
        job1 ._endYear = "2022";
        
        Job job2 = new Job();

        job2 ._jobTitle = "Compute Programer";
        job2 ._company = "Microsoft";
        job2 ._startYear = "2022";
        job2 ._endYear = "2023";

        resume.Jobs.Add(job2);
        resume.Jobs.Add(job1);
        resume.Display();
        
    }
}