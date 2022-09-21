using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DoorControl
{
    public  class Door : IDoor
    {
        public bool DoorVar;
        public IDoorControl _doorControl;

        public Door(IDoorControl doorControl)
        {
            _doorControl = doorControl;
        }

        public void Open()
        {
            Console.WriteLine("Door open requested.");

            while (_doorControl.DoorOpened())
            {
                Console.WriteLine("Door is opened");
            }
            
        }

        
        public void Close()
            {
                Console.WriteLine("Door close is requested.");

            }
        }
}
