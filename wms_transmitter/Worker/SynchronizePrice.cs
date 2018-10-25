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
using System.Security.Cryptography;
using wms_transmitter.Models;

namespace wms_transmitter.Worker
{
    class SynchronizePrice
    {
        public KsoaPricePushDaoImpl pushPrice = new KsoaPricePushDaoImpl();
        public event ActionCallEventHandler actionevent;
        public bool bol_closingWnd = false;
        public bool bol_allLog = false;
        public const string actionName = "PricePush";
        /// <summary>
        /// 上传信息
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string startWork()
        {
            string re = "";

            try
            {//1、推送单价信息 
                if (PricePush.g_IsPricePushFinish)
                {
                    pushPrice.newExeTime = pushPrice.newExeTime.AddMinutes(pushPrice.timeSpan);
                    PricePush.g_IsPricePushFinish = false;
                    var sls = pushPrice.getData(pushPrice.selCondition);
                    if (sls == null || sls.Count == 0) { PricePush.g_IsPricePushFinish = true; }
                    else
                    {
                        PriceResponse serRe;
                        /********2018.08.02******************/
                        foreach (var item in PricePush.g_PPConfigList)
                        {
                            actionevent(actionName, PricePush.DataType.TRYTIMES, 1);
                            item.Times.Total++;
                            try
                            {
                                if (bol_allLog) Logger.WritingLog("\t\tTry Send|count<" + item.Name + ">:" + sls.Count().ToString());
                                serRe = ObjConvertUtil.Json2Object<PriceResponse>
                                    (re = DoPostPrice(item.RemoteUrl, actionName, ObjConvertUtil.Object2Json(sls.Select(it => new { ID = it.ID, SPID = it.SPID, SPBH = it.SPBH, HW = it.HW, CHBDJ = it.CHBDJ }).ToList())));
                            }
                            catch (Exception e1)
                            {
                                actionevent(actionName, PricePush.DataType.FAILEDTIMES, 1);
                                item.Times.Failed++;
                                Logger.WritingLog((new StringBuilder()).Append(e1.Message).Append("\r\n").Append("  返回信息：").Append(re).ToString());
                                continue;
                                //throw e1;
                            }
                            if (bol_allLog) Logger.WritingLog(re);
                            if (serRe.Success)//success
                            {
                                if (bol_allLog) Logger.WritingLog("\t\tSend Success|count<" + item.Name + ">:" + serRe.Response.Count().ToString());

                                actionevent(actionName, PricePush.DataType.SUCCESSTIMES, 1);
                                actionevent(actionName, PricePush.DataType.SENDDETIALS, sls.Count());
                                item.Times.Successed++;
                                item.Details.Total += sls.Count();

                                int newStatus = -1;
                                foreach (var it in serRe.Response)
                                {
                                    newStatus = -1;
                                    var loc_it = sls.Find(it1 => it1.ID == it.ID);
                                    int old_status = loc_it.IS_PUSHED;
                                    //it.OldStatus = sls.Find(it1 => it1.ID == it.ID).IS_PUSHED;
                                    if (it.Success)
                                        newStatus = item._Status.Success;
                                    else
                                    {
                                        if (it.status == 2)
                                            newStatus = item._Status.Failed;
                                        else newStatus = item._Status.NotFound;
                                    }

                                    if (old_status == 0)
                                        loc_it.IS_PUSHED = newStatus;
                                    else loc_it.IS_PUSHED = loc_it.IS_PUSHED | newStatus;
                                }

                                var succ = serRe.Response.Where(it => it.Success).ToList();
                                if (bol_allLog) Logger.WritingLog("\t\tSuccess count<" + item.Name + ">:" + succ.Count().ToString());
                                actionevent(actionName, PricePush.DataType.DETIALSSUCCESS, succ.Count());
                                item.Details.Successed += succ.Count();

                                var fail = serRe.Response.Where(it => !it.Success).ToList();
                                if (bol_allLog) Logger.WritingLog("\t\tFailed count<" + item.Name + ">:" + fail.Count().ToString());
                                actionevent(actionName, PricePush.DataType.DETIALSFAILED, fail.Count());
                                item.Details.Failed += fail.Count();
                                //inital|PDC S  |PDC F  |PDC NF |
                                //  0   |   1   |   2   |   4   |   8   |   16  |   32  |
                                //pushPrice.update(succ, PricePush.PushResult.SUCCESS);

                                if (bol_allLog) Logger.WritingLog("\t\tFailed count(Failed)<" + item.Name + ">:" + fail.Where(it => it.status == 2).Count().ToString());
                                //pushPrice.update(fail.Where(it => it.status == 2).ToList(), PricePush.PushResult.FAILED);
                                if (bol_allLog) Logger.WritingLog("\t\tFailed count(Not Exist)<" + item.Name + ">:" + fail.Where(it => it.status == 1).Count().ToString());
                                //pushPrice.update(fail.Where(it => it.status == 1).ToList(), PricePush.PushResult.NOTFINDGOODS);
                            }
                            else
                            {
                                if (bol_allLog) Logger.WritingLog("\t\tSend Failed|count:<" + item.Name + ">" + sls.Count().ToString());
                                actionevent(actionName, PricePush.DataType.FAILEDTIMES, 1);
                                item.Times.Failed++;
                            }

                        }
                        using (BIW_KSOAContext dbcontext = new BIW_KSOAContext())
                        {
                            var list = sls.Select(it => it.ID).ToList();
                            var query = from q in dbcontext.price_Data
                                        where list.Contains(q.ID)
                                        select q;
                            foreach (var it in query)
                            {
                                it.is_pushed = sls.Find(it1 => it1.ID == it.ID).IS_PUSHED;
                                it.lastModifyTime = DateTime.Now;
                                it.LastUploadTime = DateTime.Now;
                            }
                            dbcontext.SaveChanges();
                        }
                        //pushPrice.update(sls);
                        /***********************************/
#if DEBUG
                        //Logger.WritingLog((new StringBuilder()).Append(re).Append("\r\n").ToString());
#endif
                        PricePush.g_IsPricePushFinish = true;
                    }
                }
                else
                {
#if DEBUG
                    re += "Price push skipped.";
                    Logger.WritingLog(re);
#endif
                }
            }
            catch (Exception e1)
            {
                re += e1.Message;

                PricePush.g_IsPricePushFinish = true;
                Logger.WritingLog((new StringBuilder()).Append(e1.Message).Append("\r\n").Append("  返回信息：").Append(re).ToString());
            }
            if (bol_closingWnd)
                actionevent(actionName, PricePush.DataType.CLOSEWINDOW, -1);
            return re;
        }


