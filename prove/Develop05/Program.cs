using System;

// added a few features to check for exceptions for filenames
// added a level up feature which levels up every 1000 points
// added features which allow users to load multiple files and add the points
// added a random int generator which grants users a 10% chance to receive a 2-4x multiplier for the points earned for that goal
// * not aplicable to ChecklistGoal

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start(); // calling Start() to start everything
    }
}