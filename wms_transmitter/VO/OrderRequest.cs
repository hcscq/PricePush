using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.VO
{
    public class OrderRequest
    {
        /// <summary>
        /// 销售订单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 锁定备注
        /// </summary>
        public string LockRemark { get; set; }

        /// <summary>
        /// 销售平台同步状态
        /// </summary>
        public bool IsDelivered { get; set; }
    }
}