        /// <summary>
        /// 编码传输字符串
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="action">动作</param>
        /// <param name="json">传送的json 数据</param>
        /// <returns></returns>
        private string DoPost(string url, string action, string json)
        {
            Dictionary<string, string> loc_p = new Dictionary<string, string>();

            loc_p.Add("key", Properties.Settings.Default.key.Split(',')[1]);//"1234"
            loc_p.Add("action", action);
            loc_p.Add("time", DateTime.Now.ToString());//"2015-08-07 10:01:00"
            loc_p.Add("data", json);

            string str = loc_p["key"] + Properties.Settings.Default.screct + action + loc_p["time"] + json;
            string signStr = ComonUtil.Sign(str);
            loc_p.Add("sign", signStr);
            return WebUtil.DoPost(url, loc_p);
        }
        //DoPostPrice
        private string DoPostPrice(string url, string action, string json)
        {
            Dictionary<string, string> loc_p = new Dictionary<string, string>();
            string str = "";
            loc_p.Add("ts",DateTime.Now.Ticks.ToString());//"2015-08-07 10:01:00"
            loc_p.Add("action", action);
            loc_p.Add("data", json);
            loc_p.Add("key", Properties.Settings.Default.key.Split(',')[1]);//"1234"
            loc_p.Add("time", DateTime.Now.ToString());
            //loc_p.Add("test","test");
            str= "private_key=goodsapi@7lk.com&" +WebUtil.BuildQuery(loc_p);


            MD5 md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                result.Append(bytes[i].ToString("X2"));
            }
            string signStr = result.ToString();
            loc_p.Add("sign", signStr.ToLower());
            loc_p.Remove("private_key");
            string aadha= WebUtil.DoPost(url, loc_p);
            return aadha;// WebUtil.DoPost(url, loc_p);
        }
    }
}
