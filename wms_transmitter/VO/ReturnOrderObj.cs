using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.VO
{
    public class ReturnOrderObj
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// SKU编码（商品唯一条码）
        /// </summary>
        public string SkuCode { get; set; }

        /// <summary>
        /// 退货商品数量
        /// </summary>
        public int ItemCount { get; set; }

        /// <summary>
        /// 库存状态：NORMAL-正常（可售） SCRAP-次品 （不可售）
        /// </summary>
       public string Status { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        public string ProductBatch { get; set; }
    }
}
