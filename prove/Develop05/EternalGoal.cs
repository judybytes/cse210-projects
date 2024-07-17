public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Since it's an eternal goal, we assume it doesn't get completed,
        // but you can adjust this logic as needed.
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} - {_description}: {GetPoints()} points";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }

    public override bool IsComplete()
    {
        // Eternal goals are never complete
        return false;
    }
}

