namespace ConsoleCardGame
{
    internal class Card
    {
        // Private fields to store card data
        private Suit suit;
        private Rank rank;

        // Constructor to initialise a card
        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        // Accessor methods (Getters)
        public Suit Suit
        {
            get { return suit; }
        }

        public Rank Rank
        {
            get { return rank; }
        }

        // Overloaded ToString() method for displaying card information
        public override string ToString()
        {
            return $"{rank} of {suit}";
        }

        public int Value()
        {
            int value = (int)rank;

            if (value > 10)
            {
                value = 10;
            }

            return value; 
        }
    }
}
