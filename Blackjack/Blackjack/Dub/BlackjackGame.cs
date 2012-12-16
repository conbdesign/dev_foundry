using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public class BlackjackGame : IBlackjackGame
    {
        private int numberOfPlayer = -1;
        private List<IPlayer> players = new List<IPlayer>();
        private IDeck deck;

        public List<IPlayer> Players
        {
            get { return players; }
        }

        public void Setup()
        {
            string inputText = "a";

            GetPlayerCount(ref numberOfPlayer, ref inputText);

            CreateDealer();

            Pause();

            CreatePlayers();

            deck = new Deck();
        }

        private void CreateDealer()
        {
            players.Add(new Player(PlayerType.COMPUTER, "Dealer"));
        }

        private void CreatePlayers()
        {
            for (int i = 0; i < numberOfPlayer; i++)
            {
                InputPlayer();
                Pause();
            }
        }

        private void InputPlayer()
        {
            Console.Clear();
            Console.Write("Enter a player name: ");
            string name = Console.ReadLine();

            players.Add(new Player(PlayerType.HUMAN, name));
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
            bool wantToPlayMore = true;

            while (wantToPlayMore)
            {
                PlayHand();

                wantToPlayMore = DoesUserWantToContinue();
            }
        }

        private void PlayHand()
        {
            deck.Shuffle();

            DealHands();

            GivePlayersChanceToHit();

            DeclareWinner();
        }

        private void DealHands()
        {
            foreach (IPlayer player in players)
            {
                player.Hand.AddCard(deck.Draw());
            }

            foreach (IPlayer player in players)
            {
                player.Hand.AddCard(deck.Draw());
            }
        }

        private void GivePlayersChanceToHit()
        {

        }

        private void DeclareWinner()
        {

        }

        private bool DoesUserWantToContinue()
        {
            Console.Clear();
            Console.Write("Do you want to play another hand <Y/N>? ");
            string continueText = Console.ReadLine();

            if (continueText.ToUpper() != "Y")
                return false;

            return true;
        }

        private void Pause()
        {
            Console.WriteLine(Environment.NewLine + "Press any key to continue ...");
            Console.ReadLine();
        }
    }
}
