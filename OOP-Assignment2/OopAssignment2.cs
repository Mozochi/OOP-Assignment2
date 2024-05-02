namespace OOP_Assignment2;

public static class OopAssignment2
{
    public static void Main(string[] args)
    {
        Menu menu = new Menu();
        Player player = new Player(GetPlayerName());

        while (true)
        {
            Console.Clear();
            menu.Display();
            Game selectedGame = menu.SelectGame();
            Console.Clear();
            selectedGame.Play(player);
            DisplayFinalScore(player);
            Console.WriteLine("Press enter to play again or any other key to exit.");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                break;
            }
        }
    }

    private static string GetPlayerName()
    {
        Console.WriteLine("Welcome to Dice Games!");
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    private static void DisplayFinalScore(Player player)
    {
        Console.WriteLine($"Congratulations, {player.Name}! Your final score is: {player.Score}");
        if (player.Score >= 50)
        {
            Console.WriteLine("Wow! You are a true Dice Master!");
        }
        else if (player.Score >= 30)
        {
            Console.WriteLine("Great job!");
        }
        else
        {
            Console.WriteLine("Keep practicing!");
        }

        player.Score = 0;
        Console.WriteLine();
        Console.WriteLine("Returning to menu...");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey(true);
    }
}