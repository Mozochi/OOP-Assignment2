namespace OOP_Assignment2;

public class ThreeOrMore() : Game("Three or More", 20)
{
    public override void Play(Player player)
    {
        Console.WriteLine($"Welcome to {Name}!");

        while (player.Score < TargetScore)
        {
            Console.WriteLine($"Current score: {player.Score}");

            List<int> dice = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Rolling dice {i + 1}...");
                Thread.Sleep(125); // Pause for 1 second
                dice.Add(Dice.Roll());
            }

            Console.WriteLine($"You rolled: {string.Join(", ", dice)}");

            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int die in dice)
            {
                if (!counts.ContainsKey(die))
                {
                    counts[die] = 1;
                }
                else
                {
                    counts[die]++;
                }
            }

            bool hasThreeOrMore = false;
            foreach (int count in counts.Values)
            {
                if (count >= 3)
                {
                    hasThreeOrMore = true;
                    break;
                }
            }

            if (hasThreeOrMore)
            {
                int points = 0;
                foreach (int count in counts.Values)
                {
                    if (count == 3) points += 3;
                    else if (count == 4) points += 6;
                    else if (count == 5) points += 12;
                }

                player.AddScore(points);
                Console.WriteLine($"Added {points} to your score.");
            }
            else
            {
                Console.WriteLine("No three-of-a-kind or better. Rolling again.");
            }
        }

        Console.WriteLine($"Final score: {player.Score}");
    }
}