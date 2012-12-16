using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public enum Suit
    {
        DIAMONDS,
        CLUBS,
        HEARTS,
        SPADES
    };

    public enum Rank
    {
        TWO = 2,
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
        KING,
        ACE
    };

    public interface IPlayingCard
    {
        Suit Suit { get; }
        int Rank { get; }
        bool Hidden { get; set; }
    }
}
