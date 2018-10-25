using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.VO
{//{"Response":[{"OrderId":"D232111","Success":true,"Message":"Success"}],"Message":"","Success":"true"}
    public class OrderResult 
    {
        public string OrderId;
        public bool Success;
        public string Message;
    }
    public class SerResponse
    {
        public List<OrderResult> Response;
        public string Message;
        public bool Success;
    }
    public class PriceResponse
    {
        public List<updateItem> Response;
        public string Message;
        public bool Success;
        public string action;
        public string key;
        public string sign;
        public string time;
    }
    public class updateItem
    {
        //public string goodsId;
        public string goodsNum;
        public int status;//1 not find 、2 exception
        public int NewStatus;
        public int OldStatus;
        //public string stock;
        public int ID;
        public bool Success;
        public string Message;
    }
}
