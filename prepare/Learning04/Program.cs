using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Tristan Wong", "Motion");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Tristan Wong", "Calculus", "Section 2", "Problems 5-10");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Tristan Wong", "Personal Narrative", "Trust");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}