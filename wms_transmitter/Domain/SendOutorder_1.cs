using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Domain
{
    [Serializable]
    public class SendOutOrder
    {
        #region 明细部分
        /// <summary>
        /// 单据编号
        /// </summary>
        public string DJBH { get { return string.IsNullOrEmpty(DJBH) ? "" : DJBH; } set { DJBH = value; } }
        /// <summary>
        /// 单据排序号
        /// </summary>
        public decimal DJ_SORT{get;set;}
        /// <summary>
        /// 商品ID
        /// </summary>
        public string SPID { get { return string.IsNullOrEmpty(SPID) ? "" : SPID; } set { SPID = value; } }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal SL{get;set;}
        /// <summary>
        /// 件数
        /// </summary>
        public decimal JS{get;set;}
        /// <summary>
        /// 零散数
        /// </summary>
        public decimal LSS{get;set;}
        /// <summary>
        /// 单价
        /// </summary>
        public decimal DJ{get;set;}
        /// <summary>
        /// 金额
        /// </summary>
        public decimal JE{get;set;}
        /// <summary>
        /// 含税金额
        /// </summary>
        public decimal JE_HS{get;set;}
        /// <summary>
        /// 税率
        /// </summary>
        public decimal SLV{get;set;}
        /// <summary>
        /// 税额
        /// </summary>
        public decimal SE{get;set;}
        /// <summary>
        /// 扣率
        /// </summary>
        public decimal KL{get;set;}
        /// <summary>
        /// 显示单价
        /// </summary>
        public decimal DJ_XS{get;set;}
        /// <summary>
        /// 有效期要求
        /// </summary>
        public DateTime XQYQ{get;set;}
        /// <summary>
        /// 批号
        /// </summary>
        public string PH { get { return string.IsNullOrEmpty(PH) ? "" : PH; } set { PH = value; } }
        /// <summary>
        /// 批号处理方式
        /// </summary>
        public string PHCLFS { get { return string.IsNullOrEmpty(PHCLFS) ? "" : PHCLFS; } set { PHCLFS = value; } }
        /// <summary>
        /// 零售价
        /// </summary>
        public decimal LSJ{get;set;}
        /// <summary>
        /// 发票号
        /// </summary>
        public string INVOICENO { get { return string.IsNullOrEmpty(INVOICENO) ? "" : INVOICENO; } set { INVOICENO = value; } }
        /// <summary>
        /// 发票ID
        /// </summary>
        public string INVOICEID { get { return string.IsNullOrEmpty(INVOICEID) ? "" : INVOICEID; } set { INVOICEID = value; } }
        /// <summary>
        /// 发票金额
        /// </summary>
        public decimal AMOUNT{get;set;}
        /// <summary>
        /// 发票抬头
        /// </summary>
        public string TITLE { get { return string.IsNullOrEmpty(TITLE) ? "" : TITLE; } set { TITLE = value; } }
        /// <summary>
        /// 发票内容
        /// </summary>
        public string CONTENT { get { return string.IsNullOrEmpty(CONTENT) ? "" : CONTENT; } set { CONTENT = value; } }
        /// <summary>
        /// 发票代码
        /// </summary>
        public string SKUCODE { get { return string.IsNullOrEmpty(SKUCODE) ? "" : SKUCODE; } set { SKUCODE = value; } }
        /// <summary>
        /// 发票类型
        /// </summary>
        public string INVOICETYPE { get { return string.IsNullOrEmpty(INVOICETYPE) ? "" : INVOICETYPE; } set { INVOICETYPE = value; } }
        #endregion 

        #region 汇总部分
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime RQ{get;set;}
        /// <summary>
        /// 提货方式
        /// </summary>
        public string THFS { get { return string.IsNullOrEmpty(THFS) ? "" : THFS; } set { THFS = value; } }
        /// <summary>
        /// 提货时间
        /// </summary>
        public string THSJ { get { return string.IsNullOrEmpty(THSJ) ? "" : THSJ; } set { THSJ = value; } }
        /// <summary>
        /// 操作员
        /// </summary>
        public string RY_CZY { get { return string.IsNullOrEmpty(RY_CZY) ? "" : RY_CZY; } set { RY_CZY = value; } }
        /// <summary>
        /// 开票类别
        /// </summary>
        public string KPLB { get { return string.IsNullOrEmpty(KPLB) ? "" : KPLB; } set { KPLB = value; } }
        /// <summary>
        /// 订单类型
        /// </summary>
        public string DDLX { get { return string.IsNullOrEmpty(DDLX) ? "" : DDLX; } set { DDLX = value; } }
        /// <summary>
        /// 客户备注
        /// </summary>
        public string KHBZ { get { return string.IsNullOrEmpty(KHBZ) ? "" : KHBZ; } set { KHBZ = value; } }
        /// <summary>
        /// 销售类型
        /// </summary>
        public string XSLX { get { return string.IsNullOrEmpty(XSLX) ? "" : XSLX; } set { XSLX = value; } }
        /// <summary>
        /// 配送类型
        /// </summary>
        public string PSLX { get { return string.IsNullOrEmpty(PSLX) ? "" : PSLX; } set { PSLX = value; } }
        /// <summary>
        /// 送货地址
        /// </summary>
        public string SHDZ { get { return string.IsNullOrEmpty(SHDZ) ? "" : SHDZ; } set { SHDZ = value; } }
        /// <summary>
        /// 联系方式
        /// </summary>
        public string LXFS { get { return string.IsNullOrEmpty(LXFS) ? "" : LXFS; } set { LXFS = value; } }
        /// <summary>
        /// 收货人
        /// </summary>
        public string SHR { get { return string.IsNullOrEmpty(SHR) ? "" : SHR; } set { SHR = value; } }
        /// <summary>
        /// 来源订单类型
        /// </summary>
        public string FROMTY { get { return string.IsNullOrEmpty(FROMTY) ? "" : FROMTY; } set { FROMTY = value; } }
        /// <summary>
        /// 物流公司名称
        /// </summary>
        public string CANAME { get { return string.IsNullOrEmpty(CANAME) ? "" : CANAME; } set { CANAME = value; } }
        /// <summary>
        /// 来源店铺代码
        /// </summary>
        public string SHOPNA { get { return string.IsNullOrEmpty(SHOPNA) ? "" : SHOPNA; } set { SHOPNA = value; } }
        /// <summary>
        /// 仓库编码
        /// </summary>
        public string WHCODE { get { return string.IsNullOrEmpty(WHCODE) ? "" : WHCODE; } set { WHCODE = value; } }
        /// <summary>
        /// 会员昵称
        /// </summary>
        public string BUNICK { get { return string.IsNullOrEmpty(BUNICK) ? "" : BUNICK; } set { BUNICK = value; } }
        /// <summary>
        /// 会员名称
        /// </summary>
        public string CUSTNA { get { return string.IsNullOrEmpty(CUSTNA) ? "" : CUSTNA; } set { CUSTNA = value; } }
        /// <summary>
        /// 收件人姓名
        /// </summary>
        public string RECENA { get { return string.IsNullOrEmpty(RECENA) ? "" : RECENA; } set { RECENA = value; } }
        /// <summary>
        /// 省编码
        /// </summary>
        public string PROVCO { get { return string.IsNullOrEmpty(PROVCO) ? "" : PROVCO; } set { PROVCO = value; } }
        /// <summary>
        /// 省名称
        /// </summary>
        public string PROVNA { get { return string.IsNullOrEmpty(PROVNA) ? "" : PROVNA; } set { PROVNA = value; } }
        /// <summary>
        /// 市编码
        /// </summary>
        public string CITYCO { get { return string.IsNullOrEmpty(CITYCO) ? "" : CITYCO; } set { CITYCO = value; } }
        /// <summary>
        /// 市名称
        /// </summary>
        public string CITYNA { get { return string.IsNullOrEmpty(CITYNA) ? "" : CITYNA; } set { CITYNA = value; } }
        /// <summary>
        /// 区编码
        /// </summary>
        public string DISTCO { get { return string.IsNullOrEmpty(DISTCO) ? "" : DISTCO; } set { DISTCO = value; } }
        /// <summary>
        /// 区名称
        /// </summary>
        public string DISTNA { get { return string.IsNullOrEmpty(DISTNA) ? "" : DISTNA; } set { DISTNA = value; } }
        /// <summary>
        /// 收获地址
        /// </summary>
        public string ADDRES { get { return string.IsNullOrEmpty(ADDRES) ? "" : ADDRES; } set { ADDRES = value; } }
        /// <summary>
        /// 手机
        /// </summary>
        public string MOBIL { get { return string.IsNullOrEmpty(MOBIL) ? "" : MOBIL; } set { MOBIL = value; } }
        /// <summary>
        /// 快递单号
        /// </summary>
        public string CODE_NUMBER { get { return string.IsNullOrEmpty(CODE_NUMBER) ? "" : CODE_NUMBER; } set { CODE_NUMBER = value; } }
        #endregion
    }
}
