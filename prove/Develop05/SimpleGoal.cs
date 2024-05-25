public class SimpleGoal : Goal {
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points) {
        _shortName = name;
        _description = description;
        _points = 0;
        _isComplete = false;
    }

    public override int RecordEvent() {
        return -1;
    }

    public override bool IsComeplete() {
        return true;
    }

    public override string GetStringRepresentation() {
        return "Simple Goal";
    }
}