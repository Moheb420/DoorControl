using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class UserValidation:IUserValidation
    {
        public DoorControl _DoorControl;

        public UserValidation(DoorControl doorControl)
        {
            _DoorControl = doorControl;
        }

        public bool ValidateEntryRequest(int id)
        {
            if (id == _DoorControl.requestEntryId)
            {
                return true;
            }

            return false;
        }
    }
}
