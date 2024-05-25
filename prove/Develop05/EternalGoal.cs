public class EternalGoal : Goal {
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override int RecordEvent() {
        Console.WriteLine($"Congratulations! You have earned {_points} points.");

        return _points;
    }

    public override bool IsComeplete() {
        return false;
    }

    public override string GetStringRepresentation() {
        string display = $"EternalGoal~{_shortName}~{_description}~{_points}";

        return display;
    }
}