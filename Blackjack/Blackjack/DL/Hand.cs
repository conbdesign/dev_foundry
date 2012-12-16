using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public class Hand : IHand
    {
        private List<IPlayingCard> cards;

        public List<IPlayingCard> Cards
        {
            get { return cards; }
            set { cards = value; }
        }

        public Hand()
        {
            cards = new List<IPlayingCard>();
        }

        public void AddCard(IPlayingCard card)
        {
            cards.Add(card);
        }

        public int Score()
        {
            int score = 0;

            foreach (IPlayingCard card in cards)
            {
               score += CardScore(card);
            }

            return score;
        }

        private int CardScore(IPlayingCard card)
        {
            int rankValue = (int)card.Rank;

            if (rankValue > 10) rankValue = 10;

            if (card.Rank == Rank.ACE)
                rankValue = 11;

            return rankValue;
        }
    }
}
