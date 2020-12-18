using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Team
    {
        List<Player> player = new List<Player>();
        public List<Player> Player
        {
            get
            {
                return player;
            }
            set
            {
                player = value;
            }
        }
        public void swapActive(string toActive, string fromActive) { }
        public void addPlayer(Player player) { }

        public void removePlayer(Player player) {
         
        }
    }
}
