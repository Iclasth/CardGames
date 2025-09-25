using CardGames.Models;
using PickRandomCards.Models;

while (true)
{
    Console.WriteLine("Welcome to Card Games!");
    Console.WriteLine("Choose a game to play:");
    Console.WriteLine("1. Simplified Blackjack");
    Console.WriteLine("2. Pife");
    Console.WriteLine("3. Exit");
    Console.Write("Enter the number of your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            
            SimplifyBlackJack.PlaySimplifiedBlackJack();
            break;
        case 2:
            Pife.PlayPife();
            break;
        case 3:
            Console.WriteLine("Exiting the game. Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}
