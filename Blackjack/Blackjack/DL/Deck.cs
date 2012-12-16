using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
	public class Deck : IDeck
	{
		private List<IPlayingCard> cards;
<<<<<<< HEAD
=======

>>>>>>> 151081dc7eda0ab597e17a003457fe94804cf426
		public List<IPlayingCard> Cards 
		{ 
			get { return cards; }
			set	{ cards = value; }
		}
<<<<<<< HEAD
	
		public void Shuffle()
=======

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
>>>>>>> 151081dc7eda0ab597e17a003457fe94804cf426
		{
		}
	
		public IPlayingCard Draw()
		{
			return null;
		}
	
		public void Reset()
		{
		}
	public Deck ()
	{
		List<IPlayingCard> cards = new List<IPlayingCard>
		}
	}
}

