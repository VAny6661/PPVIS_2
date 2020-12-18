using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public interface BookMaker
    {
        string[] getMatchInfo();
        void makeBet(string name, float sum);
        float checkBet(string name);
        float createCofficient();
        
    }
}
