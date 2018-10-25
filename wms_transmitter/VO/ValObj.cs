using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.VO
{
    [Serializable]
    /// <summary>
    /// 单据实体类
    /// </summary>
    public class ValObj
    {
        //单据编号
        public string djbh { get; set; }
        //单据编号集合
        public List<string> djbhList { get; set; }
        //业主ID
        public string yzid { get; set; }
        //波次号
        public string bch { get; set; }
        //移动电话
        public string mobile { get; set; }
        //拣货组编号
        public string pickgroupno { get; set; }
        //是否取消
        public int isCancel { get; set; }
        //物流商ID
        public string dwid { get; set; }
        //物流商名称
        public string dwmch { get; set; }
        //商品ID
        public string spbh { get; set; } 
        // 来源店铺编号
        public string shopno { get; set; }
        //打印类型
        public string dylx { get; set; }

        //订单来源
        public string orderFrom { get; set; }
        //行数
        public int rowNum { get; set; }

        //物流商编号
        public string cacode { get; set; }

        //是否货到付款
        public int iscod { get; set; }
    }
}
