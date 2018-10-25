using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.VO
{
    public class SendOutOrderD
    {
        #region 明细部分
        /// <summary>
        /// 单据编号
        /// </summary>
        public string DJBH{get;set;}
        /// <summary>
        /// 单据排序号
        /// </summary>
        public decimal DJ_SORT{get;set;}
        /// <summary>
        /// 商品ID
        /// </summary>
        public string SPID{get;set;}
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
        public string PH{get;set;}
        /// <summary>
        /// 批号处理方式
        /// </summary>
        public string PHCLFS{get;set;}
        /// <summary>
        /// 零售价
        /// </summary>
        public decimal LSJ{get;set;}
        /// <summary>
        /// 发票号
        /// </summary>
        public string INVOICENO{get;set;}
        /// <summary>
        /// 发票ID
        /// </summary>
        public string INVOICEID{get;set;}
        /// <summary>
        /// 发票金额
        /// </summary>
        public decimal AMOUNT{get;set;}
        /// <summary>
        /// 发票抬头
        /// </summary>
        public string TITLE{get;set;}
        /// <summary>
        /// 发票内容
        /// </summary>
        public string CONTENT{get;set;}
        /// <summary>
        /// 发票代码
        /// </summary>
        public string SKUCODE{get;set;}
        /// <summary>
        /// 发票类型
        /// </summary>
        public string INVOICETYPE{get;set;}
        #endregion 
    }
}
