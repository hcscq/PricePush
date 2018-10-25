using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.VO
{
    public class Goods
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        public string SkuCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产品数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal? Total { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
