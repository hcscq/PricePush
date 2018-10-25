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
   public class RefundBill_M
    {
       /// <summary>
       /// 单据编号
       /// </summary>
        public string DJBH{get;set;}
       /// <summary>
       /// 单位ID
       /// </summary>
        public string DWID{get;set;}
       /// <summary>
       /// 日期
       /// </summary>
        public DateTime RQ{get;set;}
       /// <summary>
       /// 部门ID
       /// </summary>
        public string BMID{get;set;}
       /// <summary>
       /// 业务员
       /// </summary>
        public string RY_YWY{get;set;}
       /// <summary>
       /// 收货员
       /// </summary>
        public string RY_SHOUHY{get;set;}
       /// <summary>
       /// 复核员
       /// </summary>
        public string RY_FUHY{get;set;}
       /// <summary>
       /// 操作员
       /// </summary>
        public string RY_CZY{get;set;}
       /// <summary>
       /// 退货类别
       /// </summary>
        public string THLB{get;set;}
        public string SF_ZX{get;set;}
       /// <summary>
        /// 退货入库单据编号
       /// </summary>
        public string DJBH_SJ{get;set;}
       /// <summary>
       /// 业主ID
       /// </summary>
        public string YZID{get;set;}
       /// <summary>
       /// 质检员
       /// </summary>
        public string RY_ZJY{get;set;}

        public string EXPRESSCODE { get; set; }
        public string EXPRESSNAME { get; set; }
        public string EXPRESSNUMBER { get; set; }
        public string SF_YBTH { get; set; }






        //public string WMFLG { get; set; }
        public List<RefundBill_D> detialList = new List<RefundBill_D>();
    }
}
