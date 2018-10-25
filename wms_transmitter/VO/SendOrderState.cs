using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Domain
{
    [Serializable]
    class SendOrderState
    {

        /// <summary>
        /// 客户销售订单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 动作名称
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// 更新之前的订单状态
        /// </summary>
        public string PreState { get; set; }

        /// <summary>
        /// 更新后的订单状态
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public string OperDate { get; set; }

        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OperatorName { get; set; }

        /// <summary>
        /// 操作员ID
        /// </summary>
        public string OperatorId { get; set; }

        public string ZYZT { get; set; }

        /// <summary>
        /// 重传次数(为0时为第一次)
        /// </summary>
        public int Retry { get; set; }
    }
}
