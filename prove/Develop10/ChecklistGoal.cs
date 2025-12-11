public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int count = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _count = count;
    }

    public override int RecordEvent()
    {
        _count++;
        if (_count == _target)
        {
            return Points + _bonus;
        }
        return Points;
    }

    public override bool IsComplete() => _count >= _target;

    public override string GetStatus()
    {
        return IsComplete()
            ? $"[X] Completed {_count}/{_target}"
            : $"[ ] Completed {_count}/{_target}";
    }

    public override string ToCSV()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_count}|{_target}|{_bonus}";
    }
}
