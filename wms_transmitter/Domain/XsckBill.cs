using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Domain
{ 
    /// <summary>
    /// 销售出库,订单中间表对象
    /// </summary>
   [Serializable]   
   public class XsckBill
    {
        //单据编号
        public string djbh { get; set; }
        //单位内码
        public string dwid { get; set; }
        ////日期
        public string rq { get; set; }
        //业务员（开票员）
        public string ry_ywy { get; set; }
        //提货方式
        public string thfs { get; set; }
        //部门ID
        public string bmid { get; set; }
        //出库优先级
        public string ckyxj { get; set; }

        public string thsj { get; set; }
        public string scf { get; set; }
        public string sf_rgsqph { get; set; }
        //结算类型
        public string jslx { get; set; }

        public string djbh_bd { get; set; }
        public string dwid_ej { get; set; }
        public string sf_ffcp { get; set; }
        public string khbz { get; set; }
        //订单明细行号
        public int dj_sort { get; set; }
        public string spid { get; set; }
        //数量
        public decimal sl { get; set; }
        //件数
        public decimal js { get; set; }
        //零散数
        public decimal lss { get; set; }
        //单价
        public decimal dj { get; set; }
        //销售单价
        public decimal dj_xs { get; set; }
        public string phclfs { get; set; }
        //商品金额
        public float je { get; set; }
        //含税商品金额
        public decimal je_hs { get; set; }

        public decimal slv { get; set; }
        public decimal se { get; set; }
        public decimal kl { get; set; }
        public string ph { get; set; }
        public string xqyq { get; set; }
        public string cxms { get; set; }
        public string sf_cxsp { get; set; }
        //订单类型
        public string ddlx { get; set; }
        //是否越库
        public string sf_yk { get; set; }
        //是否作业
        public string sf_zy { get; set; }
        //销售类型
        public string xslx { get; set; }
        //配送类型
        public string pslx { get; set; }
        //货位
        public string hw { get; set; }
        //是否缺货
        public string sf_qh { get; set; }
        //创建时间
        public string createtime { get; set; }
        public string shdz { get; set; }
        public string zpfffs { get; set; }
        public string dj_ssgs { get; set; }
        public decimal lsj { get; set; }
        //业主ID
        public string yzid { get; set; }
        //收货人
        public string shr { get; set; }
        //联系方式
        public string lxfs { get; set; }
        //身份证号
        public string idnumber { get; set; }
        //是否紧急
        public string is_jj { get; set; }
        //来源订单类型
        public string fromty { get; set; }
        //物流公司编码
        public string cacode { get; set; }
        //物流公司名称
        public string caname { get; set; }
        //来源店铺名
        public string shopna { get; set; }
        //来源店铺代码
        public string shopno { get; set; }
        //仓库编码
        public string whcode { get; set; }
        //会员昵称
        public string bunick { get; set; }
        //会员名称
        public string custna { get; set; }
        //收件人姓名
        public string recena { get; set; }
        //邮政编码
        public string postco { get; set; }
        //省编码
        public string provco { get; set; }
        //省名称
        public string provna { get; set; }
        //市编码
        public string cityco { get; set; }
        //市名称
        public string cityna { get; set; }
        //区编码
        public string distco { get; set; }
        //区名称
        public string distna { get; set; }
        //收货地址
        public string addres { get; set; }
        //移动电话
        public string mobile { get; set; }
        //固定电话
        public string teleph { get; set; }
        //发票号
        public string invoiceno { get; set; }
        //是否开发票
        public string isinvoice { get; set; }
        public string is_invoice { get; set; }
        //来源单号
        public string fromno { get; set; }
        //发票ID
        public string invoiceid { get; set; }
        //发票金额
        public decimal amount { get; set; }
        //发票抬头
        public string title { get; set; }
        //发票内容
        public string content { get; set; }
        //规格代码
        public string skucode { get; set; }
        //发票类型
        public string invoicetype { get; set; }
        //根据收货地址返回的大头笔信息
        public string short_address { get; set; }
        //面单状态（PT：普通面单；DZ：电子面单）
        public string callstatus { get; set; }
        //卖家留言
        public string sememo { get; set; }
        //买家留言
        public string bumemo { get; set; }
        //根据收货地址返回的运单号
        public string waybill_code { get; set; }
        //接口传输时间
        //public DateTime rq_oms { get; set; }
        //标志
        public int status { get; set; }
        //订单来源平台
        public string opform { get; set; }
        /// <summary>
        /// 支付时间
        /// </summary>
        public DateTime PayTime { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        public Decimal TotalMoney { get; set; }
       
        /// <summary>
        /// 是否货到付款
        /// </summary>
        public int IsCod { get; set; }

        /// <summary>
        /// 代收金额
        /// </summary>
        public float CodMoney { get; set; }
    }
}
