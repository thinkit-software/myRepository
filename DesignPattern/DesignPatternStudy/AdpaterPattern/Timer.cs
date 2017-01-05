using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpaterPattern
{
    public class Timer
    {
        public IList<ITimerClient> TimerClients
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void Register(int timeout, int timeOutId, ITimerClient timerClient)
        {
            /*
             Code
             */         
        }
    }
}
