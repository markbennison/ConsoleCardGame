namespace ConsoleCardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a deck and shuffle it
            Deck deck = new Deck();
            deck.Shuffle();

            // Create two players
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            // Deal two cards to each player
            for (int i = 0; i < 2; i++)
            {
                player1.AddCard(deck.DrawCard());
                player2.AddCard(deck.DrawCard());
            }

            // Show the players' hands
            player1.ShowHand();
            player1.Score();
            
            player2.ShowHand();
            player2.Score();

            // ... (Add game logic here, such as drawing more cards, comparing hands, etc.)

            Console.ReadKey();
        }
    }
}
