
GoalManager manager = new GoalManager();
int choice = 0;

while (choice != 7)
{
    Console.WriteLine("=== Eternal Quest ===");
    Console.WriteLine("1. Create New Goal");
    Console.WriteLine("2. List Goals");
    Console.WriteLine("3. Record Event");
    Console.WriteLine("4. Show Score");
    Console.WriteLine("5. Save Goals");
    Console.WriteLine("6. Load Goals");
    Console.WriteLine("7. Quit");
    Console.Write("Choose an option: ");

    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            CreateGoal();
            break;
        case 2:
            manager.ListGoals();
            break;
        case 3:
            manager.RecordEvent();
            break;
        case 4:
            manager.ShowScore();
            break;
        case 5:
            manager.SaveGoals();
            break;
        case 6:
            manager.LoadGoals();
            break;
    }

    Console.WriteLine();
}

void CreateGoal()
{
    Console.WriteLine("\nChoose goal type:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");

    Console.Write("> ");
    int type = int.Parse(Console.ReadLine());

    Console.Write("Goal Name: ");
    string name = Console.ReadLine();

    Console.Write("Description: ");
    string desc = Console.ReadLine();

    Console.Write("Points: ");
    int points = int.Parse(Console.ReadLine());

    if (type == 1)
    {
        manager.AddGoal(new SimpleGoal(name, desc, points));
    }
    else if (type == 2)
    {
        manager.AddGoal(new EternalGoal(name, desc, points));
    }
    else if (type == 3)
    {
        Console.Write("Times Needed: ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("Bonus Points: ");
        int bonus = int.Parse(Console.ReadLine());

        manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
    }

    Console.WriteLine("Goal created!\n");
}
