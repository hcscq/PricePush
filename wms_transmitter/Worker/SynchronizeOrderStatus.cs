//#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wms_transmitter.Domain;
using wms_transmitter.Common;
using System.Windows.Forms;
using wms_transmitter.VO;
using System.Web.Script.Serialization;
using wms_transmitter.Dao.Impl;

namespace wms_transmitter.Worker
{
    //更改订单状态
    class SynchronizeOrderStatus
    {
        StateUpdateBillDaoImpl staUp = new StateUpdateBillDaoImpl();

        /// <summary>
        /// 上传信息
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string startWork()
        {
            string re = "";
            try
            {//1、回传订单状态
                if (ComonUtil.g_IsStaFinish)
                {
                    ComonUtil.g_IsStaFinish = false;

                    ValObj vo = new ValObj();
                    vo.rowNum = Convert.ToInt32(ComonUtil.packSize);
                    vo.orderFrom = "1";
                    var sls = staUp.getBillState(vo);
                    if (sls == null || sls.Count == 0) { ComonUtil.g_IsStaFinish = true;  }
                    else{
                        SerResponse serRe = ObjConvertUtil.Json2Object<SerResponse>
                            (re = DoPost(ComonUtil.serviceUrl, "upBillState", ObjConvertUtil.Object2Json(sls)));
                        //serRe = ObjConvertUtil.Json2Object<serResponse>("{\"Response\":[{\"OrderId\":\"D232111\",\"Success\":true,\"Message\":\"Success\"},{\"OrderId\":\"D596111\",\"Success\":false,\"Message\":\"Success\"}],\"Message\":\"\",\"Success\":\"true\"}");
                        if (serRe.Success)//success
                        {
                            staUp.updateBillState(serRe.Response.Where(it => it.Success).ToList());
                            staUp.updateBillOperDate(serRe.Response.Where(it => !it.Success).ToList(), "StateUpdateBill.updateOperDate");
                        }
    #if DEBUG
                        Logger.WritingLog((new StringBuilder()).Append(re).Append("\r\n").ToString());
    #endif
                        ComonUtil.g_IsStaFinish = true;
                    }
                }
                else
                {
                    re += "updateBillState skipped.";
                    Logger.WritingLog(re);
                }
            }
            catch (Exception e1)
            {
                re += e1.Message;
                ComonUtil.g_IsStaFinish = true;
                Logger.WritingLog((new StringBuilder()).Append(e1.Message).Append("\r\n").Append("  返回信息：").Append(re).ToString());
            }

            try
            {//2、回传订单
                if (ComonUtil.g_IsOBillFinish)
                {
                    ComonUtil.g_IsOBillFinish = false;
                    
                    var sls = getOutBill();
                    if (sls == null || sls.Count == 0) { ComonUtil.g_IsOBillFinish = true; }
                    else{
                        var aa = ObjConvertUtil.Object2Json(sls);
                        SerResponse serRe = ObjConvertUtil.Json2Object<SerResponse>
                            (re = DoPost(ComonUtil.serviceUrl, "upOutBill", ObjConvertUtil.Object2Json(sls)));

                        if (serRe.Success)//success
                        {
                            staUp.updateBillOperDate(serRe.Response.Where(it => !it.Success).ToList(), "StateUpdateBill.updateOOperDate");
                            staUp.updateOutBill(serRe.Response.Where(it => it.Success).ToList());
                        }
    #if DEBUG
                        Logger.WritingLog((new StringBuilder()).Append(re).Append("\r\n").ToString());
    #endif
                        ComonUtil.g_IsOBillFinish = true;
                    }
                }
                else
                {
                    re += "updateOutBill skipped.";
                    Logger.WritingLog(re);
                }
            }
            catch (Exception e1)
            {
                re += e1.Message;
                ComonUtil.g_IsOBillFinish = true;
                Logger.WritingLog((new StringBuilder()).Append(e1.Message).Append("\r\n").Append("  返回信息：").Append(re).ToString());
            }

            try 
            {//3、回传退货单
                if (ComonUtil.g_IsRefundBillFinish)
                {
                    ComonUtil.g_IsRefundBillFinish = false;
                    staUp.updateToThree();
                    var sls = getRefundBill();
                    if (sls == null || sls.Count == 0) { ComonUtil.g_IsRefundBillFinish = true; }
                    else{
                        var aa = ObjConvertUtil.Object2Json(sls);
                        SerResponse serRe = ObjConvertUtil.Json2Object<SerResponse>
                            (re = DoPost(ComonUtil.serviceUrl, "upRetBill", ObjConvertUtil.Object2Json(sls)));

                        if (serRe.Success)//success
                        {
                            staUp.updateBillOperDate(serRe.Response.Where(it => !it.Success).ToList(), "StateUpdateBill.updateRefundOperDate");
                            staUp.updateRefundBill(serRe.Response.Where(it => it.Success).ToList());
                        }
    #if DEBUG
                        Logger.WritingLog((new StringBuilder()).Append(re).Append("\r\n").ToString());
    #endif
                        ComonUtil.g_IsRefundBillFinish = true;
                    }
                }
                else
                {
                    re += "updateRefundBill skipped.";
                    Logger.WritingLog(re);
                }
            }
            catch(Exception e1)
            {
                re += e1.Message;
                ComonUtil.g_IsRefundBillFinish = true;
                Logger.WritingLog((new StringBuilder()).Append(e1.Message).Append("\r\n").Append("  返回信息：").Append(re).ToString());
            }
            return re;
        }


