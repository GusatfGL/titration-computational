using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Hand
    {
        public List<Card> Cards = new List<Card>();

        public int EvaluateHand()
        {
            int score = 0;

            foreach (Card c in Cards)
            {
                score += c.EvaluateCard();
            }

            return score;
        }

        public override string ToString()
        {
            string returningString = string.Empty;

            foreach (Card c in Cards)
            {
                returningString += $"\n{c.ToString()}";
            }
            return returningString;
        }
    }
}
