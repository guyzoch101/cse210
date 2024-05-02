public class PromptGenerator {
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt() {
        _prompts.Add("A memorable event or moment.");
        _prompts.Add("An emotional moment.");
        _prompts.Add("Had any tasty food today?");
        _prompts.Add("If you could change one thing happened today, what would it be?");
        _prompts.Add("Any new goals set?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("A scripture or quote to remember.");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("Tell me anything!");

        Random random = new Random();

        // generate a random index within the range of the list's indices
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        // returns the random prompt string
        return randomPrompt;
    }
}