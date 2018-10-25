using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wms_transmitter.Domain;
using wms_transmitter.VO;
using IBatisNet.DataMapper;
using wms_transmitter.Common;
using System.Collections;
using Oracle.ManagedDataAccess.Client;

namespace wms_transmitter.Dao.Impl
{
    public class BillingMDaoImpl : BaseDao, IBillingMDao
    {


        /// <summary>
        /// 查询单据是否存在
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int QueryOrder(ValObj vo)
        {
            return Convert.ToInt32(GetMapper().QueryForObject("BillM.QueryOrder", vo));
        }

        /// <summary>
        /// 查询单据历史是否存在
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int QueryOrderHty(ValObj vo)
        {
            return Convert.ToInt32(GetMapper().QueryForObject("BillM.QueryOrderHty", vo));
        }

        /// <summary>
        /// 根据单号获取单据状态
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public string qryOrderStatus(ValObj vo)
        {
            return (string)GetMapper().QueryForObject("BillingM.qryOrderStatus", vo);
        }

        /// <summary>
        /// 查询单据状态
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public string QueryOrderStatus(ValObj vo)
        {
            return (string)GetMapper().QueryForObject("BillM.QueryOrderStatus", vo);
        }

        /// <summary>
        /// 查询取消状态
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public string QueryCancelStatus(ValObj vo)
        {
            return (string)GetMapper().QueryForObject("BillM.QueryCancelStatus", vo);
        }

        /// <summary>
        /// 查询历史单据取消状态
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public string QueryCancelStatusHty(ValObj vo)
        {
            return (string)GetMapper().QueryForObject("BillM.QueryCancelStatusHty", vo);
        }

        /// <summary>
        /// 根据单号取消订单
        /// </summary>
        /// <param name="billingM"></param>
        /// <returns></returns>
        public int updateBillingMCancel(BillingM M)
        {
            return GetMapper().Update("BillM.updateBillingMCancel", M);
        }

        /// <summary>
        /// 根据单号加急订单
        /// </summary>
        /// <param name="billingM"></param>
        /// <returns></returns> 
        public int updateBillingMUrgent(BillingM M)
        {
            return GetMapper().Update("BillM.updateBillingMUrgent", M);
        }

        /// <summary>
        /// 同步销售平台订单
        /// </summary>
        /// <param name="billingM"></param>
        /// <returns></returns> 
        public int updateBillingMTB(BillingM M)
        {
            return GetMapper().Update("BillM.updateBillingMTB", M);
        }


        /// <summary>
        /// 根据单号锁定订单
        /// </summary>
        /// <param name="billingM"></param>
        /// <returns></returns> 
        public int updateBillingMLock(BillingM M)
        {
            return GetMapper().Update("BillM.updateBillingMLock", M);
        }

        /// <summary>
        /// 根据单号锁定订单
        /// </summary>
        /// <param name="billingM"></param>
        /// <returns></returns> 
        public int updateBillingMUNLock(BillingM M)
        {
            return GetMapper().Update("BillM.updateBillingMUNLock", M);
        }


        ///// <summary>
        ///// 插入主档信息
        ///// </summary>
        ///// <param name="BM"></param>
        ///// <returns></returns>
        //public int insertBillingM(BillingM BM)
        //{
        //    int i = 0;
        //    try
        //    {
        //        i = Convert.ToInt32(GetMapper().Insert("BillM.insertBillingM", BM));
        //    }
        //    catch (OracleException oe)
        //    {
        //        if (oe.Number == 1)//主键重复
        //        {
        //            i = 1;
        //        }
        //        else if (oe.Number == 12543)//数据库链接断开
        //        {
        //            throw new InterfaceException(InterfaceExceptionType.ReTry, oe.Message);
        //        }
        //    }
        //    return i;
        //}


        /// <summary>
        /// 插入主档和明细
        /// </summary>
        /// <param name="noticeM"></param>
        public bool insertBillingMD(BillingM BM)
        {
            //bool result = true;
            //ISqlMapper map = GetMapper();
            //map.BeginTransaction();
            //try
            //{
            //    //插入单据主档
            //    map.Insert("BillM.insertBillingM", BM);
            //    //指插入单据明细
            //    IDictionary dt = new Dictionary<string, IList>();
            //    dt.Add("listItem", BM.dList);
            //    map.Insert("BillD.insertBillingD", dt);

            //    map.CommitTransaction();
            //}
            //catch (OracleException oe)
            //{
            //    if (oe.Number == 1)//主键重复
            //    {
            //        result = true;
            //    }
            //    else if (oe.Number == 12543)//数据库链接断开
            //    {
            //        map.RollBackTransaction();
            //        throw new InterfaceException(InterfaceExceptionType.ReTry, oe.Message);
            //    }
            //    map.RollBackTransaction();
            //}
            //catch (Exception ex) 
            //{
            //    result = false;
            //    map.RollBackTransaction();
            //    throw new InterfaceException(InterfaceExceptionType.NoReTry, ex.Message);
            //}
            //return result;

            bool result = false;
            ISqlMapper map = GetMapper();
            //开启事务
            map.BeginTransaction();
            try
            {
                //新增销售订单主档
                map.Insert("BillM.insertBillingM", BM);
                //新增销售订单明细
                IDictionary dt = new Dictionary<string, IList>();
                dt.Add("listItem", BM.dList);
                map.Insert("BillD.insertBillingD", dt);

                //提交事务
                map.CommitTransaction();
                //执行成功
                result = true;
            }
            catch (Exception ex)
            {
                //执行失败
                result = false;
                //回滚事务
                map.RollBackTransaction();
                //抛出异常，回传给上游系统
                throw new InterfaceException(InterfaceExceptionType.NoReTry, ex.Message);
            }
            return result;
        }
    }
}
