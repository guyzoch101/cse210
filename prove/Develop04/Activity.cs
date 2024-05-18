public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity() {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage() {
        // Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("");

        // prompts for user input for the duration of an activity
        Console.Write("Enter the duration of the activity: ");
        string durationString = Console.ReadLine();
        _duration = int.Parse(durationString);

        ShowSpinner(5);
    }

    public void DisplayEndingMessage() {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed the {_name} for a duration of {_duration} seconds.");
        ShowSpinner(5);
        // Console.Clear();
    }

    public void ShowSpinner(int seconds) {

    }

    // parameter position is for the coutdown: clearing the number only after "Breathe In... " or "Breathe Out.. "
    public void ShowCountDown(int seconds, int position) {
        while (seconds >= 0) { // counts down
            Console.WriteLine(seconds);
            if (seconds != 0) {
                Thread.Sleep(1000); // does not stop for 1 second when it reaches 0
                int currentLineCursor = Console.CursorTop;
                Console.SetCursorPosition(position, currentLineCursor - 1);
            }
            
            seconds -= 1;
        }
    }
}