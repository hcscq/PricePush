using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace wms_transmitter.Dao
{
    using wms_transmitter.Domain;

    public interface IStockDao
    {
        /// <summary>
        /// 库存查询
        /// </summary>
        /// <param name="spids">商品编号数组</param>
        /// <returns></returns>
        List<Stock> StockQuery(string[] spids);
    }
}
