namespace OOP_Assignment2;

public class SevensOut() : Game("Sevens Out", 20)
{
    public override void Play(Player player)
    {
        Console.WriteLine($"Welcome to {Name}!");

        while (player.Score < TargetScore)
        {
            Console.WriteLine($"Current score: {player.Score}");

            int roll = Dice.Roll() + Dice.Roll();
            Console.WriteLine($"Rolling dice...");
            Thread.Sleep(125); // Pause for 1 second
            Console.WriteLine($"You rolled: {roll}");

            if (roll == 7)
            {
                Console.WriteLine("You rolled a 7! Game Over.");
                break;
            }
            else
            {
                player.AddScore(roll);
                Console.WriteLine($"Added {roll} to your score.");
            }
        }

        Console.WriteLine($"Final score: {player.Score}");
    }
}