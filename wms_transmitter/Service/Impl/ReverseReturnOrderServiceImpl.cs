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
    //退货订单反审接口
    class ReverseReturnOrderServiceImpl : IOrderHandle
    {
        public object getObj(string objson) 
        {
            try
            {
                return ObjConvertUtil.Json2Object<ReverseReturnOrdeRequest>(objson);
            }
            catch
            {
                string err = "ReverseReturnOrdeRequest转换对象为空！";
                Logger.WritingLog(err);
                throw new InterfaceException(err);
            }
        }


        public void doHandle(string objson, Tesla.Net.SimpleResponse response)
        {
            ReverseReturnOrdeRequest cr = (ReverseReturnOrdeRequest)getObj(objson);
            Logger.WritingLog("开始反审退货单：" + cr.ReturnOrderId);

            INoticeMDao nmDao = new NoticeMDaoImpl();
            int r = nmDao.ReverseNoticeM(cr.ReturnOrderId);
            if (r == 1)
            {
                r = nmDao.ReverseNoticeD(cr.ReturnOrderId);
                if (r > 0)
                {
                    Logger.WritingLog("退货单" + cr.ReturnOrderId + "有商品已收货审核，不能反审！");
                    throw new InterfaceException(InterfaceExceptionType.NoReTry, "单据已收货审核，不能反审！");
                }
                else
                {
                    nmDao.deleteNoticeM(cr.ReturnOrderId);
                    Logger.WritingLog("退货单" + cr.ReturnOrderId + "未收货审核，可以反审！");
                }
            }
            else
            {
                Logger.WritingLog("退货单" + cr.ReturnOrderId + "不存在，不能反审！");
                throw new InterfaceException(InterfaceExceptionType.NoReTry, "单据不存在，不能反审！");
            }
        }
    }
}
