namespace OOP_Assignment2;

public class Player(string name)
{
    public string Name { get; private set; } = name;
    public int Score { get; set; } = 0;

    public void AddScore(int points)
    {
        Score += points;
    }
}