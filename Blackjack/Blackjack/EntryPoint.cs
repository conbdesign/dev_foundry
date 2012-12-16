using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            IBlackjackGame game = new BlackjackGame();

            game.Setup();

            game.Play();
        }
    }
}
