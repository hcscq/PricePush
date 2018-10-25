
using System;
using Newtonsoft.Json;

namespace wms_transmitter.VO
{
    /// <summary>
    /// 取消接口请求对象
    /// </summary>
    public class CancelReturnOrdeRequest
    {
        /// <summary>
        /// 销售订单号
        /// </summary>
        public string ReturnOrderId { get; set; }


        /// <summary>
        /// 备注信息
        /// </summary>
        public string Remark { get; set; }

    }
}
