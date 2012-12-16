using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    class Player
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
            get {return hand;}
        }

        public Action Play()
        {
            return Action.STAND;
 
        }
        public Player(PlayerType stype, string sname)
        {
            stype = Type;
            sname = Name;
        }
    }
}
