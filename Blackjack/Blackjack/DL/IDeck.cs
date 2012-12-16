using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public interface IDeck
    {
        List<IPlayingCard> Cards { get; set; }

        void Shuffle();

        IPlayingCard Draw();

        void Reset();
    }
}
