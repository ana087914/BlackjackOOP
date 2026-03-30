using System.Collections.Generic;

namespace BlackjackOOP
{
    public class Hand
    {
        private List<Card> cards = new List<Card>();

        public List<Card> Cards
        {
            get { return cards; }
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void Clear()
        {
            cards.Clear();
        }

        public int GetValue()
        {
            int total = 0;
            int aceCount = 0;

            foreach (Card card in cards)
            {
                total += card.Value;

                if (card.Rank == Rank.ACE)
                {
                    aceCount++;
                }
            }

            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }

        public bool IsBust()
        {
            return GetValue() > 21;
        }
    }
}