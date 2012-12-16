using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    class Player : IPlayer
    {
        private IHand hand;
        private string name;
        private PlayerType type;

        public PlayerType Type
        {
            get { return type; }
        }
        public string Name
        {
            get { return name;}
        }

        public  IHand Hand
        { 
            get { return hand; }
            set { hand = value; }
        }

        public Action Play()
        {
            if (this.type == PlayerType.HUMAN)
            {
                Console.WriteLine("Hit or Stand <H/S>?");
                ConsoleKeyInfo info = Console.ReadKey();

                if (info.Key == ConsoleKey.H)
                {
                    return Action.HIT;
                }
                else
                {
                    return Action.STAND;
                }
            }
            else
            {
                if (this.hand.Score() < 16)
                {
                    return Action.HIT;
                }
                else
                {
                    return Action.STAND;
                }
            }
        }

        public Player(PlayerType stype, string sname)
        {
            hand = new Hand();
            name = sname;
            type = stype;
        }

        public void Reset()
        {
            hand.Cards.Clear();
        }
    }
}
