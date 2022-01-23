namespace CodingChallenge.CardGame
{
    /// <summary>
    /// This class implement ICard contract.
    /// </summary>
    public class Card : ICard
    {
        // Setting up the card object with respective values of Suit and Value.
        public Card(int i, int j)
        {
            Suit = (Suit)i;
            Value = (Value)j;
        }
        public Suit Suit { get; private set; }

        public Value Value { get; private set; }

        public bool Equals(ICard other)
        {
            return this == other as Card;
        }
    }
}
