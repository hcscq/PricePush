using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Service
{
    interface IOrderHandle
    {
        Object getObj(string objson);

        void doHandle(string objson, Tesla.Net.SimpleResponse response);


    }
}
