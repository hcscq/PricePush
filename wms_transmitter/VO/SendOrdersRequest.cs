using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using wms_transmitter.Common;

namespace wms_transmitter.VO
{
    [Serializable]
    public class SendOrdersRequest
    {
        /// <summary>
        /// 仓库编号（发网提供）
        /// </summary>
        public string WarehouseCode { get; set; }

        /// <summary>
        /// 客户销售订单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 要求配送快递公司代码，如为空则由发网选择
        /// </summary>
        public string ExpressCode { get; set; }

        /// <summary>
        /// 物流商名称
        /// </summary>
        public string ExpressName { get; set; }

        /// <summary>
        /// 收货用户姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 收货用户邮编
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// 收货用户电话，包括区号、电话号码及分机号，中间用“-”分隔；
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 收货用户移动电话
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// 收货用户所在省，如浙江省、北京等
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 收货用户所在市，如成都市、上海市等
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 收货用户所在县（区），如果宝山区、阐北区等
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// 收货用户详细地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 商品金额
        /// </summary>
        public decimal ItemsValue { get; set; }

        /// <summary>
        /// 卖家备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 提货方式
        /// </summary>
        public string Thfs { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        public string Bmid { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        public string Ddlx { get; set; }

        /// <summary>
        /// 是否作业
        /// </summary>
        public string Sf_zy { get; set; }

        /// <summary>
        /// 是否缺货
        /// </summary>
        public string Sf_qh { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string Lxfs { get; set; }

        /// <summary>
        /// 来源店铺编号
        /// </summary>
        public string ShopCode { get; set; }

        /// <summary>
        /// 来源店铺名称
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        public DateTime PayTime { get; set; }

        /// <summary>
        /// 是否货到付款
        /// </summary>
        public bool IsCod { get; set; }
        /// <summary>
        /// 代收款项
        /// </summary>
        public Decimal CodCash { get; set; }

        /// <summary>
        /// 是否打印发票
        /// </summary>
        public bool Is_Invoice { get; set; }

        /// <summary>
        /// 会员名称
        /// </summary>
        public string Member { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public Decimal DJ { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        public Decimal OrderAmount { get; set; }

        /// <summary>
        /// 代收金额
        /// </summary>
        public Decimal CodAmount { get; set; }

        /// <summary>
        /// 清单明细金额
        /// </summary>
        public float Total { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        public string Waybill { get; set; }

        /// <summary>
        /// 是否市场活动订单
        /// </summary>
        public bool MarketingActivity { get; set; }

        /// <summary>
        /// 订单包含的商品信息
        /// </summary>
        public List<Goods> items { get; set; }

        /// <summary>
        /// 快递发件网点编号
        /// </summary>
        public string SendStationCode { get; set; }
        /// <summary>
        /// 快递公司发件网点名
        /// </summary>
        public string SendStation { get; set; }   
        /// <summary>
        /// 目的地城市（大头笔）
        /// </summary>
        public string TargetArea { get; set; }

        /// <summary>
        /// 目的地代码
        /// </summary>
        public string TargetAreaCode { get; set; }

        /// <summary>
        ///目的地站点
        /// </summary>
        public string TargetStation { get; set; }

        /// <summary>
        /// 目的地站点代码
        /// </summary>
        public string TargetStationCode { get; set; }

    }
}
