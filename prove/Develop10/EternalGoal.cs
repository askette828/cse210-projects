public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return Points; // Earn points every time
    }

    public override bool IsComplete() => false;

    public override string GetStatus()
    {
        return "[ ]";
    }

    public override string ToCSV()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }
}
