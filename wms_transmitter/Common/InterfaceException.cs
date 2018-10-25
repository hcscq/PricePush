using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Common
{
    public enum InterfaceExceptionType
    {
         ReTry, NoReTry
    }

    public class InterfaceException : Exception
    {
        public InterfaceException(string message) : base(message)
        {
        }

        public InterfaceException(InterfaceExceptionType et,string message):base(message)
        {
            ErrorType = et;
        }

        public InterfaceExceptionType ErrorType = InterfaceExceptionType.ReTry;
    }
}
