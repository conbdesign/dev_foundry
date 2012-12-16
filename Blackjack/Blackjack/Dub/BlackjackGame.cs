using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public class BlackjackGame : IBlackjackGame
    {
        private int numberOfPlayer = -1;
        private List<IPlayer> players;
        private IDeck deck;

        public void Setup()
        {
            string inputText = "a";

            GetPlayerCount(ref numberOfPlayer, ref inputText);

            CreateDealer();

            CreatePlayers();

            
        }

        private void CreateDealer()
        {
            players.Add(new Player(PlayerType.COMPUTER, "Dealer"));
        }

        private void CreatePlayers()
        {

        }

        private static void GetPlayerCount(ref int numberOfPlayer, ref string inputText)
        {
            while (numberOfPlayer < 1 || numberOfPlayer > 4)
            {
                numberOfPlayer = -1;
                inputText = "a";

                Console.Clear();
                Console.WriteLine("The number of players must be between 1 and 4." + Environment.NewLine);

                while (!int.TryParse(inputText, out numberOfPlayer))
                {
                    Console.Write("Enter number of human players 1-4: ");
                    inputText = Console.ReadLine();
                }
            }
        }

        public void Play()
        {

        }
    }
}
