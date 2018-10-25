using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wms_transmitter.Domain;
using wms_transmitter.Common;
using wms_transmitter.VO;
using wms_transmitter.Dao;
using wms_transmitter.Dao.Impl;

namespace wms_transmitter.Service.Impl
{
    //订单解锁接口
    class OrderUNLockServiceImpl : IOrderHandle
    {
        /// <summary>
        /// 解析出报文对象
        /// </summary>
        /// <typeparam name="XsckBill"></typeparam>
        /// <param name="objson"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public Object getObj(string objson)
        {
            try
            {
                OrderRequest ro = ObjConvertUtil.Json2Object<OrderRequest>(objson);
                return ObjConvertUtil.Order2BillMObj(ro);
            }
            catch (Exception)
            {
                Logger.WritingLog("OrderInterceptServiceImpl.getObj()数据转换异常！");
                throw new InterfaceException("OrderRequest转换对象失败！");
            }
        }

        /// <summary>
        /// 业务处理方法
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public void doHandle(string objson, Tesla.Net.SimpleResponse response)
        {
            BillingM bm = (BillingM)getObj(objson);
            Logger.WritingLog("订单解锁=>订单号：" + bm.djbh);//记录解锁日志
            string msg = "";
            ValObj vo = new ValObj();
            vo.djbh = bm.djbh;
            IBillingMDao Dao = new BillingMDaoImpl();
            
            int count = Dao.QueryOrder(vo);
            if (count == 0)
            {
                int counthty = Dao.QueryOrderHty(vo);
                if (counthty > 0)
                {
                    msg = "单据" + vo.djbh + "在WMS已经转历史数据，请检查数据！";
                    Logger.WritingLog(msg);
                    throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                }
                else
                {
                    msg = "单据" + vo.djbh + "在WMS查询不存在！";
                    Logger.WritingLog(msg);
                    throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                }
            }
            string cancel = Dao.QueryCancelStatus(vo);
            if (cancel == "Y")
            {
                msg = "单据" + vo.djbh + "已是订单取消状态不能解锁！";
                Logger.WritingLog(msg);
                throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
            }
            string status = Dao.QueryOrderStatus(vo);
            if (status != "E" && status != "C" && Convert.ToInt32(status) >= 8)
            {
                msg = "单据" + bm.djbh + "已是发货状态不能解锁！";
                Logger.WritingLog(msg);
                throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
            }
            ITaskMDao dao = new TaskMDaoImpl();
            int r = Dao.updateBillingMUNLock(bm);
            if (r > 0)
            {
                Logger.WritingLog("订单" + bm.djbh + "解锁成功！");
                Logger.WriteLog(bm.djbh, "SYS", 121, "订单解锁");
            }
            else
            {
                msg = "订单" + bm.djbh + "解锁失败！";
                Logger.WritingLog(msg);//订单解锁日志
                throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
            }
        }
    }
}
