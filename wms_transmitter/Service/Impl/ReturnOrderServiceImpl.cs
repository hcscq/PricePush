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
    //销售退货接口
    class ReturnOrderServiceImpl : IOrderHandle
    {
        public object getObj(string objson)
        {
            try
            {
                SendReturnOrdersRequest ro = ObjConvertUtil.Json2Object<SendReturnOrdersRequest>(objson);
                return ObjConvertUtil.ReturnOrder2Notice(ro);
            }
            catch
            {
                string err = "SendReturnOrdersRequest转换对象为空！";
                Logger.WritingLog(err);
                throw new InterfaceException(err);
            }
        }


        public void doHandle(string objson, Tesla.Net.SimpleResponse response)
        {
            NoticeM m = (NoticeM)getObj(objson);
            if (m != null)
            {
                Logger.WritingLog("退货单据：" + m.djbh);

                ValObj vo = new ValObj();
                ICommonDao IDao = new CommonDaoImpl();
                string spid;
                string shopna;
                for (int i = 0; i < m.dList.Count; i++)
                {
                    vo.spbh = m.dList[i].spid;//管易下传的是“商品编号”
                    spid = IDao.QueryGoods(vo);
                    if (spid == null || spid == "") throw new InterfaceException(InterfaceExceptionType.NoReTry, "退货单据" + m.djbh + "的商品编号" + vo.spbh + "不存在！"); 
                    m.dList[i].spid = spid;
                }
                INoticeMDao dao = new NoticeMDaoImpl();
                if (dao.insertNoticeMD(m))
                {
                    Logger.WritingLog("退货单" + m.djbh + "接收成功！");
                    Logger.WriteLog(m.djbh, "ReturnOrderService", 10, "退货单下传");//记录操作日志
                }
                else
                {
                    Logger.WritingLog("退货单" + m.djbh + "接收失败！");
                }
            }
        }
    }
}
