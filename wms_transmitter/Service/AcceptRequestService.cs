using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using wms_transmitter.Service.Impl;
using System.Timers;
using wms_transmitter.Common;
using System.Collections;
using wms_transmitter.Worker;

namespace wms_transmitter.Service
{
    /// <summary>
    /// HTTP监听服务
    /// </summary>
    class AcceptRequestService
    {
        public event ActionCallEventHandler actionevent;
        public SynchronizePrice syncPrice = new SynchronizePrice();
        public void StartHttp()
        {
            int port = Properties.Settings.Default.Port;
            Tesla.Net.HttpServer http = new Tesla.Net.HttpServer(port);
            http.OnRequest += new Tesla.Net.HttpServer.RequestEvent(http_OnRequest);
            if (!ComonUtil.g_PriceFunForbidon)
            {
                Timer pricePushTimer = new Timer(syncPrice.pushPrice.timeSpan);
                pricePushTimer.AutoReset = true;
                pricePushTimer.Elapsed += new System.Timers.ElapsedEventHandler(timerPro_PushPrice);
                pricePushTimer.Start();
            }
            if (!ComonUtil.g_WMSFunForbidon)
            {
                Timer UpStaTimer = new Timer(ComonUtil.timeSpan);
                UpStaTimer.AutoReset = true;
                UpStaTimer.Elapsed += new System.Timers.ElapsedEventHandler(timerPro_Service);
                UpStaTimer.Start();

                http.Start();
            }
            //http_OnRequest(null,null);//借口测试
        }
        private void timerPro_PushPrice(object obj, System.Timers.ElapsedEventArgs e)
        {
            Timer loc_timer = ((Timer)obj);
            if(loc_timer.Interval!= syncPrice.pushPrice.timeSpan)
                loc_timer.Interval= this.syncPrice.pushPrice.timeSpan;
            if(!syncPrice.pushPrice.Pause)
                syncPrice.startWork();

        }
        private void timerPro_Service(object obj, System.Timers.ElapsedEventArgs e)
        {
            (new SynchronizeOrderStatus()).startWork();//非处方药回传
            (new SynchronizeOrderCFStatus()).startWork();//处方药回传 
            actionevent("OrderState");
        }

        /// <summary>
        /// 请求校验
        /// </summary>
        /// <param name="request"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        IDictionary<string, string> validateReq(Tesla.Net.SimpleRequest request, Tesla.Net.SimpleResponse response)
        {
            if (!ComonUtil.g_WMSFunForbidon)
            {
                string err = "Function forbidon ！";
                Logger.WritingLog(err);
                response.WriteJson(new { Success = false, Message = err });
                return null;
            }
            if (request.Url != Properties.Settings.Default.requestUrl)
            {
                string err = "走错门了！";
                Logger.WritingLog(err);
                response.WriteJson(new { Success = false, Message = err });
                return null;
            }

            IDictionary<string, string> pars = new Dictionary<string, string>();
            string key = request["key"];
            string sign = request["sign"];//加签名校验
            string action = request["action"];
            string time = request["time"];//加超时校验
            string data = request["data"];

            string[] keys = Properties.Settings.Default.key.Split(',');
            if (!keys.Contains(key))
            {
                string err = "key不正确！";
                Logger.WritingLog(err + "[key:"+key+"]");
                response.WriteJson(new { Success = false, Message = err });
                return null;
            }

            #region 超时校验
            try
            {
                //long nowTime = (long)Convert.ToDecimal(DateTime.Now.ToLongTimeString());
                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                dtFormat.FullDateTimePattern = "yyyy-MM-dd HH:mm:ss";
                DateTime dt = Convert.ToDateTime(time, dtFormat);

                TimeSpan ts = new TimeSpan(DateTime.Now.Ticks);
                TimeSpan ts2 = new TimeSpan(dt.Ticks);
                if (ts.Subtract(ts2).Duration().TotalMinutes > 5)
                {
                    string err = "超时了！";
                    Logger.WritingLog(err + time);
                    response.WriteJson(new { Success = false, Message = err });
                    return null;
                }
            }
            catch
            {
                string err = "time格式不正确！";
                Logger.WritingLog(err + time);
                response.WriteJson(new { Success = false, Message = err });
                return null;
            }
            #endregion



            #region 签名校验 //签名顺序为key+scrert+request.Action+time+request.Data
            string str = key + Properties.Settings.Default.screct + action + time + data;
            string signStr = ComonUtil.Sign(str);
            if (signStr != sign)
            {
                string err = "签名校验不正确！";
                Logger.WritingLog(err);
                response.WriteJson(new { Success = false, Message = err });
                return null;
            }
            #endregion

            IDictionary<string, string> dc = new Dictionary<string, string>();
            dc.Add("action", action);
            dc.Add("data", data);
            dc.Add("key", key);
            return dc;
        }

