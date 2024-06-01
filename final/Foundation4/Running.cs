public class Running : Activity {

    public Running(string date, double lengthMin, double distanceKm)
        : base(date, lengthMin) {
        _name = "Running";
        _distanceKm = distanceKm;
    }

    public override string GetStoredForm() {
        string storedString = $"{_date} {_name} ({_lengthMin} min) - Distance {_distanceKm} km";

        return storedString;
    }
}