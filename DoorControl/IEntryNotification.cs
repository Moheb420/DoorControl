﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public interface IEntryNotification
    {
        void NotifyEntryGranted(int id);
        void NotifyEntryDenied(int id);
    }
}