        /// <summary>
        /// 获取出库订单列表
        /// </summary>
        /// <returns></returns>
        public List<SendOutOrderM> getOutBill()
        {
            ValObj vo = new ValObj();
            vo.rowNum = Convert.ToInt32(ComonUtil.packSize);
            vo.orderFrom = "1";
            List<SendOutOrder> l = staUp.getOutBill(vo);
            SendOutOrderM om;
            SendOutOrderD od;
            List<SendOutOrderM> omlist = new List<SendOutOrderM>();
            var loc_l = l.GroupBy(t => t.DJBH).Distinct().ToList();
            List<SendOutOrder> loc_soa;
            if (l != null && l.Count > 0)
            {
                for (int i = 0; i < loc_l.Count(); i++)
                {
                    loc_soa = l.Where(it => it.DJBH == loc_l[i].Key).ToList();
                    om = new SendOutOrderM();
                    om.DJBH = loc_soa[0].DJBH;
                    om.ADDRES = loc_soa[0].ADDRES;
                    om.BUNICK = loc_soa[0].AMOUNT;
                    om.CANAME = loc_soa[0].CANAME;
                    om.CACODE = loc_soa[0].CACODE;
                    om.CITYCO = loc_soa[0].CITYCO;
                    om.CITYNA = loc_soa[0].CITYNA;
                    om.CODE_NUMBER = loc_soa[0].CODE_NUMBER;
                    om.CUSTNA = loc_soa[0].CUSTNA;
                    om.DDLX = loc_soa[0].DDLX;
                    om.DISTCO = loc_soa[0].DISTCO;
                    om.DISTNA = loc_soa[0].DISTNA;
                    om.FROMTY = loc_soa[0].FROMTY;
                    om.KHBZ = loc_soa[0].KHBZ;
                    om.KPLB = loc_soa[0].KPLB;
                    om.LXFS = loc_soa[0].LXFS;
                    om.MOBIL = loc_soa[0].MOBIL;
                    om.PROVCO = loc_soa[0].PROVCO;
                    om.PROVNA = loc_soa[0].PROVNA;
                    om.PSLX = loc_soa[0].PSLX;
                    om.RECENA = loc_soa[0].RECENA;
                    om.RQ = loc_soa[0].RQ;
                    om.RY_CZY = loc_soa[0].RY_CZY;
                    om.SHDZ = loc_soa[0].SHDZ;
                    om.SHOPNA = loc_soa[0].SHOPNA;
                    om.SHR = loc_soa[0].SHR;
                    om.THFS = loc_soa[0].THFS;
                    om.THSJ = loc_soa[0].THSJ;
                    om.WHCODE = loc_soa[0].WHCODE;
                    om.XSLX = loc_soa[0].XSLX;
                    for (int j = 0; j < loc_soa.Count; j++)
                    {
                        od = new SendOutOrderD();
                        od.AMOUNT = loc_soa[j].AMOUNT;
                        od.CONTENT = loc_soa[j].CONTENT;
                        od.DJ = loc_soa[j].DJ;
                        od.DJ_SORT = loc_soa[j].DJ_SORT;
                        od.DJ_XS = loc_soa[j].DJ_XS;
                        od.DJBH = loc_soa[j].DJBH;
                        od.INVOICEID = loc_soa[j].INVOICEID;
                        od.INVOICENO = loc_soa[j].INVOICENO;
                        od.INVOICETYPE = loc_soa[j].INVOICETYPE;
                        od.JE = loc_soa[j].JE;
                        od.JE_HS = loc_soa[j].JE_HS;
                        od.JS = loc_soa[j].JS;
                        od.KL = loc_soa[j].KL;
                        od.LSJ = loc_soa[j].LSJ;
                        od.LSS = loc_soa[j].LSS;
                        od.PH = loc_soa[j].PH;
                        od.PHCLFS = loc_soa[j].PHCLFS;
                        od.SE = loc_soa[j].SE;
                        od.SKUCODE = loc_soa[j].SKUCODE;
                        od.SL = loc_soa[j].SL;
                        od.SLV = loc_soa[j].SLV;
                        od.SPID = loc_soa[j].SPID;
                        od.TITLE = loc_soa[j].TITLE;
                        od.XQYQ = loc_soa[j].XQYQ;

                        om.orderDList.Add(od);
                    }
                    loc_soa.Clear();
                    omlist.Add(om);
                }
            }
            return omlist;
        }


