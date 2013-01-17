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
            Shuffle(cards);
		}

        private void Shuffle(IList<IPlayingCard> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                IPlayingCard value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
	
		public IPlayingCard Draw()
		{
            IPlayingCard card = cards[0];
            cards.RemoveAt(0);

            return card;
		}
	
		public void Reset()
		{
            cards = new List<IPlayingCard>();
            SetDeck();
		}

		public Deck ()
		{
            Reset();
		}

        private void SetDeck()
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    cards.Add(new PlayingCard(suit, rank, false));
                }
            }
        }
	}
}

