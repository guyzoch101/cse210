public class ReflectingActivity : Activity {
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    public ReflectingActivity() {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;
    }

    public void Run() {
        DisplayStartingMessage();

        DisplayPrmopt();
        ShowSpinner(5);

        DateTime startTime = DateTime.Now; // sets the time now
        DateTime endTime = startTime.AddSeconds(_duration); // sets the end time

        do {
            DisplayQuestions();
            ShowCountDown(15, 0); // parameter 0 is for clearing the counter (number only)

        } while (DateTime.Now < endTime);

        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt() {
        string randomPrompt = "";
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random random = new Random();
        List<int> generatedNumbers = new List<int>(); // a list to keep track which prompt has been used

        // generate a random index within the range of the list's indices
        int randomIndex = random.Next(_prompts.Count);

        if (generatedNumbers.Count == 4) { // 4 items in the list means that all prompts have been used once
            generatedNumbers.Clear(); // start the process all over
        }

        if (!generatedNumbers.Contains(randomIndex)) { // will not return a repeated prompt
            randomPrompt = _prompts[randomIndex];
            generatedNumbers.Add(randomIndex);
        }

        return randomPrompt;
    }

    public string GetRandomQuestion() {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        
        Random random = new Random();

        // generate a random index within the range of the list's indices
        int randomIndex = random.Next(_questions.Count);
        string randomQuestion = _questions[randomIndex];

        return randomQuestion;
    }

    public void DisplayPrmopt() {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions() {
        Console.WriteLine(GetRandomQuestion());
    }
}