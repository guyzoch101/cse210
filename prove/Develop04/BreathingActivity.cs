public class BreathingActivity : Activity {
    public BreathingActivity() {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0; // user input
    }

    public void Run() {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now; // sets the time now
        DateTime endTime = startTime.AddSeconds(_duration); // sets the end time

        do {
            Console.Write("Breathe In... "); // the counter will be displayed at the 14th character on the console
            ShowCountDown(5, 14); // parameter 14 is for clearing the counter (number only)

            Console.Write("Breathe Out... "); // the counter will be displayed at the 15th character on the console
            ShowCountDown(5, 15); // parameter 15 is for clearing the counter (number only)

        } while (DateTime.Now < endTime);

        GetActivityLog();

        Console.WriteLine();
        DisplayEndingMessage();
    }
}