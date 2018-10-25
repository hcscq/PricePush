
using System.Collections.Generic;


using wms_transmitter.Domain;
using wms_transmitter.VO;

namespace wms_transmitter.Dao
{
    /// <summary>
    /// 系统参数接口
    /// </summary>
    public interface KsoaPricePushDao 
    {
        List<UpdatePrice> getData(PriceSelectCon condition);

        int update(List<updateItem> arrList, Common.PricePush.PushResult state);
        int update(List<UpdatePrice> arrList);
    }
}
