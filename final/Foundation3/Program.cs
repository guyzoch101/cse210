using System;

class Program
{
    static void Main(string[] args)
    {
        // Lecture Event
        Address addressLecture = new Address("256 Main Street", "Rexburg", "ID", "USA");
        Lecture lecture = new Lecture("STEM: the Future", "Importance of STEM Education", "3/3/2024", "10:00", addressLecture, "Harry Potter", 150);

        // Display details
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullDetials();
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription(lecture.GetType().ToString()));

        DisplayLineSkipper();

        // Reception Event
        Address addressReception = new Address("421 Wembley Street", "London", "England", "UK");
        Reception reception = new Reception("23/24 FA Cup Finals Party", "Man Utd vs Man City", "5/25/2024", "15:00", addressReception, "manutd.fansclub@gmail.com");

        // Display details
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayFullDetails();
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription(reception.GetType().ToString()));

        DisplayLineSkipper();

        // Outdoor Gathering Event
        Address addressOutdoorGathering = new Address("25 W 3rd N", "Salt Lake City", "Utah", "USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Independence Day Party", "Fireworks and Party Games", "7/4/2024", "17:30", addressOutdoorGathering, "Sunny and Clear");

        // Display Details
        outdoorGathering.DisplayStandardDetails();
        Console.WriteLine();
        outdoorGathering.DisplayFullDetails();
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription(outdoorGathering.GetType().ToString()));

        DisplayLineSkipper();
    }

    static void DisplayLineSkipper() {
        Console.WriteLine("==============================");
    }
}