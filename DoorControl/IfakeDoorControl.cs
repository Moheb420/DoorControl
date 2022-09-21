using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public interface IfakeDoorControl
    {
        //public void RequestEntry(int id);
        public bool FakeDoorOpened();
        //public bool FakeDoorClosed();
    }
}
