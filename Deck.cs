namespace ConsoleCardGame
{
    internal class Deck
    {
        private List<Card> cards;

        // Constructor to create a standard 52-card deck
        public Deck()
        {
            cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        // Method to shuffle the deck
        public void Shuffle()
        {
            Random random = new Random();
            cards = cards.OrderBy(x => random.Next()).ToList();
        }

        // Method to draw a card from the top of the deck
        public Card DrawCard()
        {
            if (cards.Count > 0)
            {
                Card drawnCard = cards[0];
                cards.RemoveAt(0);
                return drawnCard;
            }
            else
            {
                return null;
            }
        }
    }
}
