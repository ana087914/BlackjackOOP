using System;
using System.Collections.Generic;

namespace BlackjackOOP
{
    public class Shoe
    {
        private List<Card> cards = new List<Card>();
        private Random random = new Random();

        public Shoe(int numberOfDecks)
        {
            for (int d = 0; d < numberOfDecks; d++)
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                    {
                        cards.Add(new Card(rank, suit));
                    }
                }
            }

            Shuffle();
        }

        public void Shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int j = random.Next(i, cards.Count);

                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card DealCard()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public int Count
        {
            get { return cards.Count; }
        }
    }
}