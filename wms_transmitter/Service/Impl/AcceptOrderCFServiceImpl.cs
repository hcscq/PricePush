using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wms_transmitter.Domain;
using wms_transmitter.Common;
using System.Windows.Forms;
using wms_transmitter.VO;
using wms_transmitter.Dao;
using wms_transmitter.Dao.Impl;
using System.Data;

namespace wms_transmitter.Service.Impl
{
    //处方药订单接收
    class AcceptOrderCFServiceImpl : IOrderHandle
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
                SendOrdersRequest order = ObjConvertUtil.Json2Object<SendOrdersRequest>(objson);
                return ObjConvertUtil.Order2BillingM(order);
            }
            catch
            {
                string err = "SendOrdersRequest转换对象为空！";
                Logger.WritingLog(err);
                throw new InterfaceException(err);
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
            bm.opform = "2";//订单来源平台(处方药)
            Logger.WritingLog("（处方药）订单接收=>订单号：" + bm.djbh);//记录接收日志

            ValObj vo = new ValObj();
            ICommonDao Dao = new CommonDaoImpl();
            IBillingMDao MDao = new BillingMDaoImpl();
            string spid;
            string shopna;
            string shortaddress;
            string djbh;
            string sememo;
            string msg = "";

            try
            {
                if (bm.iscod == 1)
                {
                    if (bm.codmoney <= 0)
                    {
                        msg = "订单" + bm.djbh + "货到付款订单金额为零，请检查订单数据！";
                        Logger.WritingLog(msg);
                        throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                    }
                }
                if (bm.codmoney > 0)
                {
                    bm.iscod = 1;
                }
                vo.cacode = bm.cacode;
                if (bm.waybill.Length > 0)
                {
                    vo.dylx = "DZ";
                    if (bm.iscod == 1)
                    {
                        vo.iscod = 1;
                    }
                    else
                    {
                        vo.iscod = 0;
                    }
                }
                else
                {
                    vo.dylx = "PT";
                    if (bm.iscod == 1)
                    {
                        vo.iscod = 1;
                    }
                    else
                    {
                        vo.iscod = 0;
                    }
                }
                bm.groupcode = Dao.QueryPhysicalId(vo);
                bm.caname = Dao.QueryPhysicalName(vo);
                if (bm.groupcode == "" || bm.groupcode == null)
                {
                    msg = "订单" + bm.djbh + "物流商不存在！";
                    Logger.WritingLog(msg);
                    throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                }
                bm.callstatus = vo.dylx;



                vo.shopno = bm.shopno;
                //shopna = Dao.QueryShop(vo);
                //if (shopna == "" || shopna == null)
                //{
                //    msg = "订单" + bm.djbh + "店铺不存在！";
                //    Logger.WritingLog(msg);
                //    throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                //}
                //bm.shopna = shopna;
                bm.shopna = bm.shopno;

                string strx = bm.sememo;
                System.Text.RegularExpressions.Regex regx = new System.Text.RegularExpressions.Regex(@"[\s\S]*#>([^$>#]*)\$([^<#]*)<#");
                System.Text.RegularExpressions.Match mx = regx.Match(strx);
                if (mx.Success)
                {
                    shortaddress = mx.Groups[1].Value;
                }
                else
                {
                    shortaddress = "";
                }
                bm.short_address = shortaddress;

                sememo = bm.sememo;
                if (bm.sememo.Length >= 200)
                {
                    sememo = bm.sememo.Substring(0, 200);
                }
                bm.sememo = sememo;

                vo.djbh = bm.djbh;
                //djbh = Dao.QueryBillingM(vo);
                //if (djbh != null)
                //{
                //    msg = "（处方药）订单" + bm.djbh + "已经存在！";
                //    Logger.WritingLog(msg);
                //    throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                //}
                int count = MDao.QueryOrder(vo);
                int counthty = MDao.QueryOrderHty(vo);
                if (count > 0)
                {
                    msg = "单据" + vo.djbh + "已经存在！";
                    Logger.WritingLog(msg);
                    throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                }
                if (counthty > 0)
                {
                    msg = "单据" + vo.djbh + "在WMS已经转历史数据，请检查数据！";
                    Logger.WritingLog(msg);
                    throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                }

                if (bm.callstatus == "DZ")
                {
                    if (bm.waybill == null || bm.waybill == "")
                    {
                        msg = "（处方药）订单" + bm.djbh + "运单号不能为空！";
                        Logger.WritingLog(msg);
                        throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                    }
                }

                for (int i = 0; i < bm.dList.Count; i++)
                {
                    vo.spbh = bm.dList[i].spid;
                    vo.djbh = bm.dList[i].djbh;
                    spid = Dao.QueryGoods(vo);
                    if (spid == "" || spid == null)
                    {
                        msg = "（处方药）订单" + bm.djbh + "商品" + vo.spbh + "不存在！";
                        Logger.WritingLog(msg);
                        throw new InterfaceException(InterfaceExceptionType.NoReTry, msg);
                    }
                    bm.dList[i].spid = spid;
                }
                IBillingMDao billDao = new BillingMDaoImpl();
                if (billDao.insertBillingMD(bm))
                {
                    Logger.WritingLog("（处方药）订单" + bm.djbh + "接收成功！");//记录接收日志
                    Logger.WriteLog(bm.djbh, "AcceptOrderCFService", 10, "（处方药）订单下传");//记录操作日志
                }
                else
                {
                    Logger.WritingLog("（处方药）订单" + bm.djbh + "接收失败！");//记录接收日志
                    throw new InterfaceException(InterfaceExceptionType.NoReTry, "订单" + bm.djbh + "数据库插入失败！");
                }
            }
            catch (Exception e)
            {
                msg = "（处方药）订单" + bm.djbh + "接收失败！";
                Logger.WritingLog(msg);//记录接收日志
                throw new InterfaceException(InterfaceExceptionType.NoReTry, msg + ';' + e.Message);
            }
        }

    }
}
