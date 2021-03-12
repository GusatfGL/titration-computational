using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        public List<Card> Cards = new List<Card>();

        private Random random = new Random();

        public Deck()
        {
            // Creats a deck
            for (int iteratingSuit = 0; iteratingSuit < Enum.GetNames(typeof(Card.SUIT)).Length; iteratingSuit++)
            {
                for (int iteratingValue = 0; iteratingValue < Enum.GetNames(typeof(Card.VALUE)).Length; iteratingValue++)
                {
                    Cards.Add(new Card((Card.SUIT)iteratingSuit, (Card.VALUE)iteratingValue));
                }
            }
        }

        public Card DrawCard()
        {
            int randomNumber = random.Next(Cards.Count);
            Card returningCard = Cards[randomNumber];
            Cards.RemoveAt(randomNumber);

            return returningCard;
        }

    }
}
