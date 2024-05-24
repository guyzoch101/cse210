public abstract class Goal {
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points) {
        _shortName = shortName;
        _description = description;
        _points = 0;
    }

    public abstract int RecordEvent();

    public abstract bool IsComeplete();

    // return the details of a goal that could be shown in a list
    public virtual string GetDetailsString() {
        return "details";
    }

    // provide all of the details of a goal to save to a file
    public abstract string GetStringRepresentation();
}