// Challenge goal class (the new class I've created).

public class ChallengeGoal : Goal
{
    private int _currentLevel;
    private readonly int _maxLevel;
    private readonly int _pointsToNextLevel;
    private readonly Dictionary<int, string> _badges;

    public ChallengeGoal(string name, int initialPoints, int maxLevel, int pointsToNextLevel) : base(name, initialPoints)
    {
        _currentLevel = 1;
        _maxLevel = maxLevel;
        _pointsToNextLevel = pointsToNextLevel;
        _badges = new Dictionary<int, string>();
        InitializeBadges();
    }

    private void InitializeBadges()
    {
        // Define badges for each level.
        _badges[1] = "Bronze";
        _badges[2] = "Silver";
        _badges[3] = "Gold";
        _badges[4] = "Platinum";
    
    }

    public override void RecordProgress()
    {
        _points += _pointsToNextLevel;
        if (_points >= _pointsToNextLevel * _currentLevel && _currentLevel < _maxLevel)
        {
            _currentLevel++;
            Console.WriteLine($"Congratulations! You've reached level {_currentLevel} and earned the {_badges[_currentLevel]} badge!");
        }
    }

    public override void Display()
    {
        Console.WriteLine($"{_name} - Level: {_currentLevel}/{_maxLevel} - Points to Next Level: {_pointsToNextLevel} - Current Badge: {_badges[_currentLevel]}");
    }
}