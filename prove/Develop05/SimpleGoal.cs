public class SimpleGoal : Goal {
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool status) 
        : base(name, description, points) {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = status;
    }

    public override int RecordEvent() {
        Console.WriteLine($"Congratulations! You have earned {_points} points.");
        _isComplete = true;

        return _points;
    }

    public override bool IsComeplete() {
        return _isComplete;
    }

    public override string GetStringRepresentation() {
        string display = $"SimpleGoal~{_shortName}~{_description}~{_points}~{_isComplete}";

        return display;
    }
}