using System.IO.Enumeration;

public class GoalManager {
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _level;

    public GoalManager() {
        _score = 0;
        _level = 1;
    }

    public void Start() {
        // Display the main menu & Display player info
        // Call:
        // CreateGoal, ListGoalDetails, SaveGoals, LoadGoals
        // RecordEvent

        string choiceMenu = "";

        do {
            DisplayPlayerInfo();
        
            Console.WriteLine("Main Menu");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Exit");
            Console.Write("Select an option from the menu: ");
            choiceMenu = Console.ReadLine();

            if (choiceMenu == "1") {
                CreateGoal();
            }

            else if (choiceMenu == "2") {
                ListGoalDetails();
            }

            else if (choiceMenu == "3") {
                SaveGoals();
            }

            else if (choiceMenu == "4") {
                LoadGoals();
            }

            else if (choiceMenu == "5") {
                RecordEvent();
            }

            else if (choiceMenu == "6") {
                Console.WriteLine("Exiting... ");
            }

            else {
                Console.WriteLine("Invalid input. Please try again.");
            }

            // check for level up
            CheckLevel();
            Console.WriteLine();

        } while(choiceMenu != "6");
    }

    public void DisplayPlayerInfo() {
        // Display the user's current level and score
        Console.WriteLine($"Level {_level} : {_score} / {_level * 1000} points"); // level : xx points
    }

    public void CheckLevel() {
        // Level 1: 0-999 points
        // Level 2: 1000-1999 points
        // Level 3: 2000-2999 points
        // etc

        if (_score > _level * 1000) {
            // _level += 1 will only level up for 1 level
            // but loading multiple files may cause the level to rise for more than 1 in one round

            // if _score = 2500 -> will return 2.5 and round down to the nearest int which is 2
            _level = (int)Math.Floor((double)_score / 1000);
            Console.WriteLine($"Congratulations! You have levelled up to level {_level}.");
        }
    }

    public void ListGoalNames() {
        // Loop through the list of goals and display the names (all names from the list)
        // _shortName
        // Create GetGoalName function??

        int counter = 1;

        if (_goals.Count == 0) {
            Console.WriteLine("No goals have been entered in the system.");
            Console.WriteLine("Enter new goals or load goals that were previously entered.");
        }
        else {
            foreach (Goal goal in _goals) {
                Console.WriteLine($"    {counter}. {goal.GetGoalName()}");

                counter += 1;
            }
        }
    }

    public void ListGoalDetails() {
        // Loop through the list of goals and display the full details
        // GetDetailsString()

        int counter = 1;

        if (_goals.Count == 0) {
            Console.WriteLine("No goals have been entered in the system.");
            Console.WriteLine("Enter new goals or load goals that were previously entered.");
        }
        else {
            foreach (Goal goal in _goals) {
                if (goal.IsComeplete()) {
                    Console.WriteLine($"    {counter}. [x] {goal.GetDetailsString()}");
                }
                else {
                    Console.WriteLine($"    {counter}. [ ] {goal.GetDetailsString()}");
                }
                counter += 1;
            }
        }
    }

    public void CreateGoal() {
        // Display a sub-menu to select a goal type
        // Ask for the name, description, and points
        // Ask for more if they pick checklist goal
        // Creat the object and add to the goal list

        Console.WriteLine("Types of goals available:");
        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2. Eternal Goal");
        Console.WriteLine("     3. Checklist Goal");
        Console.Write("Select a goal type: ");
        string choiceCreateGoal = Console.ReadLine();

        // name of the goal
        Console.Write("Name of goal: ");
        string name = Console.ReadLine();

        // short description
        Console.Write("Provide a short description for the goal: ");
        string description = Console.ReadLine();

        // points
        Console.Write("Amount of points for accomplishing the goal: ");
        string pointsString = Console.ReadLine();
        int pointsInt = int.Parse(pointsString);

        if (choiceCreateGoal == "1") { // simple goal
            SimpleGoal simpleGoal = new SimpleGoal(name, description, pointsInt, false);

            _goals.Add(simpleGoal);
        }

        else if (choiceCreateGoal == "2") { // eternal goal
            EternalGoal eternalGoal = new EternalGoal(name, description, pointsInt);
            
            _goals.Add(eternalGoal);
        }

        else if (choiceCreateGoal == "3") { // chceklist goal
            Console.Write("Target of the goal (no. of times to be completed): ");
            string targetString = Console.ReadLine();
            int targetInt = int.Parse(targetString);

            Console.Write("Bonus for completing target: ");
            string bonusString = Console.ReadLine();
            int bonusInt = int.Parse(bonusString);

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, pointsInt, targetInt, bonusInt, 0, false);
            
            _goals.Add(checklistGoal);
        }

