using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public static class Output
    {
        public static void DisplayGame(IBlackjackGame game)
        {
            foreach (IPlayer player in game.Players)
            {
                DisplayPlayer(player);

            }
        }

        private static void DisplayPlayer(IPlayer player)
        {
            Console.WriteLine("Player Name: "+player);
        }
    }
}
