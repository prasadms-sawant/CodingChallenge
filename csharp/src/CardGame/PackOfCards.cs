using System.Collections;
using System.Collections.Generic;

namespace CodingChallenge.CardGame
{
    public class PackOfCards : IPackOfCards
    {
        private static int _maxNumberOfCards = 52;
        private ICard[] _cards = new ICard[_maxNumberOfCards];
        private int _currentCardPosition = 0;
        public PackOfCards()
        {
            InitializePackOfCards();
        }

        private void InitializePackOfCards()
        {
            int n = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
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
