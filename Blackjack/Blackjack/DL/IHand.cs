using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public interface IHand
    {
        List<IPlayingCard> Cards { get; set; }

        void AddCard(IPlayingCard newCard);

        int Score();
    }
}
