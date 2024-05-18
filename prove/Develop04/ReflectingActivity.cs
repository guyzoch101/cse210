public class ReflectingActivity : Activity {
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<int> _generatedNumbersPrompt = new List<int>(); // a list to keep track which prompt has been used
    private List<int> _generatedNumbersQuestion = new List<int>(); // a list to keep track which question has been used

    public ReflectingActivity() {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0; // user input
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

        // generate a random index within the range of the list's indices
        int randomIndex = random.Next(_prompts.Count);

        if (_generatedNumbersPrompt.Count == _prompts.Count) { // 4 items in the list means that all prompts have been used once
            _generatedNumbersPrompt.Clear(); // start the process all over
        }

        if (!_generatedNumbersPrompt.Contains(randomIndex)) { // will not return a repeated prompt
            randomPrompt = _prompts[randomIndex];
            _generatedNumbersPrompt.Add(randomIndex);
        }

        return randomPrompt;
    }

    public string GetRandomQuestion() {
        string randomQuestion = "";
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

        if (_generatedNumbersQuestion.Count == _questions.Count) { // 9 items in the list means that all questions have been used once
            _generatedNumbersQuestion.Clear(); // start the process all over
        }

        // generate a random index within the range of the list's indices
        if (!_generatedNumbersQuestion.Contains(randomIndex)) { // will not return a repeated question
            randomQuestion = _questions[randomIndex];
            _generatedNumbersQuestion.Add(randomIndex);
        }

        return randomQuestion;
    }

    public void DisplayPrmopt() {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions() {
        Console.WriteLine(GetRandomQuestion());
    }
}