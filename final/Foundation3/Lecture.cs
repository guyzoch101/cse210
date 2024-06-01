public class Lecture : Event {
    private string _speaker;
    private int _capacity;
    private string _eventType;

    public Lecture(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity)
        : base(eventTitle, description, date, time, address) {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lecture";
    }

    public void DisplayFullDetials() {
        Console.WriteLine($"Type: {_eventType}");
        DisplayStandardDetails();
        Console.WriteLine($"Spaker: {_speaker}");
        Console.WriteLine($"Capacitty: {_capacity}");
    }
}