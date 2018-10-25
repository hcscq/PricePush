
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Dao.Impl
{
    using IBatisNet.DataMapper;
    using System.Windows.Forms;
    using wms_transmitter.Domain;
    using wms_transmitter.VO;

    public class TaskMDaoImpl : BaseDao, ITaskMDao
    {
          public TaskMDaoImpl() : base() { }

          public TaskMDaoImpl(ISqlMapper map) : base(map) { }


        /// <summary>
        /// 订单状态查询
        /// </summary>
        /// <param name="djbhs">订单编号数组</param>
        /// <returns></returns>
          public List<OUT_SALE_TASK_M> QueryOrderStatus(string[] djbhs)
          {
              //查询结果存储
              List<OUT_SALE_TASK_M> queryList = null;
              try
              {
                  queryList = (List<OUT_SALE_TASK_M>)GetMapper().QueryForList<OUT_SALE_TASK_M>("QueryOrderStatus", djbhs);
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

          /// <summary>
          /// 根据单号锁定订单
          /// </summary>
          /// <param name="billingM"></param>
          /// <returns></returns> 
          public int updateTaskMLock(OUT_SALE_TASK_M M)
          {
              return GetMapper().Update("TaskM.updateTaskMLock", M);
          }

          /// <summary>
          /// 根据单号锁定订单
          /// </summary>
          /// <param name="billingM"></param>
          /// <returns></returns> 
          public int updateTaskMUNLock(OUT_SALE_TASK_M M)
          {
              return GetMapper().Update("TaskM.updateTaskMUNLock", M);
          }
    }
}
