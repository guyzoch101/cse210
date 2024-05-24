public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points) {
        
    }

    public override int RecordEvent() {
        return -1;
    }

    public override bool IsComeplete() {
        return true;
    }

    public override string GetDetailsString() {
        return "";
    }

    public override string GetStringRepresentation() {
        return "Checklist Goal";
    }
}