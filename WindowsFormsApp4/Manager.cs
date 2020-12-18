using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Manager
    {
        protected float money;
        Team t;
        public Player buyPlayer()
        {
            Player player = new Player();
            Random rnd = new Random();
            player.Power = rnd.Next(1, 100);
            player.name = rnd.Next(1, 100).ToString();
            player.cost = rnd.Next(1, 10000);
            return player;
        }
        public void sellPlayer(Player player, string name) {
            Market m = new Market();
            m.sellPlayer(name);
        }
        public string[] watchTeam()
        {
            string[] st = new string[1000];
           for (int i=0; i<t.Player.Count;i++)
            {
                st[i] = t.Player[i].name;
            }
            return st;
        }

    }
}
