using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using wms_transmitter.Dao;
using wms_transmitter.Dao.Impl;
using wms_transmitter.Domain;

namespace wms_transmitter.Common
{
    public static class Logger
    {
        /// <summary>
        /// 写日志到本地文件 
        /// </summary>
        /// <param name="logStr">写入的日志</param>
        /// <returns></returns>
        public static bool WritingLog(string logStr)
        {
            try
            {
                //日志文件路径 每天一日志文件
                string path = Application.StartupPath + @"\Log\" + DateTime.Now.ToString("yyyy-MM-dd") + ".log";
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                //写日志
                using (FileStream fs = new FileStream(path, FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.GetEncoding("gb2312")))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"));
                        sb.Append(":");
                        sb.Append(logStr);
                        sb.Append("\r\n");
                        sw.Write(sb.ToString());
                        sw.Close();
                    }
                }
                return true;  //写入日志成功
            }
            catch
            {
                return false;
            }
        }

       /// <summary>
        /// 写日志到本地文件 
       /// </summary>
       /// <param name="logStr">写入的日志</param>
       /// <param name="logFileName">存放日志的文本文件 如 localLog.log</param>
       /// <returns></returns>
        public static bool WritingLog(string logStr, string logFileName)
        {
            try
            {
                //日志文件路径  
                string path = Application.StartupPath + @"\Log\" + logFileName;
                //找到日志文件才写日志
                if (File.Exists(path))
                {
                    using (FileStream fs = new FileStream(path, FileMode.Append))
                    {
                        using (StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.GetEncoding("gb2312")))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.Append(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            sb.Append(":");
                            sb.Append(logStr);
                            sb.Append("\r\n");
                            sw.Write(sb.ToString());
                            sw.Close();
                        }
                    }
                    return true;  //写入日志成功
                }
                else
                { return false; }
            }
            catch
            {
                return false;
            }
        }

        //记录操作日志到表[ORDER_LEFETIME_MESSAGE]中
        public static void WriteLog(string djbh,string operName,int stepCode,string stepName)
        {
            try
            {
                string _ComputName = System.Net.Dns.GetHostName();
                string _ComputIp = System.Net.Dns.GetHostByName(System.Environment.MachineName).AddressList[0].ToString();                
                var BM = new LefetimeM
                {
                    ORDER_NO = djbh,
                    CONTENT = "主机名：" + _ComputName + "，IP：" + _ComputIp,
                    OPERATOR_NAME = operName,
                    BUSSNESS_STEP_NO = stepCode,
                    BUSSNESS_STEP_NAME = stepName
                };
                ICommonDao cdao = new CommonDaoImpl();
                cdao.insertLefetimeM(BM);
            }
            catch(Exception e)
            {
                WritingLog("单据[" + djbh + "]日志记录异常：" + e.Message);
            }
        }

    }
}
