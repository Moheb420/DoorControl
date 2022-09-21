using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class EntryNotification:IEntryNotification
    {
        public void NotifyEntryGranted(int id)
        {
            Console.WriteLine("Door Entry granted to " + id);
        }

        public void NotifyEntryDenied(int id)
        {
            Console.WriteLine("Door Entry  is denied to" + id);
        }
    }
}
