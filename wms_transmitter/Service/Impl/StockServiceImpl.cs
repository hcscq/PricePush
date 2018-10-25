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

    //库存查询接口（暂时不用）
    class StockServiceImpl : IOrderHandle
    {
        /// <summary>
        /// 解析请求报文 
        /// </summary>
        /// <typeparam name="XsckBill"></typeparam>
        /// <param name="objson"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public Object getObj(string objson)
        {
            string[] spids = null;
            try
            {
                spids = ObjConvertUtil.Json2Object<string[]>(objson);
            }
            catch
            {
                //写入日志 下同
                Logger.WritingLog("StockServiceImpl.getObj()数据转换异常！");
                throw new InterfaceException(InterfaceExceptionType.NoReTry, "查询异常！");
            }
            return spids;
        }

        /// <summary>
        /// 业务处理方法
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public void doHandle(string objson, Tesla.Net.SimpleResponse response)
        {
            #region 原来代码 测试完成后取消注释
            //解析请求数据
            string[] spbhs = (string[])getObj(objson);
            try
            {
                string resultStr = string.Empty;
                IStockDao isd = new StockDaoImpl();

                //查询数据 spids：商品编号数组
                List<Stock> lists = isd.StockQuery(spbhs);
                if (lists != null) //数据返回正常
                {
                    resultStr = ObjConvertUtil.Object2Json(lists);
                    response.Write(resultStr);
                }
                else  //查询异常
                {
                    //写入异常日志 下同
                    Logger.WritingLog("StockServiceImpl.doHandle()查询异常！");
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
            ////解析请求数据


                
            //    string temp = string.Empty;
            //    IStockDao isd = new StockDaoImpl();

            //    //查询数据 spids：商品编号数组
            //    List<Stock> lists = isd.StockQuery(null);
            //    if (lists != null) //数据返回正常
            //    {
            //        temp = ObjConvertUtil.Object2Json(lists);
            //        response.Write(temp);
            //    }
            //    else  //查询异常
            //    {
            //        //写入异常日志 下同
            //        Logger.WritingLog("StockServiceImpl.doHandle()查询异常！");
            //        //外抛异常
            //        throw new InterfaceException(InterfaceExceptionType.ReTry, "查询异常！");
            //    }
          
            #endregion
            
        }
    }
}
