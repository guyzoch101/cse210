public class Grade
{
    public string _assignmentName;
    public int _grade;

    public void Display()
    {
        Console.WriteLine($"{_assignmentName} - {_grade}%");
    }
}