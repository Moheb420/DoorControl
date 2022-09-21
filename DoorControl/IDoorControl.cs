using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public interface IDoorControl
    {
        void RequestEntry(int id);
        bool DoorClosed();
        bool DoorOpened();
        bool DoorBreach();
    }
}
