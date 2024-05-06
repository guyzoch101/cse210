public class Grade
{
    // All attributes are now private so they can't be used or modified out of this class
    private string _assignmentName;  
    private int _grade;
    private bool _waived;

    // The purpose of the constructor is to initialize all the attributes.  Some
    // of the attributes will be initialized to parameter values passed in 
    // through the constructor (when the user created the Student object)
    
    // Constructor - Initialize the assignment name and the grade provided by the user
    public Grade(string assignmentName, int grade)
    {
        _assignmentName = assignmentName;
        _grade = grade;

        // If this constructor is used, we will assume the waived flag is false
        _waived = false;
    }

    // Another Constructor - This allows the user to create object and specify the
    // assignment name, the grade, and the waived flag.
    public Grade(string assignmentName, int grade, bool waived)
    {
        _assignmentName = assignmentName;
        _grade = grade;
        _waived = waived;
    }

    // This is a getter function - it returns the value of one of the attributes
    // Sometimes we name the function GetWaive.
    public bool IsWaived()
    {
        return _waived;
    }

    // This is a setter function - it sets the value of one of the attributes
    // Sometimes we name the function SetWaive.
    public void Waive()
    {
        _waived = true;
    }

    // Another setter function to set the waived flag to false
    public void UnWaive()
    {
        _waived = false;
    }

    public void Display()
    {
        if (_waived)
        {
            Console.WriteLine($"{_assignmentName} - WAIVED");
        }
        else
        {
            Console.WriteLine($"{_assignmentName} - {_grade}%");
        }
    }
}