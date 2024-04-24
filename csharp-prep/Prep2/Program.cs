using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string score_str = Console.ReadLine();

        /* converting the returned string into an integer */
        int score_int = int.Parse(score_str);

        string grade;
        if (score_int >= 90) {
            grade = "A";
        }
        else if (score_int >= 80 && score_int < 90) {
            grade = "B";
        }
        else if (score_int >= 70 && score_int < 80) {
            grade = "C";
        }
        else if (score_int >= 60 && score_int < 70) {
            grade = "D";
        }
        else {
            grade = "F";
        }

        Console.WriteLine($"Your grade: {grade}");

        if (score_int >= 70) {
            Console.WriteLine("Congratulations! You have passed the class.");
        }
        else {
            Console.WriteLine("Work harder! You will pass next time.");
        }
    }
}