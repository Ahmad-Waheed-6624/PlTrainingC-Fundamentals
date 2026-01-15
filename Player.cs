public class Player
{
    public delegate void AchievmentWventHandler();
    public event AchievmentWventHandler? OnAchievementEvent;
    public int Points { get; set; }
    public void addpoints(int points)
    {
        Points += points;
        System.Console.WriteLine($"{points} added to the player stats");
        if (Points > 100)
        {
            OnAchievementEvent?.Invoke();
        }
    }
}