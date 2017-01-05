using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpaterPattern
{
    public interface IDoor
    {
        void Lock();
        void Unlock();
        bool IsDoorOpen();

    }
}
