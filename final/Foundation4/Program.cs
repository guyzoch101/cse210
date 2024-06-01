using System;

class Program
{
    static void Main(string[] args)
    {
        // Running activity
        Running running = new Running("05 May 2024", 60, 20);

        // Display Details
        Console.WriteLine(running.GetStoredForm()); // all details
        Console.WriteLine(running.GetSummary()); // requested tracking details - distance

        DisplayLineSkipper();

        // Cycling activity
        Cycling cycling = new Cycling("02 Feb 2020", 40, 13.5);

        // Display Details
        Console.WriteLine(cycling.GetStoredForm()); // all details
        Console.WriteLine(cycling.GetSummary()); // requested tracking details - speed

        DisplayLineSkipper();

        // Swimming activity
        Swimming swimming = new Swimming("01 Jan 2015", 110, 65);

        // Display Details
        Console.WriteLine(swimming.GetStoredForm()); // all details
        Console.WriteLine(swimming.GetSummary()); // requested tracking details - number of laps

        DisplayLineSkipper();
    }

    static void DisplayLineSkipper() {
        Console.WriteLine("==============================");
    }
}