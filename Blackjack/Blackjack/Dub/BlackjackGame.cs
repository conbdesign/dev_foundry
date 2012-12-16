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


        public List<IPlayer> Players
        {
            get { return players; }
        }

        public void Setup()
        {
            string inputText = "a";

            GetPlayerCount(ref numberOfPlayer, ref inputText);

            CreateDealer();

            CreatePlayers();

            deck = new Deck();
        }

        private void CreateDealer()
        {
            players.Add(new Player(PlayerType.COMPUTER, "Dealer"));
        }

        private void CreatePlayers()
        {
<<<<<<< HEAD

=======
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
>>>>>>> 69088281f6499151cd8fd61e48bb23c78c5992d6
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
<<<<<<< HEAD
=======
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

            DeclareWinners();
        }

        private void DealHands()
        {
            foreach (IPlayer player in players)
            {
                player.Hand.AddCard(deck.Draw());
                Output.DisplayGame(this);
            }

            foreach (IPlayer player in players)
            {
                player.Hand.AddCard(deck.Draw());
                Output.DisplayGame(this);
            }
        }

        private void GivePlayersChanceToHit()
        {
            foreach (IPlayer player in players)
            {
                while (player.Play() == Action.HIT)
                {
                    player.Hand.AddCard(deck.Draw());
                    Output.DisplayGame(this);
                }
            }
        }

        private void DeclareWinners()
        {
            Console.Clear();

            foreach (IPlayer player in players)
            {
                if (player.Hand.Score() <= 21)
                {
                    Console.WriteLine((player.Type == PlayerType.HUMAN ? "Player " + player.Name : "The Dealer ") 
                        + " has won.");
                }
                else
                {
                    Console.WriteLine((player.Type == PlayerType.HUMAN ? "Player " + player.Name : "The Dealer ")
                        + " has busted.");
                }
            }
        }

        private bool DoesUserWantToContinue()
        {
            Console.Clear();
            Console.Write("Do you want to play another hand <Y/N>? ");
            string continueText = Console.ReadLine();

            if (continueText.ToUpper() != "Y")
                return false;
>>>>>>> 69088281f6499151cd8fd61e48bb23c78c5992d6

            return true;
        }
    }
}
