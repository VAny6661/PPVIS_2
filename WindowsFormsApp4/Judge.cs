using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Judge
    {
        public MatchAction condition;

        public void startNewMatch() 
        {
            Match ma = new Match(); 
        }
        public void reactTimeEnd(int time) { }
        public void reactInjury(int time) { }
        public void reactViolation(int time) { }
        public float getCurrentTime() { return 0.1f; }
        public void tick() { }
    }
}
