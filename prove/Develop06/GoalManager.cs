public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from menu: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    running = false;
                    break;
            }
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of the goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal (Bad Habit)");
        Console.Write("Which type of the goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (goalType)
        {
            case 1:
                newGoal = CreateSimpleGoal();
                break;
            case 2:
                newGoal = CreateEternalGoal();
                break;
            case 3:
                newGoal = CreateChecklistGoal();
                break;
            case 4:
                newGoal = CreateNegativeGoal();
                break;
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
        }
    }

    private Goal CreateSimpleGoal()
    {
        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal: ");
        int points = int.Parse(Console.ReadLine());

        return new SimpleGoal(name, description, points);
    }

    private Goal CreateEternalGoal()
    {
        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal: ");
        int points = int.Parse(Console.ReadLine());

        return new EternalGoal(name, description, points);
    }

    private Goal CreateChecklistGoal()
    {
        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal: ");
        int points = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, description, points, target, bonus);
    }

    private Goal CreateNegativeGoal()
    {
        Console.Write("What is the name of your bad habit: ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("How many points will you lose when you fail this habit? ");
        int points = int.Parse(Console.ReadLine());

        return new NegativeGoal(name, description, points);
    }

    private void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Name}");
        }

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());
        Goal selectedGoal = _goals[goalNumber - 1];
        selectedGoal.RecordEvent();

        if (selectedGoal is NegativeGoal)
        {
            _score -= selectedGoal.Points;
        }
        else
        {
            _score += selectedGoal.Points;
        }
        Console.WriteLine($"You have now {_score} points");
    }

    private void SaveGoals()
    {
        Console.Write("What is the file name for the goal? ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename for the goal? ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string scoreLine = reader.ReadLine();
                int loadedScore = int.Parse(scoreLine);
                _score = loadedScore;
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");
                    string goalType = parts[0].Split(':')[0];
                    string goalName = parts[0].Split(':')[1];

                    if (goalType == "SimpleGoal")
                    {
                        string description = parts[1];
                        int points = int.Parse(parts[2]);
                        bool isComplete = bool.Parse(parts[3]);
                        SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points);
                        if (isComplete)
                        {
                            simpleGoal.RecordEvent();
                        }
                        _goals.Add(simpleGoal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        string description = parts[1];
                        int points = int.Parse(parts[2]);
                        EternalGoal eternalGoal = new EternalGoal(goalName, description, points);
                        _goals.Add(eternalGoal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        string description = parts[1];
                        int points = int.Parse(parts[2]);
                        int bonus = int.Parse(parts[3]);
                        int target = int.Parse(parts[4]);
                        int amountCompleted = int.Parse(parts[5]);
                        ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, points, target, bonus);
                        for (int i = 0; i < amountCompleted; i++)
                        {
                            checklistGoal.RecordEvent();
                        }
                        _goals.Add(checklistGoal);
                    }
                    else if (goalType == "NegativeGoal")
                    {
                        string description = parts[1];
                        int points = int.Parse(parts[2]);
                        bool isComplete = bool.Parse(parts[3]);
                        NegativeGoal negativeGoal = new NegativeGoal(goalName, description, points);
                        if (isComplete)
                        {
                            negativeGoal.RecordEvent();
                        }
                        _goals.Add(negativeGoal);
                    }
                }
            }
            Console.WriteLine("Goals loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}
