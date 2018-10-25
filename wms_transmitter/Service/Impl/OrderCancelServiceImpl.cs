using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wms_transmitter.Domain;
using wms_transmitter.Common;
using wms_transmitter.VO;
using wms_transmitter.Dao;
using wms_transmitter.Dao.Impl;
using System.Windows.Forms;

namespace wms_transmitter.Service.Impl
{
    //订单取消接口
    public class OrderCancelServiceImpl : IOrderHandle
    {
        /// <summary>
        /// 解析出报文对象
        /// </summary>
        /// <typeparam name="XsckBill"></typeparam>
        /// <param name="objson"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public object getObj(string objson)
        {
            try
            {
                OrderRequest ro = ObjConvertUtil.Json2Object<OrderRequest>(objson);
                return ObjConvertUtil.Order2BillMObj(ro);
            }
            catch (Exception)
            {
                Logger.WritingLog("OrderCancelServiceImpl.getObj()数据转换异常！");
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
            BillingM m = (BillingM)getObj(objson);
            ValObj vo = new ValObj();
            vo.djbh = m.djbh;
            Logger.WritingLog("订单取消=>订单号：" + m.djbh);//记录取消日志
            IBillingMDao Dao = new BillingMDaoImpl();
            int count = Dao.QueryOrder(vo);

            string msg = "";
            if (count == 0)
            {
                int counthty = Dao.QueryOrderHty(vo);
                if (counthty > 0)
                {
                    string statusHty = Dao.QueryCancelStatusHty(vo);
                    if (statusHty == "Y")
                    {
                        msg = "单据" + vo.djbh + "已是订单取消状态！";
                        Logger.WritingLog(msg);
                        throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                    }
                    else
                    {
                        msg = "单据" + vo.djbh + "在WMS已经转历史数据，请检查数据！";
                        Logger.WritingLog(msg);
                        throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                    }
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
                msg = "单据" + vo.djbh + "已是订单取消状态！";
                Logger.WritingLog(msg);
                throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
            }
            string status = Dao.QueryOrderStatus(vo);
            if (status != "E" && status != "C" && Convert.ToInt32(status) >= 8)
            {
                msg = "单据" + vo.djbh + "已是发货状态不能取消！";
                Logger.WritingLog(msg);
                throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
            }
            IBillingMDao dao = new BillingMDaoImpl();
            int r = dao.updateBillingMCancel(m);
            if (r > 0)
            {
                Logger.WritingLog("订单" + m.djbh + "取消成功！");//记录取消日志
                Logger.WriteLog(m.djbh, "SYS", 110, "订单取消");
            }
            else
            {
                msg = "订单" + m.djbh + "取消失败！";
                Logger.WritingLog(msg);//记录取消日志
                throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
            }
        }
    }
}
