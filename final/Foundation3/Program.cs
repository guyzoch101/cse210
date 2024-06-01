using System;

class Program
{
    static void Main(string[] args)
    {
        // lecture event
        Address addressLecture = new Address("256 Main Street", "Rexburg", "ID", "USA");
        Lecture lecture = new Lecture("STEM: the Future", "Importance of STEM Education", "3/3/2024", "10:00", addressLecture, "Harry Potter", 150);

        // Display details
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullDetials();
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription(lecture.GetType().ToString()));
    }
}