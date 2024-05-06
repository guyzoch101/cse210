using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Student object
        Student me = new Student();
        me._name = "Bob";
        me._studentId = 12345;

        // Create 3 Assignment objects
        Grade grade1 = new Grade();
        grade1._assignmentName = "W01 Prove: Developer - C# Programming";
        grade1._grade = 95;

        Grade grade2 = new Grade();
        grade2._assignmentName = "W02 Prove: Developer - Journal";
        grade2._grade = 85;

        Grade grade3 = new Grade();
        grade3._assignmentName = "W03 Prove: Developer - Scripture Memorizer";
        grade3._grade= 100;

        // Put all 3 Assignment objects into the Student object we already created
        me._grades.Add(grade1);
        me._grades.Add(grade2);
        me._grades.Add(grade3);

        // Display the student (which will also display the grades)
        me.Display();

    }
}