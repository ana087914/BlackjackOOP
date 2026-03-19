 using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace BlackjackOOP
{
    public enum Rank
    {
        ACE = 1,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING
    }
    public enum Suit
    {
        HEARTS,
        DIAMONDS,
        CLUBS,
        SPADES
    }
    public class Card
    {
        private Rank rank;
        private int cardValue;
        private Suit suit;
        private bool isFaceDown;

        public int Value
        {

            get  {
                switch(rank)
                {
                    case Rank.ACE: return 11;
                    case Rank.TWO: return 2;
                    case Rank.THREE: return 3;
                    case Rank.FOUR: return 4;
                    case Rank.FIVE: return 5;
                    case Rank.SIX: return 6;
                    case Rank.SEVEN: return 7;
                    case Rank.EIGHT: return 8;
                    case Rank.NINE: return 9;
                    default: return 10;
                }
                }
            }
        


        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
            this.isFaceDown = false;

        }
     
        public void Flip()
        {

        }
        public override string ToString()
        {
            return rank.ToString() + " of " + suit.ToString();
        }
    }
}

