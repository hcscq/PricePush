using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using wms_transmitter.Common;


namespace wms_transmitter.Dao
{
    /// <summary>
    /// 基础数据服务对象
    /// </summary>
    public class BaseDao
    {
        private ISqlMapper sqlMap = null;

        public BaseDao(){}

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="map"></param>
        public BaseDao(ISqlMapper map)
        {
            if (sqlMap == null && map != null)
            {
                sqlMap = map;
            }
        }

        /// <summary>
        /// 配置SQL映射
        /// </summary>
        /// <returns>SQL映射</returns>
        public ISqlMapper GetMapper(ComonUtil.Connection conn=ComonUtil.Connection.WMS_Oracle11G)
        {
            if (sqlMap == null)
            {
                sqlMap = ComonUtil.GetMapper(conn);
            }
            return sqlMap;
        }
    }
}
