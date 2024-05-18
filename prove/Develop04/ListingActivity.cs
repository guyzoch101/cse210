public class ListingActivity : Activity {
    private int _count;
    List<string> _prompts = new List<string>();
    List<string> _inputs = new List<string>();

    public ListingActivity() {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0; // user input
        _count = 0;
    }

    public void Run() {
        DisplayStartingMessage();

        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        Console.Write("You may start listing items in... "); // the counter will appear at the 34th position
        ShowCountDown(10, 34); // parameter 34 is for clearing the counter (number only)
        string input;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        do {
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) { // adds input to list and count + 1 to record input
                _inputs.Add(input);
                _count += 1;
            }
        } while (DateTime.Now < endTime);

        Console.WriteLine($"You have entered a total of {_count} items. ");

        SaveInputsToFile(randomPrompt);
        Console.WriteLine("Your responses have been saved in ListingActivityResponses.txt");
        Console.WriteLine();

        DisplayEndingMessage();
    }

    public string GetRandomPrompt() {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random random = new Random();

        // generate a random index within the range of the list's indices
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }

    public void SaveInputsToFile(string promptUsed) {
        using(StreamWriter inputsFile = new StreamWriter($"ListingActivityResponses.txt")) {
            inputsFile.WriteLine(promptUsed); // writes the prompt question as the 1st line
            inputsFile.WriteLine();

            foreach (string input in _inputs) {
            inputsFile.WriteLine(input);
            }
        }
    }
}