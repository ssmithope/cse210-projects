public class User
{
    public string Name { get; set; }
    public int Score { get; set; }
    public int Level { get; set; }

    public User(string name)
    {
        Name = name;
        Score = 0;
        Level = 1;
    }

    public void AddPoints(int points)
    {
        Score += points;
        if (Score >= Level * 1000)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        Level++;
        Console.WriteLine($"Congratulations, {Name}! You've leveled up to Level {Level}!");
    }
}