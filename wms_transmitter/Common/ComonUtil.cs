using System;

using System.Text;
using IBatisNet.DataMapper.Configuration;
using IBatisNet.DataMapper;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Configuration;
using wms_transmitter.Domain;
using System.Collections.Generic;

namespace wms_transmitter.Common
{
    public static class PricePush
    {
        public static bool g_IsPricePushFinish = true;
        public static bool g_PricePushPuase = true;
        public enum PushResult { SUCCESS, FAILED,NOTFINDGOODS,ALL };
        public enum DataType {TRYTIMES,SUCCESSTIMES,FAILEDTIMES,SENDDETIALS,DETIALSSUCCESS,DETIALSFAILED ,NEXTEXECTIME,CLOSEWINDOW};
        public static List<PPEndPointDef> g_PPConfigList = new List<PPEndPointDef>() {
            new PPEndPointDef() {RemoteUrl= ConfigurationManager.AppSettings["PserverUrl"],_Status=new Status(){Success=1,Failed=2,NotFound=4 },Name="PDC" },
            new PPEndPointDef() {RemoteUrl= ConfigurationManager.AppSettings["PserverUrlHOC"],_Status=new Status(){Success=8,Failed=16,NotFound=32 },Name="HOC" }
        };

    }
    public static class ComonUtil
    {
        public enum Connection{KSOA_SQLServer, WMS_Oracle11G };
        public static bool g_WMSFunForbidon = bool.TryParse(ConfigurationManager.AppSettings["WMSFunForbidon"], out g_WMSFunForbidon) ? g_WMSFunForbidon : true;
        //ConfigurationManager.AppSettings["WMSFunForbidon"];
        public static bool g_PriceFunForbidon = bool.TryParse(ConfigurationManager.AppSettings["PriceFunForbidon"], out g_PriceFunForbidon) ? g_PriceFunForbidon : true;


        public static bool g_IsStaFinish = true;
        public static bool g_IsOBillFinish = true;
        public static bool g_IsRefundBillFinish = true;

        public static bool g_IsStaFinishCF = true;
        public static bool g_IsOBillFinishCF = true;
        public static bool g_IsRefundBillFinishCF = true;
        public static string serviceUrl = ConfigurationManager.AppSettings["serverUrl"];
        public static string serviceCFUrl = ConfigurationManager.AppSettings["serverCFUrl"];
        public static string packSize = ConfigurationManager.AppSettings["packSize"];
        public static int timeSpan = int.TryParse(ConfigurationManager.AppSettings["timeSpan"], out timeSpan) ? timeSpan : 5000;
        public static int htyCheckLimt = int.TryParse(ConfigurationManager.AppSettings["htyCheckLimt"], out htyCheckLimt) ? htyCheckLimt : 200;
       
        /// <summary>
        /// SQL映射相关
        /// </summary>
        /// <returns>SQL映射</returns>
        public static ISqlMapper GetMapper(Connection conn=Connection.WMS_Oracle11G)
        {
            DomSqlMapBuilder builder = new DomSqlMapBuilder();
            ISqlMapper sqlMap = null;
            try
            {
                if(conn==Connection.WMS_Oracle11G)
                    sqlMap = builder.Configure("Config/sqlmap.config");
                else
                    sqlMap= builder.Configure("Config/sqlmap_SqlServer.config");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return sqlMap;
        }

        /// <summary>
        /// 签名方法
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Sign(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            // 第四步：把二进制转化为大写的十六进制
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                result.Append(bytes[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
}