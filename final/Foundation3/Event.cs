public class Event {
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string eventTitle, string description, string date, string time, Address address) {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails() { // title, description, date, time, address
        Console.WriteLine($"{_eventTitle} - {_description}");
        Console.WriteLine($"{_date} @ {_time}");
        Console.WriteLine(_address.GetFullAddress());
    }

    public string GetShortDescription(string eventType) { // event, title, date
        string shortDescription = $"{eventType} - {_description} - {_date}";
        
        return shortDescription;
    }
}