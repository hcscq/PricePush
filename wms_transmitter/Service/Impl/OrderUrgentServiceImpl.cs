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
    //订单优先级调整接口
    class OrderUrgentServiceImpl : IOrderHandle
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
                Logger.WritingLog("OrderUrgentServiceImpl.getObj()数据转换异常！");
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
            if (m != null)
            {
                ValObj vo = new ValObj();
                vo.djbh = m.djbh;
                Logger.WritingLog("加急单据：" + vo.djbh);
                IBillingMDao Dao = new BillingMDaoImpl();
                string status = Dao.QueryOrderStatus(vo);
                if (status != "E" && Convert.ToInt32(status) >= 8)
                {
                    string msg = "单据" + m.djbh + "已发货不能加急！";
                    Logger.WritingLog(msg);
                    throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                }
                else
                {
                    IBillingMDao dao = new BillingMDaoImpl();
                    int r = dao.updateBillingMUrgent(m);
                    if (r > 0)
                    {
                        Logger.WritingLog("单据" + m.djbh + "加急成功！");
                    }
                    else
                    {
                        string msg = "单据" + m.djbh + "加急失败！";
                        Logger.WritingLog(msg);//单据加急日志
                        throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                    }
                }
            }            
        }
    }
}
