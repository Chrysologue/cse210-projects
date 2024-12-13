using System;

class Program
{
    static void Main(string[] args)
    {
        //To exceed requirements, I added NegativeGoal (bad habits) class 
        //to track goals that subtract points from user score.

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}