        void http_OnRequest(Tesla.Net.SimpleRequest request, Tesla.Net.SimpleResponse response)
        {
            IDictionary<string, string> dc = validateReq(request, response);
            //IDictionary<string, string> dc = new Dictionary<string, string>();
            //dc.Add("action", "sendreturnorder");
            //dc.Add("data", "{\"shopname\":\"七乐康B店\",\"phone\":null,\"mobile\":\"18704494645\",\"consigneename\":\"郑婷婷\",\"member\":\"tb542914929\",\"WarehouseCode\":\"003\",\"ReturnOrderId\":\"THD00197771\",\"LYDH\":\"DC09153062\",\"ExpressCode\":null,\"Waybill\":null,\"Remark\":\"会[普]效果问题：客户反馈一片磨眼，，互换还是那片，垫付运费退回两片退货，收到退108元+运费，已下退货单2015-9-22 14:15:16 1140\\r\\n\",\"items\":[{\"SkuCode\":\"504031550\",\"Name\":null,\"Count\":2,\"Price\":null,\"Total\":100},{\"SkuCode\":\"803020284\",\"Name\":null,\"Count\":1,\"Price\":100,\"Total\":100}]}");
            //dc.Add("key", "123");
            if(dc != null)
            {
                string action = dc["action"];
                string data = dc["data"];
                string key = dc["key"];

                //业务逻辑处理
                IOrderHandle oh = getOrderHandle(key, action);
                if (oh != null)
                {
                    bool isSuccess = false;
                    try
                    {
                        oh.doHandle(data, response);
                        isSuccess = true;
                    }
                    catch (InterfaceException e)
                    {
                        response.WriteJson(new { Success = false, ErrorType = (int)e.ErrorType, Message = e.Message });
                    }
                    catch (Exception e)
                    {
                        Logger.WritingLog(e.Message+"\r\n"+e.StackTrace);
                        response.WriteJson(new { Success = false, ErrorType = (int)InterfaceExceptionType.NoReTry, Message = e.Message });
                    }
                    if (isSuccess)
                    {
                        response.WriteJson(new { Success = true, Message = "OK" });
                        actionevent(action);
                    }
                }
            }
        }

        private IOrderHandle getOrderHandle(string key,string action)
        {
            if (Properties.Settings.Default.key.Split(',')[1].Equals(key))//处方药相关处理接口
            {
                if ("sendorder".Equals(action))
                {
                    return new AcceptOrderCFServiceImpl();
                }
                else if ("sendreturnorder".Equals(action))
                {
                    return new ReturnOrderCFServiceImpl();
                }
            }

            IOrderHandle ar = null;
            switch (action)
            {
                case "sendorder":
                    ar = new AcceptOrderServiceImpl();
                    break;

                case "sendreturnorder":
                    ar = new ReturnOrderServiceImpl();
                    break;

                case"reversereturnorder":
                    ar = new ReverseReturnOrderServiceImpl();
                    break;

                case "cancelreturnorder":
                    ar = new CancelReturnOrderServiceImpl();
                    break;

                case "Cancel":
                    ar = new OrderCancelServiceImpl();
                    break;

                case "lock":
                    ar = new OrderLockServiceImpl();
                    break;

                case "unlock":
                    ar = new OrderUNLockServiceImpl();
                    break;

                case "Urgent":
                    ar = new OrderUrgentServiceImpl();
                    break;

                case "PlatformDelivered":
                    ar = new OrderTBServiceImpl();
                    break;

                case "queryStock":
                    ar = new StockServiceImpl();
                    break;

                case "queryOrderStatus":
                    ar = new QueryOrderStatusServiceImpl();
                    break;

                case "info_spkfk":
                    ar = new QueryOrderStatusServiceImpl();
                    break;
                default: break;
            }
            return ar;
        }
    }
}
