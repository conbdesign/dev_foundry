using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public enum Action
    {
        HIT,
        STAND
    };

    public enum PlayerType
    {
        HUMAN,
        COMPUTER
    };

    public interface IPlayer
    {
        PlayerType Type { get; }

        string Name { get; }

        IHand Hand { get; set; }

        Action Play();
    }
}
