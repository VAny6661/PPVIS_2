using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Match
    {
        public MatchAction getMatchCondition()
        {
            MatchAction ma = new MatchAction();
            return ma;
        }
        public void StartMatch() {
            MatchTime MT = new MatchTime(180);
        }
        private bool generateInjury() { return true; }

        private bool generateViolatin() { return true; } 
    }
}
