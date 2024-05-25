using System.Diagnostics.Contracts;

public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points) {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent() {
        Console.WriteLine($"Congratulations! You have earned {_points} points.");
        _amountCompleted += 1;

        if (_amountCompleted == _target) {
            int totalPointsRewarded = _points + _bonus;
            return totalPointsRewarded;
        }

        return _points;
    }

    public override bool IsComeplete() {
        if (_amountCompleted == _target) {
            _isComplete = true;
        }
        else {
            _isComplete = false;
        }

        return _isComplete;
    }

    public void StatusLoader(bool status) {
        _isComplete = status;
    }

    public override string GetDetailsString() {
        string display = $"{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}"; // need update on current completed number
        return display;
    }

    public override string GetStringRepresentation() {
        string display = $"ChecklistGoal~{_shortName}~{_description}~{_points}~{_bonus}~{_target}~{_amountCompleted}"; // need update on current completed number

        return display;
    }
}