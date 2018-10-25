using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Domain
{    
    /// <summary>
    /// 生产库订单主档对象
    /// </summary>
    [Serializable]
    public class BillingM
    {
        //单据编号
        public string djbh {get; set;}

        //通知单编号
        public string djbh_sj { get; set; }

        //波次号
        public string bch { get; set; }

        //单据类型
        public string ddlx { get; set; }

        //单位内码
        public string dwid {get; set;}

        //日期
        public DateTime rq {get; set;}

        //出库优先级
        public int ckyxj {get; set;}

        //作业状态
        public string zyzt {get; set;}

        //结算类型
        public string jslx { get; set; }

        //送货地址
        public string shdz { get; set; }

        //运单号
        public string waybill { get; set; }

        //是否发票
        public string isInvoice { get; set; }

        //任务楼层
        public string taskFloor { get; set; }

        //是否取消
        public string billCancel { get; set; }

        //手机号码
        public string mobile { get; set; }

        /// <summary>
        /// 明细
        /// </summary>
        public List<BillingD> dList { get; set; }

        /// <summary>
        /// 是否需要发票
        /// </summary>
        public string is_invoice { get; set; }

        /// <summary>
        /// 代收金额
        /// </summary>
        public Decimal codmoney { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        public Decimal totalmoney { get; set; }

        /// <summary>
        /// 是否需要发票
        /// </summary>
        public int iscod { get; set; }

        /// <summary>
        /// 销售平台同步状态
        /// </summary>
        public int isdelivered { get; set; }

        /// <summary>
        /// 运单打印分组
        /// </summary>
        public string groupcode { get; set; }

        /// <summary>
        /// 锁定备注
        /// </summary>
        public string lockremark { get; set; }

        /// <summary>
        /// 是否市场活动订单
        /// </summary>
        public int marketingactivity { get; set; }

        /// <summary>
        /// 目的地代码
        /// </summary>
        public string targetareacode { get; set; }

        /// <summary>
        ///目的地站点
        /// </summary>
        public string targetstation { get; set; }

        /// <summary>
        /// 目的地站点代码
        /// </summary>
        public string targetstationcode { get; set; }

               
        public string ry_kpy {get; set;}
        public string thfs {get; set;}
        public string bmid {get; set;}
        public string thsj {get; set;}
        public string zcqqsh {get; set;}
        public string zcqzzh {get; set;}

        public string kpf {get; set;}
        public string sf_zx {get; set;}
        public string sf_xc {get; set;}

        public string wlzbz {get; set;}
        public string kplb {get; set;}
        public DateTime kpsj {get; set;}
        public string sf_js {get; set;}
        public string sf_lstd {get; set;}
        public string sf_ps {get; set;}
        public string sf_zy {get; set;}
        public string cxbz {get; set;}
       // public string bch {get; set;}
        public string sf_rgsqph {get; set;}
        public string ry_czy {get; set;}
        public string thfszh {get; set;}
        public string sqphzt {get; set;}
        public string sf_gq {get; set;}
        public string sf_dyzjbq {get; set;}
        public string djbh_bd {get; set;}
        public string sf_ycw_sl {get; set;}
        public string dwid_ej {get; set;}
        public string sf_ffcp {get; set;}
        public string zcqzjh {get; set;}
        public string ry_ddy {get; set;}
        public string khbz {get; set;}
        //public string ddlx {get; set;}
        public string sf_prncd {get; set;}
        public string jhfs {get; set;}
        public string xslx {get; set;}
        public string pslx {get; set;}
        public string tyfk {get; set;}
        public string ddlb {get; set;}
        public string sf_qh {get; set;}
        //创建时间
        public string createtime {get; set;}
        //备注
        public string beizhu {get; set;}
        public string fukfs {get; set;}
        public string dj_ssgs {get; set;}
        public string sf_xdd {get; set;}
        public string yzid {get; set;}
        public string yzc_bill {get; set;}
        public string shr {get; set;}
        public string lxfs {get; set;}
        public string idnumber {get; set;}
        public string js_dj {get; set;}
        public string is_jj {get; set;}
        
        
        public string bill_properties {get; set;}
        
        
        public string replan {get; set;}
        public string fromty {get; set;}
        public string cacode {get; set;}
        public string caname {get; set;}
        public string shopna {get; set;}
        public string shopno {get; set;}
        public string whcode {get; set;}
        public string bunick {get; set;}
        public string custna {get; set;}
        public string recena {get; set;}
        public string postco {get; set;}
        public string provco {get; set;}
        public string provna {get; set;}
        public string cityco {get; set;}
        public string cityna {get; set;}
        public string distco {get; set;}
        public string distna {get; set;}
        public string addres {get; set;}
        
        public string teleph {get; set;}
        public string invoiceno {get; set;}
        public string fromno {get; set;}
        public double weight {get; set;}
        public string properties_kind {get; set;}
        public string sememo {get; set;}
        public string bumemo {get; set;}
        public string waybill_code {get; set;}
        public string short_address {get; set;}
        public string callstatus {get; set;}
        public string ry_bdzy {get; set;}
        public string opform {get; set;}
        public string getstatustb {get; set;}
        public string waybillbatch {get; set;}
        public string errreason {get; set;}
        public string ctnsku {get; set;}
        public string ctnskuqty {get; set;}
        public string sameprinter {get; set;}
        public string samegroup {get; set;}
        public string areachannel {get; set;}
        public string pickroute {get; set;}
        public string pickspan {get; set;}
        public string pickgroupno { get; set; }

        public string sendStationCode { get; set; }
        public string sendStation { get; set; }
    }
}
