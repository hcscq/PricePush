using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using wms_transmitter.Domain;
using System.Collections;
using System.Data;
using wms_transmitter.VO;

namespace wms_transmitter.Dao
{
    /// <summary>
    /// 系统参数接口
    /// </summary>
    public interface StateUpdateBillDao
    {
        List<UpdateStateBill> getBillState(ValObj vo);
        List<SendOutOrder> getOutBill(ValObj vo);
        List<SendOutOrder> getOutCFBill(ValObj vo);

        int updateBillState(List<OrderResult> arrList);
        int updateOutBill(List<OrderResult> arrList);
    }
}
