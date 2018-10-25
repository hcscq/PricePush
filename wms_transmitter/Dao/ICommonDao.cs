using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wms_transmitter.VO;
using wms_transmitter.Domain;
using wms_transmitter.Common;

namespace wms_transmitter.Dao
{
    /// <summary>
    /// 系统参数接口
    /// </summary>
    public interface ICommonDao
    {
        /// <summary>
        /// 获取系统时间
        /// </summary>
        /// <returns></returns>
        DateTime selectDate(ComonUtil.Connection dataSor=ComonUtil.Connection.WMS_Oracle11G);

        /// <summary>
        /// 物流商编号
        /// </summary>
        /// <returns></returns>
        string QueryPhysicalId(ValObj vo);

        /// <summary>
        /// 物流商名称
        /// </summary>
        /// <returns></returns>
        string QueryPhysicalName(ValObj vo);

        /// <summary>
        /// 运单类型
        /// </summary>
        /// <returns></returns>
        string QueryWaybill(ValObj vo);

        /// <summary>
        /// 商品
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        string QueryGoods(ValObj vo);

        /// <summary>
        /// 店铺
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        string QueryShop(ValObj vo);

        /// <summary>
        /// 查询出库主表
        /// </summary>
        /// <param name="BM"></param>
        /// <returns></returns>
        string QueryBillingM(ValObj vo);

        /// <summary>
        /// 插入全程跟踪数据
        /// </summary>
        /// <param name="BM"></param>
        /// <returns></returns>
        int insertLefetimeM(LefetimeM BM);
    }
}
