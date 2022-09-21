using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class FakeDoor:IFakeDoor
    {
        public bool FakeOpen()
        {
            return true;

        }

        public bool FakeClose()
        {
            return false;
        }
    }
}
