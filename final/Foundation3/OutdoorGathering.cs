public class OutdoorGathering : Event {
    private string _weather;

    public OutdoorGathering(string eventTitle, string description, string date, string time, Address address, string weather)
        : base(eventTitle, description, date, time, address) {
        _weather = weather;
    }

    public string GetWeatherStatement() {
        return "";
    }

    public string GetFullDetails() {
        return "";
    }
}