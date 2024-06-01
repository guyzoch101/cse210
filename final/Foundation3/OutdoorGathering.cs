public class OutdoorGathering : Event {
    private string _weather;
    private string _eventType;

    public OutdoorGathering(string eventTitle, string description, string date, string time, Address address, string weather)
        : base(eventTitle, description, date, time, address) {
        _weather = weather;
        _eventType = "Outdoor Gathering";
    }

    public string GetWeatherStatement() {
        return _weather;
    }

    public void DisplayFullDetails() {
        Console.WriteLine($"Type: {_eventType}");
        DisplayStandardDetails();
        Console.WriteLine(GetWeatherStatement());
    }
}