using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Domain
{
    //生产库退货单明细表对象
    [Serializable]
    public class NoticeD
    {
        //单据编号
        public string djbh { get; set; }
        //行号
        public string dj_sort { get; set; }
        //商品内码
        public string spid { get; set; }
        //批号内码
        public string phid { get; set; }
        //件数
        public string js { get; set; }
        //数量
        public string sl { get; set; }
        //零散数
        public string lss { get; set; }
        //是否执行
        public string sf_zx { get; set; }
        //单价
        public string dj { get; set; }
        //金额
        public string je { get; set; }
        //批次号
        public string pch { get; set; }
        //销售出库单据编号
        public string djbh_sj { get; set; }
        //销售出库单据行号
        public string dj_sort_sj { get; set; }
        //验收评定
        public string yspd { get; set; }
        //退货原因
        public string thyy_sj { get; set; }
        //批号
        public string ph { get; set; }
        //批准文号
        public string pzwh { get; set; }
        //生产日期
        public string rq_sc { get; set; }
        //有效期至
        public string yxqz { get; set; }
        //托盘条码
        public string tptm { get; set; }
        //审核意见
        public string yj_sh { get; set; }
        //是否审核
        public string sf_sh { get; set; }
        //是否代管
        public string sf_dg { get; set; }
        //是否拒收
        public string sf_js { get; set; }
        //假退货原因
        public string thyy_j { get; set; }
        //货物状态
        public string hwzt { get; set; }
        //是否上架审核
        public string sf_sjsh { get; set; }
        //业主内码
        public string yzid { get; set; }
        //库别：用于指定库别上架
        public string kb { get; set; }
        //库房编号
        public string kfbh { get; set; }
        //收货结论
        public string shjl { get; set; }
        //是否复检
        public string sf_fj { get; set; }
        //复检情况
        public string fjqk { get; set; }
        //复检结论
        public string fjjl { get; set; }
        //处理意见
        public string clyj { get; set; }
        //复检审核
        public string sf_fjsh { get; set; }
        //冷藏信息
        public string ccyskzsm { get; set; }
        //是否收货审核
        public string sf_shsh { get; set; }
        //是否生成拒收记录
        public string sf_scjs { get; set; }
        //审核实际数量
        public string shsl { get; set; }
        //备注
        public string bz { get; set; }
        //收货日期
        public string rq_sh { get; set; }
        //操作员
        public string ry_czy { get; set; }
        //容器号
        public string container { get; set; }
        //验收员1
        public string ry_ysy1 { get; set; }
        //验收员2
        public string ry_ysy2 { get; set; }
        //收货员
        public string ry_shy { get; set; }
        //计划件数
        public string js_jh { get; set; }
        //计划数量
        public string sl_jh { get; set; }
        //计划零散数
        public string lss_jh { get; set; }                             
    }
}
