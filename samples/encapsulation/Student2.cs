public class Student
{
    // All attributes are now private so they can't be used or modified out of this class
    private string _name;
    private int _studentId;
    private List<Grade> _grades;

    // The purpose of the constructor is to initialize all the attributes.  Some
    // of the attributes will be initialized to parameter values passed in 
    // through the constructor (when the user created the Student object)

    // Constructor - Initialize the name and student id provided by the user
    public Student(string name, int studentId)
    {
        _name = name;
        _studentId = studentId;

        // This is not initalized by the user ... we will intialize it to an empty list
        _grades = new List<Grade>();
    }

    // Function to add new grade objects to the list.  
    public void AddGrade(Grade grade)
    {
        _grades.Add(grade);
    }

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
