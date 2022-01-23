using System.Collections;
using System.Collections.Generic;

namespace CodingChallenge.CardGame
{
    public class PackOfCards : IPackOfCards
    {
        private static int _maxNumberOfCards = 52;
        private ICard[] _cards = new Card[_maxNumberOfCards];
        private int _currentCardPosition = 0;
        public PackOfCards()
        {
            InitializePackOfCards();
        }

        private void InitializePackOfCards()
        {
            int n = 0;
            for (int i = (int)Suit.Clubs; i <= (int)Suit.Spades; i++)
            {
                for (int j = (int)Value.Ace; j <= (int)Value.King; j++)
                {
                    _cards[n++] = new Card(i, j);
                    Count++;
                }
            }
            _currentCardPosition=0;
        }

        public int Count { get; private set; }

        public IEnumerator<ICard> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
                yield return _cards[i];
        }

        public void Shuffle()
        {
            Random rand = new Random();

            for (int i = 0; i < _maxNumberOfCards; i++)
            {

                int r = i + rand.Next(52 - i);

                //swapping the elements
                ICard temp = _cards[r];
                _cards[r] = _cards[i];
                _cards[i] = temp;

            }
        }

        public ICard TakeCardFromTopOfPack()
        {
            if (_currentCardPosition< _maxNumberOfCards)
            {
                return _cards[_currentCardPosition++];
            }
            else
            {
                return null;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
