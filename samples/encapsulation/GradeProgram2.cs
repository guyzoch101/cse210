using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Student object
        Student me = new Student("Bob", 12345);

        // Create 3 Assignment objects
        Grade grade1 = new Grade("W01 Prove: Developer - C# Programming", 95);
        Grade grade2 = new Grade("W02 Prove: Developer - Journal", 85);
        Grade grade3 = new Grade("W03 Prove: Developer - Scripture Memorizer", 0, true);

        // Put all 3 Assignment objects into the Student object we already created
        me.AddGrade(grade1);
        me.AddGrade(grade2);
        me.AddGrade(grade3);

        // Display the student (which will also display the grades)
        me.Display();

        Console.WriteLine("--------------------------------");

        // Let's waive the first assignment
        grade1.Waive();

        // Redisply
        me.Display();

    }
}