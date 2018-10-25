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
    //同步销售平台接口
    class OrderTBServiceImpl : IOrderHandle
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
                Logger.WritingLog("OrderTBService.getObj()数据转换异常！");
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
            string msg = "";
            BillingM m = (BillingM)getObj(objson);
            Logger.WritingLog("订单同步销售平台=>订单号：" + m.djbh);//记录取消日志
            IBillingMDao dao = new BillingMDaoImpl();
            int r = dao.updateBillingMTB(m);
            if (r > 0)
            {
                if (m.isdelivered == 1)
                {
                    Logger.WritingLog("单据" + m.djbh + "同步销售平台成功！");
                    Logger.WriteLog(m.djbh, "SYS", 130, "同步销售平台成功");
                }
                else
                {
                    Logger.WritingLog("单据" + m.djbh + "同步销售平台失败！");
                    Logger.WriteLog(m.djbh, "SYS", 130, "同步销售平台失败");
                }  
            }
            else
            {
                msg = "订单" + m.djbh + "执行同步销售平台失败！";
                Logger.WritingLog(msg);//同步销售平台日志
                throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
            }
        }
    }
}
