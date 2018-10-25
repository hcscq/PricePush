using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Domain
{
    /// <summary>
    /// 生产库订单明细对象
    /// </summary>
    [Serializable]
    public class UpdateStateBill
    {
        public string WAYBILL{get;set;}
        public string CACODE{get;set;} 
        //       仓库ID  
        public string YZID { get; set; }
        //        单据编号  
        public string DJBH { get; set; }
        //        单位内码  
        public string DWID { get; set; }
        //     '0'  作业类型（动作名称） 
        public string ACTTYPE { get; set; }
        //  Y     更新前状态  
        public string PRESTATE { get; set; }
        //  Y     更新后状态 
        public string CURSTATE { get; set; }
        //  Y     操作员
        public string OPERUSER { get; set; }
        //  Y     操作日期  
        public DateTime OPERDATE { get; set; }
        //     0  优先级 
        public decimal YXJ { get; set; }
        //     '0'  作业类别 
        public string ZYLB { get; set; }
        //     '0'  波次号
        public string BCH { get; set; }
        //  Y     订单类型(A小订单，B中订单，C大订单)
        public string DDLX { get; set; }
        //  Y  'N'  状态  
        public string ZT { get; set; }
        public string ZYZT { get; set; }
        //  Y  'N'  回传标志 
        public string WMFLG { get; set; }
        //   备注 
        public string BZ { get; set; }
    }
}
