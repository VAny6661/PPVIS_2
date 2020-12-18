using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Market
    {
        List<Player> players = new List<Player>();
        public void sellPlayer(string player)
        {
            for(int i = 0; i < players.Count; i++)
            {
                if (players[i].name == player)
                    players.RemoveAt(i);
            }
        }
    }
}
