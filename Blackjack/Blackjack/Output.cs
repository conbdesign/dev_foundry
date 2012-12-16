﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public class Output : IOutputInput
    {
        public void DisplayGame(IBlackjackGame game)
        {
            foreach (IPlayer player in game.Players)
            {
                DisplayPlayer(player);
            }
        }

        private void DisplayPlayer(IPlayer player)
        {

        }
    }
}