        else {
            Console.WriteLine("Invalid input. Please try again.");
        }

    }

    public void RecordEvent() {
        // Display a list of all of the goal names
        // Ask user to selct a goal
        // Call RecordEvent on the correct goal
        // Update the score based on the points
        // Display current points

        Console.WriteLine("Goals available in the system:");
        ListGoalNames();

        Console.Write("Enter the goal accomplished: ");
        string goalAccomplishedString = Console.ReadLine();
        int goalAccomplishedInt = int.Parse(goalAccomplishedString);

        // find the object from the list
        // call RecordEvent() and add points
        Goal goal = _goals[goalAccomplishedInt - 1];
        if (goal.IsComeplete()) {
            Console.WriteLine("Goal already completed. Choose another goal.");
        }
        else {
            int multiplier = 1;
            int roundScore = goal.RecordEvent();

            if (goal.GetType() != typeof(ChecklistGoal)) { // no multiplier for ChecklistGoal
                multiplier = PointsMultiplier();
            }

            int pointsRewarded = roundScore * multiplier; // _points * multiplier -> usually = 1

            if (multiplier != 1) {
                Console.WriteLine($"Congratulations! You have received a multiplier of {multiplier}x for the {roundScore} points.");
                Console.WriteLine($"Total points received: {pointsRewarded}");
            }

            _score += pointsRewarded;
        }

    }

    public int PointsMultiplier() {
        Random random = new Random();

        int multiplierDecider = random.Next(10); // generates an integer of a range from 0 to 9

        int multiplier = 1;
        if (multiplierDecider == 1) { // 10% chance to get a multiplier
            multiplier = random.Next(2, 5); // random multiplier of a range from 2 to 4
        }

        return multiplier;
    }

    public void SaveGoals() {
        // Ask user for a file name
        // Loop through the goals and convert each goal to a string and then save the string

        Console.Write("Enter a filename (without .txt) to save all goals: ");
        string filename = Console.ReadLine();

        using(StreamWriter goalsFile = new StreamWriter($"{filename}.txt")) {
            goalsFile.WriteLine(_level);
            goalsFile.WriteLine(_score);
            foreach(Goal goal in _goals) {
                goalsFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals() {
        // Ask user for a file name
        // Read each line of the file and split it up
        // Use the parts to re-create the Goal object

        Console.Write("Enter a filename (without .txt) to retrieve goals entered previously: ");
        string filename = Console.ReadLine();

        if (!File.Exists($"{filename}.txt")) { // check if the filename entered existed
            Console.WriteLine("Filename entered does not exist.");
        }
        else {
            using (StreamReader reader = new StreamReader($"{filename}.txt")) {
                string playerInfo;
                int currentLineNumber = 0;

                while ((playerInfo = reader.ReadLine()) != null) {
                    if (currentLineNumber == 0) { // line 0 (1st line) is the player's level
                        _level = int.Parse(playerInfo);
                    }
                    else if (currentLineNumber == 1) { // line 1 (2nd line) is the player's previous score
                        _score += int.Parse(playerInfo);
                        break; // proceeds to the code below to read goals
                    }

                    currentLineNumber += 1;
                }
            }

            string[] lines = System.IO.File.ReadAllLines($"{filename}.txt");

            foreach (string line in lines) {
                string[] parts = line.Split("~");
                // not needing code to skip the first 2 lines, since parts[0] of the first 2 lines do not satisfy the conditions below

                // parts[0] = goal type
                // parts[1] = _shortName
                // parts[2] = _description
                // parts[3] = _points -> converted to int

                if (parts[0] == "SimpleGoal") { // loading SimpleGoal
                    // parts[4] = _isComplete (status)
                    bool.TryParse(parts[4], out bool status);
                    SimpleGoal goalLoading = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), status);

                    // add to list
                    _goals.Add(goalLoading);
                }

                else if (parts[0] == "EternalGoal") { // loading EternalGoal
                    EternalGoal goalLoading = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));

                    // no status for EternalGoal -> will remain uncompleted even when completed

                    // add to list
                    _goals.Add(goalLoading);
                }

                else if (parts[0] == "ChecklistGoal") { // loading ChecklistGoal
                    // parts[4] = _bonus
                    // parts[5] = _target
                    // parts[6] = _amountCompleted
                    // parts[7] = _isComplete
                    bool.TryParse(parts[7], out bool status);
                    ChecklistGoal goalLoading = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]), int.Parse(parts[6]), status);
                    
                    // add to list
                    _goals.Add(goalLoading);
                }
            }
        }
    }
}