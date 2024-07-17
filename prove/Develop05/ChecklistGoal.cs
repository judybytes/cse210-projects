public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public ChecklistGoal(string shortName, string description, int points, int amountCompleted, int target, int bonusPoints)
        : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _points += _bonusPoints;
        }
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} - {_description}: {GetPoints()} points (Completed: {_amountCompleted}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonusPoints}";
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
}





