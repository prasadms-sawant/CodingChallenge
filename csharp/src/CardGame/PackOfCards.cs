using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CodingChallenge.CardGame
{
    public class PackOfCards : IPackOfCards
    {
        #region private members of the class
        private static int _maxNumberOfCards = 52;
        private ICard[] _cards = new Card[_maxNumberOfCards];
        private ICollection<ICard> _removedCards = new Collection<ICard>();
        private int _currentCardPosition = 0;
        #endregion

        public int Count { get; private set; }

        public PackOfCards()
        {
            InitializePackOfCards();
        }

        /// <summary>
        /// Sets up the standard pack of cards
        /// </summary>
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
            _currentCardPosition = 0;
        }

        /// <summary>
        /// The shuffle method perform the following operations
        /// 1. Merge the removed cards back into the pack of cards.
        /// 2. Shuffle the pack of cards.
        /// 3. Adjust the count property
        /// </summary>
        public void Shuffle()
        {
            Random rand = new Random();

            // Geting the elements from the array having values
            _removedCards = _removedCards.Where(card => card != null).ToArray();
            _cards = _cards.Concat(_removedCards).ToArray();
            Count += _removedCards.Count;

            for (int i = 0; i < _maxNumberOfCards; i++)
            {

                int r = i + rand.Next(52 - i);

                //swapping the elements
                ICard temp = _cards[r];
                _cards[r] = _cards[i];
                _cards[i] = temp;

            }
        }

        /// <summary>
        /// The TakeCardFromTopOfPack method picks up the top card from the 
        /// </summary>
        /// <returns></returns>
        public ICard TakeCardFromTopOfPack()
        {
            Count--;
            if (_currentCardPosition < _cards.Length)
            {
                _removedCards.Add(_cards[_currentCardPosition]);
                _cards = _cards.Where((source, index) => index != _currentCardPosition).ToArray();
                return _cards[_currentCardPosition++];
            }
            else
            {
                _removedCards.Add(_cards[--_currentCardPosition]);
                _cards = _cards.Where((source, index) => index != _currentCardPosition).ToArray();
                return _removedCards.Last();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
                yield return _cards[i];
        }
    }
}
