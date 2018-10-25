using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace wms_transmitter.Dao.Impl
{
    using IBatisNet.DataMapper;
    using wms_transmitter.Domain;

    public class StockDaoImpl:BaseDao,IStockDao
    {
        public StockDaoImpl() : base() { }

        public StockDaoImpl(ISqlMapper map) : base(map) { }

        /// <summary>
        /// 库存查询
        /// </summary>
        /// <param name="spbhs">商品编号数组</param>
        /// <returns></returns>
        public List<Stock> StockQuery(string[] spbhs)
        {
            List<Stock> queryList = null;
            try
            {
                queryList = (List<Stock>)GetMapper().QueryForList<Stock>("Stock.QueryStock", spbhs);
                if (queryList != null && queryList.Count > 0)
                {
                    return queryList;
                }
            }
            catch
            {
                return null;//异常
            }
         
          return queryList;

        }



    }
}
