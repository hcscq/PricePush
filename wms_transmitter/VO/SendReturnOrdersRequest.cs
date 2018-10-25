using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using wms_transmitter.Domain;


namespace wms_transmitter.VO
{
    public class SendReturnOrdersRequest
    {
        /// <summary>
        /// 仓库编号（发网提供）
        /// </summary>
        public string WarehouseCode { get; set; }

        /// <summary>
        /// 退货单号
        /// </summary>
        public string ReturnOrderId { get; set; }

        /// <summary>
        /// 来源单号
        /// </summary>
        public string LYDH { get; set; }

        /// <summary>
        /// 退回快递公司代码
        /// </summary>
        public string ExpressCode { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string Shopname { get; set; }

        /// <summary>
        /// 会员名
        /// </summary>
        public string Member { get; set; }

        /// <summary>
        /// 发件人
        /// </summary>
        public string Consigneename { get; set; }

        /// <summary>
        /// 会员电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 会员手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 退回物流单号
        /// </summary>
        public string Waybill { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        public string Djbhtype { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 客服标记
        /// </summary>
        public string custSer { get; set; }

        /// <summary>
        /// 退货单类型
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 包含的商品信息
        /// </summary>
        public List<Goods> items { get; set; }

    }
}
