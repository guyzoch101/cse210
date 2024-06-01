public class Reception : Event {
    private RSVP _registration;

    public Reception(string eventTitle, string description, string date, string time, Address address, RSVP registration)
        : base(eventTitle, description, date, time, address) {
        _registration = registration;
    }

    public string GetInvitationEmail() {
        return "";
    }

    public string GetFullDetails() {
        return "";
    }
}