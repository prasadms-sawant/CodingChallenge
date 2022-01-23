namespace CodingChallenge.CardGame
{
    /// <summary>
    /// This class simply returns the standard pack of cards
    /// </summary>
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        public IPackOfCards Create() {
            return new PackOfCards();
        }
    }
}
