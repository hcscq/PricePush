using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace wms_transmitter.Service.Impl
{
    using wms_transmitter.Common;
    using wms_transmitter.Dao;
    using wms_transmitter.Dao.Impl;
    using wms_transmitter.Domain;

    //订单状态查询接口（暂时没用）
    public class QueryOrderStatusServiceImpl : IOrderHandle
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
            string[] jzzts = null;
            try
            {
                jzzts = ObjConvertUtil.Json2Object<string[]>(objson);
            }
            catch
            {
                //写入日志 下同
                Logger.WritingLog("QueryOrderStatusServiceImpl.getObj()数据转换异常！");
                throw new InterfaceException("OrderRequest转换对象失败！");
            }
            return jzzts;
        }

        /// <summary>
        /// 业务处理方法
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public void doHandle(string objson, Tesla.Net.SimpleResponse response)
        {
            #region 原来代码 测试完成后取消注释
            string[] djbhs = (string[])getObj(objson);
            //数据解析异常
            try
            {
                string tempResult = string.Empty;
                IQueryOrderStatusDao iosd = new QueryOrderStatusDaoImpl();
                List<QueryOrderStatus> lists = iosd.QueryOrderStatus(djbhs);
                if (lists != null)
                {
                    tempResult = ObjConvertUtil.Object2Json(lists);
                    response.Write(tempResult);
                }
                else  //查询异常
                {
                    //写入异常日志 下同
                    Logger.WritingLog("QueryOrderStatusServiceImpl.doHandle()查询异常！");
                    //外抛异常
                    throw new InterfaceException(InterfaceExceptionType.NoReTry, "查询异常！");
                }
            }
            catch
            {
                Logger.WritingLog("StockServiceImpl.doHandle()系统异常！");
                throw new InterfaceException(InterfaceExceptionType.NoReTry, "系统异常！");
            }
            #endregion


            #region 测试修改 测试完成后删除

            ////数据解析异常
            //try
            //{

            //    string tempResult = string.Empty;
            //    IQueryOrderStatusDao iosd = new QueryOrderStatusDaoImpl();
            //    List<QueryOrderStatus> lists = iosd.QueryOrderStatus(null);
            //    tempResult = ObjConvertUtil.Object2Json(lists);
              
            //}
            //catch
            //{
            //    Logger.WritingLog("StockServiceImpl.doHandle()系统异常！");
            //    throw new InterfaceException(InterfaceExceptionType.ReTry, "系统异常！");
            //}
            #endregion


        }
    }
}
