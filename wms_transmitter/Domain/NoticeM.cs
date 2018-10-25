using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wms_transmitter.Domain
{
    //生产库退货单表对象
    [Serializable]
    public class NoticeM
    {
        //单据编号
        public string djbh {get; set;}
        //日期
        public DateTime rq {get; set;}
        //单位内码
        public string dwid {get; set;}
        //部门内码
        public string bmid {get; set;}
        //业务员
        public string ry_ywy {get; set;}
        //质检员
        public string ry_zjy {get; set;}
        //收货员
        public string ry_shouhy {get; set;}
        //操作员
        public string ry_czy {get; set;}
        //到货方式
        public string dhfs {get; set;}
        //是否执行
        public string sf_zx {get; set;}
        //是否下传
        public string sf_xc {get; set;}
        //是否取消
        public int isCancel { get; set; }
        //来源单号
        public string djbh_sj {get; set;}
        //是否中药
        public string sf_zy {get; set;}
        //审核员
        public string ry_shenhy {get; set;}
        //审核意见
        public string yj_sh {get; set;}
        //是否审核
        public string sf_sh {get; set;}
        //是否代管
        public string sf_dg {get; set;}
        //是否拒收
        public string sf_js {get; set;}
        //是否打印
        public string sf_dy {get; set;}
        //配送员
        public string ry_psy {get; set;}
        //是否上架审核
        public string sf_sjsh {get; set;}
        //上架审核人
        public string ry_sjshr {get; set;}
        //
        public string dj_ssgs {get; set;}
        //业主内码
        public string yzid {get; set;}
        //
        public string ry_zjy1 {get; set;}
        //是否收货审核
        public string sf_shsh {get; set;}
        //复检日期
        public DateTime fjrq {get; set;}
        //复检员
        public string ry_fjy {get; set;}
        //退货类别
        public string thlb {get; set;}
        //
        public string bill_cancel {get; set;}
        //仓库编码
        public string whcode {get; set;}
        //店铺编码
        public string storecode {get; set;}
        //快递公司编号
        public string expresscode {get; set;}
        //快递单号
        public string expressnumber {get; set;}
        //移动电话
        public string mobile {get; set;}
        //会员地址
        public string consigneeaddress {get; set;}
        //会员名称
        public string consigneename {get; set;}
        //店铺代码
        public string shopcode {get; set;}
        //店铺名称
        public string shopname {get; set;}
        //配货单号
        public string orderno {get; set;}
        //收货员2
        public string ry_shouhy2 {get; set;}
        //固定电话
        public string teleph {get; set;}
        //单据类型
        public string djbhtype { get; set; }
        
        // 备注
        public string remark { get; set; }

        // 客服标记
        public string custSer { get; set; }

        // 退货单类型
        public string type { get; set; }

        //订单来源平台
        public string opform { get; set; }

        //来源系统编号（1：DTC；2：管易；3：时空）
        public int fromsys { get; set; }

        public List<NoticeD> dList { get; set; }
    }
}
