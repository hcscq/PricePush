using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Web;
using Tesla.Net;

namespace wms_transmitter.Common
{
    public static class WebUtil
    {
        public static HttpWebRequest GetWebRequest(string url, string method)
        {
            HttpWebRequest req = null;
            req = (HttpWebRequest)WebRequest.Create(url);
            req.ServicePoint.Expect100Continue = false;
            req.Method = method;
            req.KeepAlive = true;
           // req.Timeout = 30000;

            return req;
        }
        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <returns>HTTP响应</returns>
        public static string DoPost(string url, IDictionary<string, string> parameters)
        {
            HttpWebRequest req = GetWebRequest(url, "POST");
            req.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

            Console.Write(BuildQuery(parameters));
            
            byte[] postData = Encoding.UTF8.GetBytes(BuildQuery(parameters));
            System.IO.Stream reqStream = req.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();
            req.Timeout = 300000;
            req.ProtocolVersion = HttpVersion.Version10;
            //req.ContentType = "html/text";
            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
             
            Encoding encoding = Encoding.GetEncoding(string.IsNullOrEmpty(rsp.CharacterSet)? "UTF-8": rsp.CharacterSet);
            return GetResponseAsString(rsp, encoding);
        }

        ///// <summary>
        ///// 执行HTTP POST请求。
        ///// </summary>
        ///// <param name="url">请求地址</param>
        ///// <param name="parameters">请求参数</param>
        ///// <returns>HTTP响应</returns>
        //public static string DoPost(string url, string parameters)
        //{
        //    HttpWebRequest req = GetWebRequest(url, "POST");
        //    req.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";



        //    byte[] postData = Encoding.UTF8.GetBytes(parameters);
        //    System.IO.Stream reqStream = req.GetRequestStream();
        //    reqStream.Write(postData, 0, postData.Length);
        //    reqStream.Close();
        //    req.Timeout = 300000;
        //    HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();

        //    Encoding encoding = Encoding.GetEncoding(rsp.CharacterSet);
        //    return GetResponseAsString(rsp, encoding);
        //}





        /// <summary>
        /// 把响应流转换为文本。
        /// </summary>
        /// <param name="rsp">响应流对象</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>响应文本</returns>
        public static string GetResponseAsString(HttpWebResponse rsp, Encoding encoding)
        {
            System.IO.Stream stream = null;
            StreamReader reader = null;
            try
            {
                // 以字符流的方式读取HTTP响应

                stream = rsp.GetResponseStream();
                reader = new StreamReader(stream, encoding);
                return reader.ReadToEnd();
            }
            //catch (Exception e1)
            //{
            //    string aa = "";
            //}
            finally
            {
                // 释放资源
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
            }
        }
        

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildQuery(IDictionary<string, string> parameters,bool bol_tran=true)
        {
            StringBuilder postData = new StringBuilder();
            bool hasParam = false;

            IEnumerator<KeyValuePair<string, string>> dem = parameters.GetEnumerator();
            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                string value = dem.Current.Value;
                // 忽略参数名或参数值为空的参数
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value))
                {
                    if (hasParam)
                    {
                        postData.Append("&");
                    }
                    postData.Append(name);
                    postData.Append("=");
                    foreach (char item in value)
                        if ((item >= 'A' && item <= 'Z') || (item >= 'a' && item <= 'z') || (item >= '0' && item <= '9'))
                            postData.Append(item);
                        else {
                            string aaji = item.ToString();
                            postData.Append(bol_tran ? HttpUtility.UrlEncode(item.ToString(), Encoding.UTF8).ToUpper() : item.ToString());
                        }
                    //postData.Append(bol_tran ? HttpUtility.UrlEncode(value.ToString(), Encoding.UTF8) : value);

                    hasParam = true;
                }
            }

            return postData.ToString();
        }
    }
}
