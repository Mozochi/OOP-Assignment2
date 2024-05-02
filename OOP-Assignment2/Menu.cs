namespace OOP_Assignment2;

public class Menu
{
    public void Display()
    {
        Console.WriteLine("Welcome to Dice Games!");
        Console.WriteLine("1. Sevens Out");
        Console.WriteLine("2. Three or More");
        Console.WriteLine("3. Exit");
    }

    public Game SelectGame()
    {
        Console.Write("Enter your choice: ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid choice. Please enter number between 1 and 3.");
            Console.Write("Enter your choice: ");
        }

        switch (choice)
        {
            case 1:
                return new SevensOut();
            case 2:
                return new ThreeOrMore();
            default:
                Environment.Exit(0);
                return null;
        }
    }
}