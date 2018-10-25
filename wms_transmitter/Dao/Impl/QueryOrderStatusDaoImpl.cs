
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Dao.Impl
{
    using IBatisNet.DataMapper;
    using System.Windows.Forms;
    using wms_transmitter.Domain;

    public class QueryOrderStatusDaoImpl : BaseDao, IQueryOrderStatusDao
    {
          public QueryOrderStatusDaoImpl() : base() { }

          public QueryOrderStatusDaoImpl(ISqlMapper map) : base(map) { }

        /// <summary>
        /// 订单状态查询
        /// </summary>
        /// <param name="djbhs">订单编号数组</param>
        /// <returns></returns>
          public List<QueryOrderStatus> QueryOrderStatus(string[] djbhs)
          {
              //查询结果存储
              List<QueryOrderStatus> queryList = null;
              try
              {
                  queryList = (List<QueryOrderStatus>)GetMapper().QueryForList<QueryOrderStatus>("TaskM.QueryOrderStatus", djbhs);
                  if (queryList != null && queryList.Count > 0)
                  {
                      return queryList;
                  }
              }
              catch
              {
                  return null;//查询异常
              }
              return queryList;

          }
    }
}
