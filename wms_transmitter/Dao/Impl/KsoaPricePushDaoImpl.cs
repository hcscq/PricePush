
using System.Collections.Generic;
using IBatisNet.DataMapper;
using wms_transmitter.Domain;
using wms_transmitter.VO;
using wms_transmitter.Common;
using System;
using System.Configuration;

namespace wms_transmitter.Dao.Impl
{
    /// <summary>
    /// 系统参数实现类
    /// </summary>
    public class KsoaPricePushDaoImpl : BaseDao, KsoaPricePushDao
    {

        
        public KsoaPricePushDaoImpl() : base()
        {
            selCondition.Dcount = int.TryParse(ConfigurationManager.AppSettings["PpackSize"],out selCondition.Dcount)? selCondition.Dcount:10;
            selCondition.stock = "HWI00000035";
            timeSpan = int.TryParse(ConfigurationManager.AppSettings["PtimeSpan"], out timeSpan) ? timeSpan : 10000;
        }
        public KsoaPricePushDaoImpl(ISqlMapper map) : base(map) { }

        public List<string> staBillList = new List<string>();
        public List<string> staOBillList = new List<string>();
        public int timeSpan = 10000; 
        public DateTime newExeTime = DateTime.Now ;
        public PriceSelectCon selCondition = new PriceSelectCon();
        public string serURL = ConfigurationManager.AppSettings["PserverUrl"];
        public bool Pause = false;
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="num">最大记录条数</param>
        /// <returns>得到的List</returns>
        public List<UpdatePrice> getData(PriceSelectCon condition)
        { 
            List<UpdatePrice> re = (List<UpdatePrice>)GetMapper(ComonUtil.Connection.KSOA_SQLServer).QueryForList<UpdatePrice>("PriceChanged.GetData", condition);
            return re;
        }
        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="arrList">更新列表</param>
        /// <returns></returns>
        public int update(List<updateItem> arrList, PricePush.PushResult state)
        {
            int re = -1;
            if (arrList.Count <= 0)
                return 0;
            //var q=arrList.AsEnumerable().Select((updateItem item)=> { return item.ID; }).ToList();
            if (state == PricePush.PushResult.ALL)
                re = GetMapper(ComonUtil.Connection.KSOA_SQLServer).Update("PriceChanged.ALL", arrList);
            else
            if (state == PricePush.PushResult.SUCCESS)
                re = GetMapper(ComonUtil.Connection.KSOA_SQLServer).Update("PriceChanged.UpdateSuccess", arrList);
            else if (state== PricePush.PushResult.FAILED) 
                re = GetMapper(ComonUtil.Connection.KSOA_SQLServer).Update("PriceChanged.UpdateFailed", arrList);
            else
                if (state == PricePush.PushResult.NOTFINDGOODS)
                re = GetMapper(ComonUtil.Connection.KSOA_SQLServer).Update("PriceChanged.NotFindGoods", arrList);
            return re;
        }

        public int update(List<UpdatePrice> arrList)
        {
            int re = -1;
            if (arrList.Count <= 0)
                return 0;
            re = GetMapper(ComonUtil.Connection.KSOA_SQLServer).Update("PriceChanged.ALL", arrList);

            return re;
        }
    }
}