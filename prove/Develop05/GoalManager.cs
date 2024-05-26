public class GoalManager
{
    private List<Goal> _goals;
    private User _user;

    public GoalManager(User user)
    {
        _goals = new List<Goal>();
        _user = user;
    }

    public void Start()
    {
        // Start logic.
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"User: {_user.Name}, Score: {_user.Score}, Level: {_user.Level}");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.GetName() == goalName && !goal.IsComplete())
            {
                int points = goal.RecordEvent();
                if (points > 0)
                {
                    _user.AddPoints(points);
                }
            }
        }
    }

    public void SaveGoals()
    {
        // I have to add something here. But I am unable to get it done.
        
    }

    public void LoadGoals()
    {
        // I will have to figure out, what's going one with my installation.
    }
}

