namespace OOP_Assignment2;

public class Dice
{
    private static readonly Random Random = new Random();

    public static int Roll()
    {
        return Random.Next(1, 7);
    }
}