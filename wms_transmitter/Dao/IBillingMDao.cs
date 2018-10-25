using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wms_transmitter.Domain;
using wms_transmitter.VO;

namespace wms_transmitter.Dao
{
    /// <summary>
    /// 系统参数接口
    /// </summary>
    public interface IBillingMDao
    {

        /// <summary>
        /// 查询单据是否存在
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        int QueryOrder(ValObj vo);

        /// <summary>
        /// 查询单据历史是否存在
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        int QueryOrderHty(ValObj vo);

        /// <summary>
        /// 根据单号获取单据状态
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        string qryOrderStatus(ValObj vo);


        /// <summary>
        /// 查询单据状态
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        string QueryOrderStatus(ValObj vo);

        /// <summary>
        /// 查询取消状态
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        string QueryCancelStatus(ValObj vo);

        /// <summary>
        /// 查询历史单据取消状态
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        string QueryCancelStatusHty(ValObj vo);

        /// <summary>
        /// 根据单号取消订单
        /// </summary>
        /// <param name="billingM"></param>
        /// <returns></returns> 
        int updateBillingMCancel(BillingM M);

        /// <summary>
        /// 根据单号加急订单
        /// </summary>
        /// <param name="billingM"></param>
        /// <returns></returns> 
        int updateBillingMUrgent(BillingM M);


        /// <summary>
        /// 同步销售平台订单
        /// </summary>
        /// <param name="billingM"></param>
        /// <returns></returns> 
        int updateBillingMTB(BillingM M);

        /// <summary>
        /// 根据单号锁定订单
        /// </summary>
        /// <param name="billingM"></param>
        /// <returns></returns> 
        int updateBillingMLock(BillingM M);

        /// <summary>
        /// 根据单号解锁订单
        /// </summary>
        /// <param name="billingM"></param>
        /// <returns></returns> 
        int updateBillingMUNLock(BillingM M);


        /// <summary>
        /// 插入主档和明细
        /// </summary>
        /// <param name="BM"></param>
        /// <returns></returns>
        bool insertBillingMD(BillingM BM);
    }
}
