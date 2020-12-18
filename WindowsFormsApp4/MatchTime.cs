using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class MatchTime
    {
        private float curTime = 0f;
        private float maxTime = 300f;

        public MatchTime(int time)
        {
            maxTime = time;
        }

        public float getCurrTime() { return curTime; }
        public int addTime(float addition)
        {
            maxTime += addition;
            return 1;
        }
        public void stopResumeTime(bool resume)
        {
            resume = !resume;
        }

    }
}
