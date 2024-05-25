using System.Diagnostics.Contracts;

public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points) {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent() {
        return _points;
    }

    public override bool IsComeplete() {
        return true;
    }

    public override string GetDetailsString() {
        string display = $"{_shortName} ({_description}) -- Currently completed: {_target}"; // need update on current completed number
        return display;
    }

    public override string GetStringRepresentation() {
        string display = $"ChecklistGoal~{_shortName}~{_description}~{_points}~{_bonus}"; // need update on current completed number

        return display;
    }
}