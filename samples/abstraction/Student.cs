public class Student
{
    public string _name;
    public int _studentId;
    public List<Grade> _grades = new List<Grade>();

    public void Display()
    {
        Console.WriteLine($"{_name} ({_studentId})");
        
        // We use this loop to go through each of the Grade objects in the List
        foreach (Grade grade in _grades)
        {
            // Call the Display function from the Grade class on each Grade object
            grade.Display();
        }
    }
}
