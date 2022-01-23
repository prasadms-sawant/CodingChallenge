namespace CodingChallenge.CardGame
{
    /// <summary>
    /// This class simply returns the standard pack of cards
    /// </summary>
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        /// <summary>
        /// Initialize and returns an instance of PackOfCards.
        /// </summary>
        /// <returns></returns>
        public IPackOfCards Create() {
            return new PackOfCards();
        }
    }
}
