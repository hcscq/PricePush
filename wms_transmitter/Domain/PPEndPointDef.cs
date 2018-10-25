using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Domain
{
    public class Status
    {
        public static int Inital=0;
        public int Success=0;
        public int Failed=0;
        public int NotFound=0;
    }
    public class Amount
    {
        public int Total=0;
        public int Successed=0;
        public int Failed=0;
    }
   public class PPEndPointDef
    {
        public string Name;
        public string RemoteUrl;
        public Status _Status=new Status();
        public Amount Times=new Amount ();
        public Amount Details=new Amount();

    }
}
