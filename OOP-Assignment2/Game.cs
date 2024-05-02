namespace OOP_Assignment2;

public abstract class Game
{
    protected string Name;
    protected int TargetScore;

    public Game(string name, int targetScore)
    {
        this.Name = name;
        this.TargetScore = targetScore;
    }

    public abstract void Play(Player player);
}