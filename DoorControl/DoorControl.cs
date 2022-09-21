using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class DoorControl:IfakeDoorControl
    {

        public int requestEntryId = 2;

        public IUserValidation _UserValidation;
        public IFakeDoor _Door;
        public IEntryNotification _EntryNotification;
        public IAlarm _Alarm;

        //public DoorControl(IUserValidation userValidation, IDoor door, IEntryNotification entryNotification, IAlarm alarm)
        //{
        //    _UserValidation = userValidation;
        //    _Door = door;
        //    _EntryNotification = entryNotification;
        //    _Alarm = alarm;
        //}
        public DoorControl(IFakeDoor door)
        {
            _Door = door;
        }

        public void RequestEntry(int id)
        {

            requestEntryId = id;
        }

        public bool FakeDoorOpened()
        {
            _Door.FakeOpen();
            return false;
        }
        public bool FakeDoorClosed()
        {
            return false;
        }





        //public bool DoorOpened()
        //{
        //    try
        //    {
        //        if (_UserValidation.ValidateEntryRequest(requestEntryId) == true)
        //        {
        //            _Door.Open();
        //            _EntryNotification.NotifyEntryGranted(requestEntryId);
        //            Console.WriteLine("Door is opening ...");
        //            Thread.Sleep(2000);
        //            return true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.InnerException);
        //        _EntryNotification.NotifyEntryDenied(requestEntryId);
        //        _Door.Close();

        //    }
        //    return false;
        //}
        //public bool DoorClosed()
        //{
        //    Console.WriteLine("Door is closing ...");
        //    Thread.Sleep(2000);
        //    if (DoorOpened() == true)
        //    {
        //        Console.WriteLine("Door is closed");
        //        return false;
        //    }

        //    return true;
        //}

        //public bool DoorBreach()
        //{
        //    throw new NotImplementedException();
        //}
    }
    
    
}
