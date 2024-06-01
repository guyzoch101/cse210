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

        Console.WriteLine();

        // Reception Event
        Address addressReception = new Address("421 Wembley Street", "London", "England", "UK");
        Reception reception = new Reception("23/24 FA Cup Finals Party", "Man Utd vs Man City", "5/25/2024", "15:00", addressReception, "manutd.fansclub@gmail.com");

        // Display details
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayFullDetails();
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription(reception.GetType().ToString()));
    }
}