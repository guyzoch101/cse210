public class Cycling : Activity {

    public Cycling(string date, double lengthMin, double speed)
        : base(date, lengthMin) {
        _name = "Cycling";
        _speed = speed;
    }

    public override double GetDistance() {
        _distanceKm = _speed * 60 / _lengthMin;

        return Math.Round(_distanceKm, 2);
    }

    public override double GetSpeed() {
        return _speed;
    }

    public override double GetPace() {
        _pace = 60 / _speed;

        return Math.Round(_pace, 2);
    }

    public override string GetStoredForm() {
        string storedString = $"{_date} {_name} ({_lengthMin} min) - Speed {_speed} kph";

        return storedString;
    }
}