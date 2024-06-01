public abstract class Activity {
    protected string _name;
    protected string _date;
    protected double _lengthMin;
    protected double _distanceKm;
    protected double _speed;
    protected double _pace;

    public Activity(string date, double lengthMin) {
        _name = "";
        _date = date;
        _lengthMin = lengthMin;
    }

    public virtual double GetDistance() {
        return Math.Round(_distanceKm, 2);
    }

    public virtual double GetSpeed() {
        _speed = _distanceKm / _lengthMin * 60;

        return Math.Round(_speed, 2);
    }

    public virtual double GetPace() {
        _pace = _lengthMin / _distanceKm;

        return Math.Round(_pace, 2);
    }
    
    public abstract string GetStoredForm();

    public string GetSummary(){
        string summaryString = $"{_date} {_name} ({_lengthMin} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km";

        return summaryString;
    }
}