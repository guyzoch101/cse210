using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // creating a new job card with the class
        Job job1 = new Job();

        // initializing the variables
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job1.DisplayJobDetails();

        // creating a new job card with the class
        Job job2 = new Job();

        // initializing the variables
        job2._jobTitle = "System Developer";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job2.DisplayJobDetails();

        // displaying the company names
        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);
    }
}