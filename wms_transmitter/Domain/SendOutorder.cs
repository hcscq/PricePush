using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class SendOutOrder
    {
        #region 明细部分
        /// <summary>
        /// 单据编号
        /// </summary>
        public string DJBH;
        /// <summary>
        /// 单据排序号
        /// </summary>
        public decimal DJ_SORT;
        /// <summary>
        /// 商品ID
        /// </summary>
        public string SPID;
        /// <summary>
        /// 数量
        /// </summary>
        public decimal SL;
        /// <summary>
        /// 件数
        /// </summary>
        public decimal JS;
        /// <summary>
        /// 零散数
        /// </summary>
        public decimal LSS;
        /// <summary>
        /// 单价
        /// </summary>
        public decimal DJ;
        /// <summary>
        /// 金额
        /// </summary>
        public decimal JE;
        /// <summary>
        /// 含税金额
        /// </summary>
        public decimal JE_HS;
        /// <summary>
        /// 税率
        /// </summary>
        public decimal SLV;
        /// <summary>
        /// 税额
        /// </summary>
        public decimal SE;
        /// <summary>
        /// 扣率
        /// </summary>
        public decimal KL;
        /// <summary>
        /// 显示单价
        /// </summary>
        public decimal DJ_XS;
        /// <summary>
        /// 有效期要求
        /// </summary>
        public DateTime XQYQ;
        /// <summary>
        /// 批号
        /// </summary>
        public string PH;
        /// <summary>
        /// 批号处理方式
        /// </summary>
        public string PHCLFS;
        /// <summary>
        /// 零售价
        /// </summary>
        public decimal LSJ;
        /// <summary>
        /// 发票号
        /// </summary>
        public string INVOICENO;
        /// <summary>
        /// 发票ID
        /// </summary>
        public string INVOICEID;
        /// <summary>
        /// 发票金额
        /// </summary>
        public decimal AMOUNT;
        /// <summary>
        /// 发票抬头
        /// </summary>
        public string TITLE;
        /// <summary>
        /// 发票内容
        /// </summary>
        public string CONTENT;
        /// <summary>
        /// 发票代码
        /// </summary>
        public string SKUCODE; 
        /// <summary>
        /// 发票类型
        /// </summary>
        public string INVOICETYPE;
        #endregion 

        #region 汇总部分
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime RQ;
        /// <summary>
        /// 提货方式
        /// </summary>
        public string THFS;
        /// <summary>
        /// 提货时间
        /// </summary>
        public string THSJ;
        /// <summary>
        /// 操作员
        /// </summary>
        public string RY_CZY;
        /// <summary>
        /// 开票类别
        /// </summary>
        public string KPLB;
        /// <summary>
        /// 订单类型
        /// </summary>
        public string DDLX;
        /// <summary>
        /// 客户备注
        /// </summary>
        public string KHBZ;
        /// <summary>
        /// 销售类型
        /// </summary>
        public string XSLX;
        /// <summary>
        /// 配送类型
        /// </summary>
        public string PSLX;
        /// <summary>
        /// 送货地址
        /// </summary>
        public string SHDZ;
        /// <summary>
        /// 联系方式
        /// </summary>
        public string LXFS;
        /// <summary>
        /// 收货人
        /// </summary>
        public string SHR;
        /// <summary>
        /// 来源订单类型
        /// </summary>
        public string FROMTY;
        /// <summary>
        /// 物流公司名称
        /// </summary>
        public string CANAME;
        /// <summary>
        /// 物流公司代码
        /// </summary>
        public string CACODE;
        /// <summary>
        /// 来源店铺代码
        /// </summary>
        public string SHOPNA;
        /// <summary>
        /// 仓库编码
        /// </summary>
        public string WHCODE;
        /// <summary>
        /// 会员昵称
        /// </summary>
        public string BUNICK;
        /// <summary>
        /// 会员名称
        /// </summary>
        public string CUSTNA;
        /// <summary>
        /// 收件人姓名
        /// </summary>
        public string RECENA;
        /// <summary>
        /// 省编码
        /// </summary>
        public string PROVCO;
        /// <summary>
        /// 省名称
        /// </summary>
        public string PROVNA;
        /// <summary>
        /// 市编码
        /// </summary>
        public string CITYCO;
        /// <summary>
        /// 市名称
        /// </summary>
        public string CITYNA;
        /// <summary>
        /// 区编码
        /// </summary>
        public string DISTCO;
        /// <summary>
        /// 区名称
        /// </summary>
        public string DISTNA;
        /// <summary>
        /// 收获地址
        /// </summary>
        public string ADDRES;
        /// <summary>
        /// 手机
        /// </summary>
        public string MOBIL;
        /// <summary>
        /// 快递单号
        /// </summary>
        public string CODE_NUMBER;


        //订单来源（1：非处方药；2：处方药）
        private string OrderFrom = "1";
        public string orderFrom
        {
            set { OrderFrom = value; }
            get { return OrderFrom; }
        }

        #endregion
    }
}
