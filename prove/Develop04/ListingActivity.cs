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

        GetRandomPrompt();
        ShowSpinner(10);
        Console.WriteLine();
        Console.WriteLine("You may list the items now.");
        string input;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        do {
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) {
                _inputs.Add(input);
            }

            _count += 1;
        } while (DateTime.Now < endTime);

        DisplayEndingMessage();
    }

    public void GetRandomPrompt() {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random random = new Random();

        // generate a random index within the range of the list's indices
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        Console.WriteLine(randomPrompt);
    }

    public List<String> GetListFromUser() {
        return _prompts;
    }
}