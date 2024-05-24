public class EternalGoal : Goal {
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {
        
    }

    public override int RecordEvent() {
        return -1;
    }

    public override bool IsComeplete() {
        return true;
    }

    public override string GetStringRepresentation() {
        return "Eternal Goal";
    }
}