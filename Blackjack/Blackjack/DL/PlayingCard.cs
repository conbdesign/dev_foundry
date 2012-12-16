using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public class PlayingCard : IPlayingCard
    {
		private Suit suit;
		private int rank;
		private bool hidden;
		
		public Suit Suit 
		{ 
			get { return suit; }
		}
        public int Rank 
		{
			get { return rank; }
		}
        public bool Hidden 
		{ 
			get { return Hidden; }
			set { Hidden = false; }
		}
        public PlayingCard(Suit new_suit, int new_rank, bool isHidden)
        {
			hidden = isHidden;
			rank = new_rank;
			suit = new_suit;
        }
    }
}
