using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public interface IDoor
    {
        void Open();
        void Close();
    }
}