        /// <summary>
        /// 获取退货订单列表
        /// </summary>
        /// <returns></returns>
        public List<RefundBill_M> getRefundBill()
        {
            ValObj vo = new ValObj();
            vo.rowNum = Convert.ToInt32(ComonUtil.packSize);
            vo.orderFrom = "1";
            List<RefundBill> l = staUp.getRefundBill(vo);
            RefundBill_M om;
            RefundBill_D od;
            List<RefundBill_M> omlist = new List<RefundBill_M>();
            var loc_l = l.GroupBy(t => t.DJBH).Distinct().ToList();
            List<RefundBill> loc_soa;
            if (l != null && l.Count > 0)
            {
                foreach (var item in loc_l)
                {
                    loc_soa = l.Where(it => it.DJBH == item.Key).ToList();
                    om = new RefundBill_M();
                    om.DJBH = loc_soa[0].DJBH;
                    om.BMID = loc_soa[0].BMID;
                    om.DJBH_SJ = loc_soa[0].DJBH_SJ;
                    om.DWID = loc_soa[0].DWID;
                    om.RQ = loc_soa[0].RQ;
                    om.RY_CZY = loc_soa[0].RY_CZY;
                    om.RY_FUHY = loc_soa[0].RY_FUHY;
                    om.RY_SHOUHY = loc_soa[0].RY_SHOUHY;
                    om.RY_YWY = loc_soa[0].RY_YWY;
                    om.RY_ZJY = loc_soa[0].RY_ZJY;
                    om.SF_ZX = loc_soa[0].SF_ZX;
                    om.THLB = loc_soa[0].THLB;
                    om.YZID = loc_soa[0].YZID;
                    om.EXPRESSCODE = loc_soa[0].EXPRESSCODE;
                    om.EXPRESSNAME = loc_soa[0].EXPRESSNAME;
                    om.EXPRESSNUMBER = loc_soa[0].EXPRESSNUMBER;
                    om.SF_YBTH = loc_soa[0].SF_YBTH;
                    foreach (var it in loc_soa)
                    {
                        od = new RefundBill_D();
                        od.DJ = it.DJ;
                        od.DJ_SORT = it.DJ_SORT;
                        od.DJ_SORT_SJ = it.DJ_SORT_SJ;
                        od.DJ_XS = it.DJ_XS;
                        od.DJBH = it.DJBH;
                        od.DJBH_SJ = it.DJBH_SJ;
                        od.JE = it.JE;
                        od.PH = it.PH;
                        od.RQ_SC = it.RQ_SC;
                        od.SL = it.SL;
                        od.SPID = it.SPID;
                        od.THYY = it.THYY;
                        od.YSPD = it.YSPD;
                        od.YXQZ = it.YXQZ;
                        od.YZID = it.YZID;
                        od.SPBH = it.SPBH;
                        om.detialList.Add(od);
                    }
                    loc_soa.Clear();
                    omlist.Add(om);
                }
            }
            return omlist;
        }


        /// <summary>
        /// 编码传输字符串
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="action">动作</param>
        /// <param name="json">传送的json 数据</param>
        /// <returns></returns>
        string DoPost(string url, string action, string json)
        {
            Dictionary<string, string> loc_p = new Dictionary<string, string>();

            loc_p.Add("key", Properties.Settings.Default.key.Split(',')[0]);//"123"
            loc_p.Add("action", action);
            loc_p.Add("time", DateTime.Now.ToString());//"2015-08-07 10:01:00"
            loc_p.Add("data", json);

            string str = loc_p["key"] + Properties.Settings.Default.screct + action + loc_p["time"] + json;
            string signStr = ComonUtil.Sign(str);
            loc_p.Add("sign", signStr);
            return WebUtil.DoPost(url, loc_p);
        }

    }
}
