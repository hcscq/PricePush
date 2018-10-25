using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Domain
{ 
    /// <summary>
    /// 销售退回上传
    /// </summary>
   [Serializable]   
   public class RefundBill_D
    {
       /// <summary>
       /// 单据编号
       /// </summary>
        public string DJBH{get;set;}
       /// <summary>
       /// 单据排序
       /// </summary>
        public long  DJ_SORT{get;set;}
       /// <summary>
       /// 商品ID
       /// </summary>
        public string SPID{get;set;}
       /// <summary>
       /// 商品编号
       /// </summary>
        public string SPBH { get; set; }
       /// <summary>
       /// 数量
       /// </summary>
        public long SL{get;set;}
       /// <summary>
       /// 件数
       /// </summary>
        //public string JS{get;set;}
       /// <summary>
       /// 零散数
       /// </summary>
        //public string LSS{get;set;}
       /// <summary>
       /// 单价
       /// </summary>
        public float DJ{get;set;}
       /// <summary>
       /// 金额
       /// </summary>
        public float JE{get;set;}
       /// <summary>
        /// 销售出库单据编号
       /// </summary>
        public string DJBH_SJ{get;set;}
       /// <summary>
        /// 销售出库单据排序号
       /// </summary>
        public long DJ_SORT_SJ{get;set;}
       /// <summary>
       /// 退货原因
       /// </summary>
        public string THYY{get;set;}
       /// <summary>
       /// 批号
       /// </summary>
        public string PH{get;set;}
        public string RQ_SC{get;set;}
        public string YXQZ{get;set;}
        public float DJ_XS{get;set;}
       /// <summary>
       /// 业主ID
       /// </summary>
        public string YZID{get;set;}
       /// <summary>
       /// 验收评定
       /// </summary>
        public string YSPD { get; set; }

    }
}



