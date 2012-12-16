using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
	public class Deck : IDeck
	{
		private List<IPlayingCard> cards;

		public List<IPlayingCard> Cards 
		{ 
			get { return cards; }
			set	{ cards = value; }
		}

        public void Shuffle()
		{
		}

        public IPlayingCard Draw()
		{
			return null;
		}

        public void Reset()
		{
		}

		public Deck()
		{

		}
	}
}

