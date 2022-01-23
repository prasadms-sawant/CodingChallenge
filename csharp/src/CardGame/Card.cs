using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {
        public Card(int suit, int value)
        {
            this.Suit = (Suit)suit;
            this.Value = (Value)value;  

        }
        public Suit Suit {
            get {
                return this.Suit;
            }
           private set {
                this.Suit = value;
            } 
        }

        public Value Value {
            get {
                return this.Value;
            }
            private set {
                this.Value = value; 
            }
        }

        public bool Equals(ICard other) => throw new NotImplementedException();
    }
}
