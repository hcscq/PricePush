using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using wms_transmitter.Domain;
using wms_transmitter.VO;
using System.IO;
using Newtonsoft.Json.Linq;

namespace wms_transmitter.Common
{
    public static class ObjConvertUtil
    {
        #region json对象转换
        public static string Object2Json(object obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateFormatString = "yyyy-MM-dd HH:mm:ss"
            });
        }

        public static T Json2Object<T>(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(str);
        }
        #endregion



        /// <summary>
        /// 根据前端订单对象生成WMS库订单表表对象
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static BillingM Order2BillingM(SendOrdersRequest order)
        {
            BillingM bm = null;
            if (order != null)
            {
                bm = new BillingM();
                bm.dList = new List<BillingD>();
                bm.djbh = order.OrderId;//单据编号
                bm.dwid = Properties.Settings.Default.dwid;//单位ID
                bm.rq = DateTime.Now;//订单下传WMS时间
                bm.ry_kpy = "admin";
                bm.thfs = "配送";//提货方式
                bm.bmid = Properties.Settings.Default.bmid;//部门ID
                bm.ckyxj = 50;//出库优先级
                bm.sf_zx = "是";//是否执行
                bm.sf_xc = "是";//是否下传
                bm.kpsj = order.PayTime;//取支付时间
                bm.djbh_sj = order.OrderId;//通知单编号
                bm.ry_czy = "admin";
                bm.thfszh = "其他";
                bm.sf_dyzjbq = "否";
                bm.ddlx = "电商";
                bm.yzid = Properties.Settings.Default.yzid;//业主ID
                bm.is_invoice = order.Is_Invoice == true ? "Y" : "N";
                bm.waybill = order.Waybill;//运单号
                bm.fromty = "2";//来源系统编号（1：DTC；2：管易；3：时空）
                bm.cacode = order.ExpressCode;//物流公司编号
                bm.shopno = order.ShopCode;//来源店铺名
                bm.whcode = order.WarehouseCode;//仓库编码
                bm.bunick = order.Member;//会员昵称
                bm.custna = order.Member;//会员名称
                bm.recena = order.Name;//收货人
                bm.postco = order.PostCode;//邮政编码
                bm.provna = order.Province;//省名称
                bm.cityna = order.City;//市名称
                bm.distna = order.County;//区名称
                bm.addres = order.Address;//收货地址
                bm.mobile = order.MobilePhone;//手机号
                bm.teleph = order.Phone;//固定电话
                bm.sememo = order.Remark;//卖家留言
                bm.opform = "1";//订单来源平台
                bm.codmoney = order.CodAmount;//代收金额
                bm.totalmoney = order.OrderAmount;//订单总金额
                bm.iscod = order.IsCod == true ? 1 : 0;//是否货到付款
                bm.marketingactivity = order.MarketingActivity == true ? 1 : 0;//是否市场活动订单
                bm.sendStationCode = order.SendStationCode;//快递公司网点编号
                bm.sendStation = order.SendStation;//快递公司网点名称
                bm.short_address = order.TargetArea;//大头笔信息
                bm.targetareacode = order.TargetAreaCode;//目的地代码
                bm.targetstation = order.TargetStation;//目的地站点
                bm.targetstationcode = order.TargetStationCode;//目的地站点代码

                List<Goods> bList = order.items;
                if (bList != null)
                {
                    for (int i = 0; i < bList.Count; i++)
                    {
                        Goods g = bList[i];
                        BillingD d = new BillingD();
                        d.djbh = order.OrderId;//单据编号
                        d.dj_sort = (i + 1) + "";//行号
                        d.spid = g.SkuCode;//商品ID
                        d.sl = g.Count;//商品数量
                        d.dj = g.Price??0;//单价
                        d.je = g.Total??0;//金额
                        d.sl_jh = g.Count;//计划数量
                        d.yzid = Properties.Settings.Default.yzid;//业主ID

                        bm.dList.Add(d);
                    }
                }
            }
            return bm;
        }

        /// <summary>
        /// 根据传入的退货单生成WMS退货单对象
        /// </summary>
        /// <param name="ro"></param>
        /// <returns></returns>
        public static NoticeM ReturnOrder2Notice(SendReturnOrdersRequest ro)
        {
            NoticeM m = null;
            if (ro != null)
            {
                m = new NoticeM();
                m.dList = new List<NoticeD>();

                m.djbh = ro.ReturnOrderId;
                m.dwid = Properties.Settings.Default.dwid;
                m.bmid = Properties.Settings.Default.bmid;
                m.yzid = Properties.Settings.Default.yzid;
                m.whcode = Properties.Settings.Default.yzid;
                m.thlb = "正常退货";
                m.djbhtype = "电商";
                m.opform = "1";
                m.fromsys = 2;
                m.expresscode = ro.ExpressCode;
                m.expressnumber = ro.Waybill;
                m.shopcode = ro.Shopname;
                m.shopname = ro.Shopname;
                m.consigneename = ro.Member;
                m.mobile = ro.Mobile;
                m.teleph = ro.Phone;
                m.djbh_sj = ro.LYDH;
                m.remark = ro.Remark;
                m.custSer = ro.custSer;
                m.type = ro.type;
                List<Goods> gList = ro.items;
                if (gList != null)
                {
                    for (int i = 0; i < gList.Count; i++)
                    {
                        Goods g = gList[i];
                        NoticeD d = new NoticeD();
                        d.djbh = ro.ReturnOrderId;
                        d.dj_sort = (i + 1) + "";
                        d.spid = g.SkuCode;
                        d.sl = g.Count + "";
                        d.sl_jh = g.Count + "";
                        d.yzid = Properties.Settings.Default.yzid;
                        d.thyy_sj = g.Remark;
                        d.je = (g.Total??0).ToString();
                        d.dj = (g.Price??0).ToString();
                        m.dList.Add(d);
                    }
                }
            }
            return m;
        }

        /// <summary>
        /// 出库开票订单表对象
        /// </summary>
        /// <param name="ro"></param>
        /// <returns></returns>
        public static BillingM Order2BillMObj(OrderRequest ro)
        {
            BillingM m = null;
            if (ro != null)
            {
                m = new BillingM();
                m.djbh = ro.OrderId;//单据编号
                m.isdelivered = ro.IsDelivered == true ? 1 : 0;//销售平台同步状态
                m.lockremark = ro.LockRemark;//锁定备注
            }
            return m;
        }

        /// <summary>
        /// 出库任务订单表对象
        /// </summary>
        /// <param name="ro"></param>
        /// <returns></returns>
        public static OUT_SALE_TASK_M Order2TaskMObj(OrderRequest ro)
        {
            OUT_SALE_TASK_M m = null;
            if (ro != null)
            {
                m = new OUT_SALE_TASK_M();
                m.DJBH = ro.OrderId;//单据编号
                m.SDBZ = ro.LockRemark;//锁定备注
            }
            return m;
        }


        public static void Insert2WMS(string table, string json, string pk)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject(json) as JObject;
            IEnumerable<JProperty> properties = obj.Properties();
            var sb = new StringBuilder();
            foreach (var d in properties)
            {
                
                sb.Append("delete ").Append(table).Append(" where ").Append
                           (pk).Append("=").Append(d[pk]).Append("insert into ").Append(table).Append("(");
                int c = 0;
                foreach (var itme in d)
                {                    
                    var keys = new List<string>();
                    foreach (var k in properties)
                    {
                        keys.Add(k.Name);
                    }
                    sb.Append(string.Join(",", keys));
                    sb.Append(")  values(@");
                    sb.Append(string.Join("" + c + ",@", keys));
                    sb.Append(c+")");

                    foreach (JProperty item in properties)
                    {
                        Console.WriteLine(item.Name + ":" + item.Value);
                    }
                    c++;
                }
            }
        }
    }
}
