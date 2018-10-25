
using System.Collections.Generic;
using System.Linq;
using IBatisNet.DataMapper;
using wms_transmitter.Domain;
using wms_transmitter.VO;
using wms_transmitter.Common;

namespace wms_transmitter.Dao.Impl
{
    /// <summary>
    /// 系统参数实现类
    /// </summary>
    public class StateUpdateBillDaoImpl : BaseDao, StateUpdateBillDao
    {
        public StateUpdateBillDaoImpl() : base() { }
        public StateUpdateBillDaoImpl(ISqlMapper map) : base(map) { }

        public List<string> staBillList = new List<string>();
        public List<string> staOBillList = new List<string>();

        /// <summary>
        /// 查询订单状态
        /// </summary>
        /// <param name="num">订单数量</param>
        /// <returns>得到的List</returns>
        public List<UpdateStateBill> getBillState(ValObj vo)
        {
            List<UpdateStateBill> re = (List<UpdateStateBill>)GetMapper().QueryForList<UpdateStateBill>("StateUpdateBill.getBillState", vo);
            staBillList.Clear(); 
            for (int i = 0; i < re.Count; i++) staBillList.Add(re[i].DJBH);
            if (re.Count <= ComonUtil.htyCheckLimt)
            {
                var tmp = re;
                re = (List<UpdateStateBill>)GetMapper().QueryForList<UpdateStateBill>("StateUpdateBill.getBillStateHTY", vo);
                if (re.Count <= 0) return tmp;
            }
            return re;
        }

        /// <summary>
        /// 获取出库订单
        /// </summary>
        /// <param name="num">订单数量</param>
        /// <returns>得到的List</returns>
        public List<SendOutOrder> getOutBill(ValObj vo)
        {
            List<SendOutOrder> re = (List<SendOutOrder>)GetMapper().QueryForList<SendOutOrder>("StateUpdateBill.getOutBill", vo);
            staOBillList.Clear();
            var l = re.GroupBy(it => it.DJBH).Distinct().ToList();
            for (int i = 0; i < l.Count; i++) staOBillList.Add(l[i].Key);
            return re;
        }

        /// <summary>
        /// 获取处方药出库订单
        /// </summary>
        /// <param name="num">订单数量</param>
        /// <returns>得到的List</returns>
        public List<SendOutOrder> getOutCFBill(ValObj vo)
        {
            List<SendOutOrder> re = (List<SendOutOrder>)GetMapper().QueryForList<SendOutOrder>("StateUpdateBill.getOutCFBill", vo);
            staOBillList.Clear();
            var l = re.GroupBy(it => it.DJBH).Distinct().ToList();
            for (int i = 0; i < l.Count; i++) staOBillList.Add(l[i].Key);
            return re;
        }

        /// <summary>
        /// 更新出库订单
        /// </summary>
        /// <param name="arrList">订单列表</param>
        /// <returns></returns>
        public int updateOutBill(List<OrderResult> arrList)
        {
            if (arrList == null || arrList.Count <= 0) return -1;
            return GetMapper().Update("StateUpdateBill.updateOutBill", arrList);
        }

        /// <summary>
        /// 获取退货订单
        /// </summary>
        /// <param name="num">订单数量</param>
        /// <returns>得到的List</returns>
        public List<RefundBill> getRefundBill(ValObj vo)
        {
            return (List<RefundBill>)GetMapper().QueryForList<RefundBill>("StateUpdateBill.getRefund", vo);
        }

        /// <summary>
        /// 更新退回订单
        /// </summary>
        /// <param name="arrList">订单列表</param>
        /// <returns></returns>
        public int updateRefundBill(List<OrderResult> arrList)
        {
            if (arrList == null || arrList.Count <= 0) return -1;
            return GetMapper().Update("StateUpdateBill.updateRefund", arrList);
        }

        public int updateBillOperDate(List<OrderResult> list, string opName)
        {
            if (list == null || list.Count <= 0) return -1;
            return GetMapper().Update(opName, list);
        }

        /// <summary>
        /// 更新订单状态
        /// </summary>
        /// <param name="arrList">订单列表</param>
        /// <returns></returns>
        public int updateBillState(List<OrderResult> arrList)
        {
            if (arrList == null || arrList.Count <= 0) return -1;
            return GetMapper().Update("StateUpdateBill.updateBillState", arrList);
        }
        /// <summary>
        /// 监测、更新退货单状态验收评定全为3
        /// </summary>
       
        /// <returns></returns>
        public int updateToThree()
        {

            return GetMapper().Update("StateUpdateBill.setToThree","");
        }

    }
}