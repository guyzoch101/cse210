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

    public string GetStandardDetails() { // title, description, date, time, address
        return "";
    }

    public string GetShortDescription() { // event, title, date
        return "";
    }
}