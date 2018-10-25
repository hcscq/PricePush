using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace wms_transmitter.Dao
{
    using wms_transmitter.Domain;
    using wms_transmitter.VO;

    public interface ITaskMDao
    {

        /// <summary>
        /// 根据单号锁定订单
        /// </summary>
        /// <param name="billingM"></param>
        /// <returns></returns> 
        int updateTaskMLock(OUT_SALE_TASK_M M);

        /// <summary>
        /// 根据单号解锁订单
        /// </summary>
        /// <param name="billingM"></param>
        /// <returns></returns> 
        int updateTaskMUNLock(OUT_SALE_TASK_M M);
    }
}
