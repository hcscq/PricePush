using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.VO
{
    public class SendOutOrderM
    {
        #region 汇总部分
        /// <summary>
        /// 单据编号
        /// </summary>
        public string DJBH { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime RQ{get;set;}
        /// <summary>
        /// 提货方式
        /// </summary>
        public string THFS{get;set;}
        /// <summary>
        /// 提货时间
        /// </summary>
        public string THSJ{get;set;}
        /// <summary>
        /// 操作员
        /// </summary>
        public string RY_CZY{get;set;}
        /// <summary>
        /// 开票类别
        /// </summary>
        public string KPLB{get;set;}
        /// <summary>
        /// 订单类型
        /// </summary>
        public string DDLX{get;set;}
        /// <summary>
        /// 客户备注
        /// </summary>
        public string KHBZ{get;set;}
        /// <summary>
        /// 销售类型
        /// </summary>
        public string XSLX{get;set;}
        /// <summary>
        /// 配送类型
        /// </summary>
        public string PSLX{get;set;}
        /// <summary>
        /// 送货地址
        /// </summary>
        public string SHDZ{get;set;}
        /// <summary>
        /// 联系方式
        /// </summary>
        public string LXFS{get;set;}
        /// <summary>
        /// 收货人
        /// </summary>
        public string SHR{get;set;}
        /// <summary>
        /// 来源订单类型
        /// </summary>
        public string FROMTY{get;set;}
        /// <summary>
        /// 物流公司名称
        /// </summary>
        public string CANAME{get;set;}
        /// <summary>
        /// 物流公司代码
        /// </summary>
        public string CACODE { get; set; }
        /// <summary>
        /// 来源店铺代码
        /// </summary>
        public string SHOPNA{get;set;}
        /// <summary>
        /// 仓库编码
        /// </summary>
        public string WHCODE{get;set;}
        /// <summary>
        /// 会员昵称
        /// </summary>
        public decimal BUNICK{get;set;}
        /// <summary>
        /// 会员名称
        /// </summary>
        public string CUSTNA{get;set;}
        /// <summary>
        /// 收件人姓名
        /// </summary>
        public string RECENA{get;set;}
        /// <summary>
        /// 省编码
        /// </summary>
        public string PROVCO{get;set;}
        /// <summary>
        /// 省名称
        /// </summary>
        public string PROVNA{get;set;}
        /// <summary>
        /// 市编码
        /// </summary>
        public string CITYCO{get;set;}
        /// <summary>
        /// 市名称
        /// </summary>
        public string CITYNA{get;set;}
        /// <summary>
        /// 区编码
        /// </summary>
        public string DISTCO{get;set;}
        /// <summary>
        /// 区名称
        /// </summary>
        public string DISTNA{get;set;}
        /// <summary>
        /// 收获地址
        /// </summary>
        public string ADDRES{get;set;}
        /// <summary>
        /// 手机
        /// </summary>
        public string MOBIL{get;set;}
        /// <summary>
        /// 快递单号
        /// </summary>
        public string CODE_NUMBER;
        #endregion
        public List<SendOutOrderD> orderDList=new List<SendOutOrderD> ();
    }
}
