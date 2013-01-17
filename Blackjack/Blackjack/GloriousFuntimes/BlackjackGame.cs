using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StandardValidation;


namespace Blackjack
{
    public class BlackjackGame : IBlackjackGame
    {
        private int numberOfPlayer;
        private int numberOfHumans;
        private int numberOfComputers;
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

        private void GetPlayerCount(ref int numberOfPlayer, ref string inputText)
        {
            
            Console.WriteLine("You may have between 1 and 4 Players");
            numberOfHumans= int.Parse(StandardValidator.Question("How many human players?",
                "I' m sorry I didn't understand that please choose a number between 0 and 4 "));
           
            numberOfPlayer =numberOfHumans;
            
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
            deck.Reset();
            deck.Shuffle();

            foreach (IPlayer player in players)
            {
                player.Reset();
            }

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
                Pause();

            }

            foreach (IPlayer player in players)
            {
                player.Hand.AddCard(deck.Draw());
                Output.DisplayGame(this);
                Pause();
            }
        }

        private void GivePlayersChanceToHit()
        {
            foreach (IPlayer player in players)
            {
                Console.Write(player.Name+" ");
                while (player.Play() == Action.HIT)
                {
                    player.Hand.AddCard(deck.Draw());
                    Console.Clear();
                    Output.DisplayGame(this);
                    Pause();
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

            Pause();
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
            Console.WriteLine();
            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}
