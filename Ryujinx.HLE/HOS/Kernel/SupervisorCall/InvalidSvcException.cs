using System;

namespace Ryujinx.HLE.HOS.Kernel.SupervisorCall
{
    class InvalidSvcException : Exception
    {
        public InvalidSvcException(string message) : base(message) { }
    }
}
