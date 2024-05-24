public class GoalManager {
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager() {

    }

    public void Start() {
        // Display the main menu & Display player info
        // Call:
        // CreateGoal, ListGoalDetails, SaveGoals, LoadGoals
        // RecordEvent
    }

    public void DisplayPlayerInfo() {
        // Display the points
    }

    public void ListGoalNames() {
        // Loop through the list of goals and display
        // the names: _shortName
    }

    public void ListGoalDetails() {
        // Loop through the list of goals and display the full details
        // GetDetailsString()
    }

    public void CreateGoal() {
        // Display a sub-menu to select a goal type
        // Ask for the name, description, and points
        // Ask for more if they pick checklist goal
        // Creat the object and add to the goal list
    }

    public void RecordEvent() {
        // Display a list of all of the goal names
        // Ask user to selct a goal
        // Call RecordEvent on the correct goal
        // Update the score based on the points
        // Display current points
    }

    public void SaveGoals() {
        // Ask user for a file name
        // Loop through the goals and convert each goal to a string and then save the string
    }

    public void LoadGoals() {
        // Ask user for a file name
        // Read each line of the file and split it up
        // Use the parts to re-create the Goal object
    }
}