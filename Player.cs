namespace ConsoleCardGame
{
    internal class Player
    {
        private string name;
        private List<Card> hand;

        // Constructor to initialize a player
        public Player(string name)
        {
            this.name = name;
            hand = new List<Card>();
        }

        // Method to add a card to the player's hand
        public void AddCard(Card card)
        {
            hand.Add(card);
        }

        // Method to display the player's hand
        public void ShowHand()
        {
            Console.WriteLine($"{name}'s hand:");
            foreach (Card card in hand)
            {
                Console.WriteLine(card);
            }
        }

        public void Score()
        {
            int score = 0;
            foreach (Card card in hand)
            {
                score += card.Value();
            }

            Console.WriteLine($"{name}'s score: {score} \n");
        }
    }
}
