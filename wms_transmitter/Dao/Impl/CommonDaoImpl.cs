using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wms_transmitter.VO;
using wms_transmitter.Domain;
using wms_transmitter.Common;
using IBatisNet.DataMapper;
using Oracle.ManagedDataAccess.Client;

namespace wms_transmitter.Dao.Impl
{
    public class CommonDaoImpl : BaseDao, ICommonDao
    {
        /// <summary>
        /// 获取系统时间
        /// </summary>
        /// <returns></returns>
        public DateTime selectDate(ComonUtil.Connection dataSor = ComonUtil.Connection.WMS_Oracle11G)
        {
            return (DateTime)GetMapper(dataSor).QueryForObject("Common.selectDate",null);
        }

        /// <summary>
        /// 物流商编号
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public string QueryPhysicalId(ValObj vo)
        {
            return (string)GetMapper().QueryForObject("Common.QueryPhysicalId",vo);
        }

        /// <summary>
        /// 物流商名称
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public string QueryPhysicalName(ValObj vo)
        {
            return (string)GetMapper().QueryForObject("Common.QueryPhysicalName",vo);
        }

        /// <summary>
        /// 运单类型
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public string QueryWaybill(ValObj vo)
        {
            return (string)GetMapper().QueryForObject("Common.QueryWaybill", vo);
        }

        /// <summary>
        /// 商品
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public string QueryGoods(ValObj vo)
        {
            return (string)GetMapper().QueryForObject("Common.QueryGoods", vo);
        }

        /// <summary>
        /// 店铺
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public string QueryShop(ValObj vo)
        {
            return (string)GetMapper().QueryForObject("Common.QueryShop", vo);
        }

        /// <summary>
        /// 查询出库主表
        /// </summary>
        /// <param name="BM"></param>
        /// <returns></returns>
        public string QueryBillingM(ValObj vo)
        {
            return (string)GetMapper().QueryForObject("Common.QueryBillingM", vo);
        }

        /// <summary>
        /// 插入全程跟踪数据
        /// </summary>
        /// <param name="BM"></param>
        /// <returns></returns>
        public int insertLefetimeM(LefetimeM LF)
        { 
            int i = 0;
            try
            {
                i = Convert.ToInt32(GetMapper().QueryForObject("PROC_OPERATE_REC", LF));
            }
            catch (OracleException oe)
            {
                if (oe.Number == 1)//主键重复
                {
                    i = 1;
                }
                else if (oe.Number == 12543)//数据库链接断开
                {
                    throw new InterfaceException(InterfaceExceptionType.ReTry, oe.Message);
                }
            }
            return i;
        }

    }
}
