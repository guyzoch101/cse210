public class Swimming : Activity {
    private int _lap;

    public Swimming(string date, double lengthMin, int lap)
        : base(date, lengthMin) {
        _name = "Swimming";
        _lap = lap;
    }

    public override double GetDistance() {
        _distanceKm = _lap * 50 / 1000;

        return _distanceKm;
    }

    public override double GetSpeed() {
        _speed = GetDistance() / _lengthMin * 60;

        return Math.Round(_speed, 2);
    }

    public override double GetPace() {
        _pace = _lengthMin / GetDistance();

        return Math.Round(_pace, 2);
    }

    public override string GetStoredForm() {
        string storedString = $"{_date} {_name} ({_lengthMin} min) - No. of laps {_lap}";

        return storedString;
    }
}