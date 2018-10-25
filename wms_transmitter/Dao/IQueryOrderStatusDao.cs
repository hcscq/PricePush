using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace wms_transmitter.Dao
{
    using wms_transmitter.Domain;

    public interface IQueryOrderStatusDao
    {

        List<QueryOrderStatus> QueryOrderStatus(string[] spids);
    }
}
