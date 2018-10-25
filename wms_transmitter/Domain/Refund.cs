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
   public class RefundBill
    {
            public string SPBH { get; set; }
       		public string DJBH{get;set;}
			public string DWID{get;set;}
			public DateTime RQ{get;set;}
			public string BMID{get;set;}
			public string RY_YWY{get;set;}
			public string RY_SHOUHY{get;set;}
			public string RY_FUHY{get;set;}
			public string RY_CZY{get;set;}
			public string THLB{get;set;}
			public string SF_ZX{get;set;}
			public string DJBH_SJ{get;set;}
			public string YZID{get;set;}
			public string RY_ZJY{get;set;}
			public string SPID{get;set;}
			public int SL{get;set;}
			public float DJ{get;set;}
			public float JE{get;set;}
            public long DJ_SORT { get; set; }
			public long DJ_SORT_SJ{get;set;}
			public string THYY{get;set;}
			public string PH{get;set;}
			public string RQ_SC{get;set;}
			public string YXQZ{get;set;}
			public float DJ_XS{get;set;}
            public string YSPD { get; set; }
            public string EXPRESSCODE { get; set; }
            public string EXPRESSNAME { get; set; }
            public string EXPRESSNUMBER { get; set; }
            public string SF_YBTH { get; set; }

    }
}
