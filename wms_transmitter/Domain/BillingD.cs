using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Domain
{
    /// <summary>
    /// 生产库订单明细对象
    /// </summary>
    [Serializable]
    public class BillingD
    {
        //单据编号
        public string djbh { get; set; }
        //订单明细行号
        public string dj_sort { get; set; }
        //商品ID
        public string spid { get; set; }
        //库房编号
        public string kfbh { get; set; }
        //数量
        public int sl { get; set; }
        //件数
        public string js { get; set; }
        //零散数
        public string lss { get; set; }
        //单件
        public decimal dj { get; set; }
        //金额
        public decimal je { get; set; }
        //含税金额
        public string hsje { get; set; }
        //显示单价
        public string dj_xs { get; set; }
        //显示金额
        public string xsje { get; set; }
        //税率
        public string slv { get; set; }
        //税额
        public string se { get; set; }
        //扣率
        public string kl { get; set; }
        //批号要求
        public string ph { get; set; }
        //批号处理方式
        public string phclfs { get; set; }
        //商品属性
        public string spsx { get; set; }
        //查询标志
        public string cxbz { get; set; }
        //存储分类
        public string ccfl { get; set; }
        //效期要求
        public string xqyq { get; set; }
        //库存不足数量
        public string sl_kcbz { get; set; }
        //近效期要求
        public string jxqyq { get; set; }
        //综合要求结果
        public string sf_yyq { get; set; }
        //作业状态
        public string zyzt { get; set; }
        //整件未处理数量
        public string sl_zjwcl { get; set; }
        //零货未处理数量
        public string sl_lhwcl { get; set; }
        //促销描述
        public string cxms { get; set; }
        //是否挂起
        public string sf_gq { get; set; }
        //是否促销商品
        public string sf_cxsp { get; set; }
        //是否有错误
        public string sf_ycw_sl { get; set; }
        //计划数量
        public int sl_jh { get; set; }
        //是否越库
        public string sf_yk { get; set; }
        //零售价
        public string lsj { get; set; }
        //业主ID
        public string yzid { get; set; }
        //冲红原因
        public string chyy { get; set; }
        //发票号
        public string invoiceno { get; set; }
        //发票ID
        public string invoiceid { get; set; }
        //发票金额
        public string amount { get; set; }
        //发票抬头
        public string title { get; set; }
        //发票内容
        public string content { get; set; }
        //规格代码
        public string skucode { get; set; }
        //发票类型
        public string invoicetype { get; set; }
    }
}
