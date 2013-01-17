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
            Console.Clear();

            foreach (IPlayer player in game.Players)
            {
                DisplayPlayer(player);

            }
        }

        private static void DisplayPlayer(IPlayer player)
        {
            Console.WriteLine(player.Name);

            foreach (IPlayingCard card in player.Hand.Cards)
            {
                DisplayCard(card);
            }

            Console.WriteLine();

            Console.WriteLine("Score: " + player.Hand.Score());

            Console.WriteLine(Environment.NewLine);
        }

        private static void DisplayCard(IPlayingCard card)
        {
            Console.Write(card.Rank.ToString() + " of " + card.Suit.ToString() + ", ");
        }
    }
}
