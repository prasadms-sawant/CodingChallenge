using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {
        public Card(int i, int j)
        {
            Suit = (Suit)i;
            Value = (Value)j;
        }
        public Suit Suit { get; set; }

        public Value Value { get; set; }

        public bool Equals(ICard other) {
            return this == other as Card;
        }
    }
}
