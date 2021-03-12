using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        public enum SUIT
        {
            Hearts,
            Diamonds,
            Spades,
            Clubs,
        }

        public  enum VALUE
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
        }

        public SUIT Suit;
        public VALUE Value;

        public Card(SUIT newSuit, VALUE newValue)
        {
            this.Suit = newSuit;
            this.Value = newValue;
        }

        public Card()
        {

        }

        public override string ToString()
        {
            return $"{Value.ToString()} of {Suit.ToString()}";
        }

        public int EvaluateCard()
        {
            if (Value == VALUE.Ace) return 11; // Remember it can also be 1
            if (Value == VALUE.Two) return 2;
            if (Value == VALUE.Three) return 3;
            if (Value == VALUE.Four) return 4;
            if (Value == VALUE.Five) return 5;
            if (Value == VALUE.Six) return 6;
            if (Value == VALUE.Seven) return 7;
            if (Value == VALUE.Eight) return 8;
            if (Value == VALUE.Nine) return 9;
            if (Value == VALUE.Ten) return 10;
            if (Value == VALUE.Jack) return 10;
            if (Value == VALUE.Queen) return 10;
            if (Value == VALUE.King) return 10;
            return 0;
        }
    }
}
