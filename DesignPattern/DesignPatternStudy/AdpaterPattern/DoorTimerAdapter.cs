using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdpaterPattern
{
    public class DoorTimerAdapter : ITimerClient
    {
        private ITimedDoor timedDoor;

        public DoorTimerAdapter(ITimedDoor theDoor)
        {
            timedDoor = theDoor;
        }

        public virtual void TimeOut(int timeOutId)
        {
            timedDoor.DoorTimeOut(timeOutId);
        }
    }
}