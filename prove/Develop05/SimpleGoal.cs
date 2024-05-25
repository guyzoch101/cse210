public class SimpleGoal : Goal {
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points) {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public override int RecordEvent() {
        Console.WriteLine($"Congratulations! You have earned {_points} points.");
        _isComplete = IsComeplete();

        return _points;
    }

    public override bool IsComeplete() {
        return true;
    }

    public override string GetStringRepresentation() {
        string display = $"SimpleGoal~{_shortName}~{_description}~{_points}~{_isComplete}";

        return display;
    }
}