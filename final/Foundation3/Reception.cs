public class Reception : Event {
    private string _registrationEmailAddress;
    private string _eventType;

    public Reception(string eventTitle, string description, string date, string time, Address address, string registrationEmailAddress)
        : base(eventTitle, description, date, time, address) {
        _registrationEmailAddress = registrationEmailAddress;
        _eventType = "Reception";
    }

    public void DisplayFullDetails() {
        Console.WriteLine($"Type: {_eventType}");
        DisplayStandardDetails();
        Console.WriteLine($"Registration Email: {_registrationEmailAddress}");
    }
}