using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBatisNet.DataMapper;
using wms_transmitter.Domain;
using wms_transmitter.Dao;
using wms_transmitter.Dao.Impl;
using wms_transmitter.VO;
using wms_transmitter.Common;

namespace wms_transmitter.Service.Impl
{
    //退货订单取消接口
    class CancelReturnOrderServiceImpl : IOrderHandle
    {
        public object getObj(string objson) 
        {
            try
            {
                return ObjConvertUtil.Json2Object<CancelReturnOrdeRequest>(objson);
            }
            catch
            {
                string err = "CancelReturnOrdeRequest转换对象为空！";
                Logger.WritingLog(err);
                throw new InterfaceException(err);
            }
        }


        public void doHandle(string objson, Tesla.Net.SimpleResponse response)
        {
            CancelReturnOrdeRequest cr = (CancelReturnOrdeRequest)getObj(objson);
            Logger.WritingLog("开始取消退货单：" + cr.ReturnOrderId);

            INoticeMDao nmDao = new NoticeMDaoImpl();
            int r = nmDao.cancelNoticeM(cr.ReturnOrderId);
            if (r > 0)
            {
                Logger.WritingLog("退货单" + cr.ReturnOrderId + "取消成功！");
            }
            else
            {
                Logger.WritingLog("退货单" + cr.ReturnOrderId + "取消失败！");
                throw new InterfaceException(InterfaceExceptionType.NoReTry, "单据取消失败！");
            }
        }
    }
}
