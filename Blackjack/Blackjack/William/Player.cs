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
                Console.WriteLine("Would you like to Hit or Stand?(press 'h' to hit..any other key to stand");
                string temp = Console.ReadLine();
                if (temp.Equals("h"))
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
                if (hand.Score() <= 15)
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
            stype = Type;
            sname = Name;
        }
    }
}
