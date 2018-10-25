using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using wms_transmitter.Common;

namespace HttpTestProject
{
    [TestClass]
    public class HttpTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string reqUrl = "http://localhost:9527/api";
            string key = "123";
            string action = "sendorder";
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string data = "{\"WarehouseCode\":\"002\",\"ShopCode\":\"七乐康B店\",\"OrderId\":\"DC20151015\",\"ExpressCode\":\"TT\",\"Name\":\"谭亚琼\",\"PostCode\":null,\"Phone\":\"\",\"MobilePhone\":\"13585569616\",\"Province\":\"上海\",\"City\":\"上海市\",\"County\":\"虹口区\",\"Address\":\"上海 上海市 虹口区 天宝西路248弄8号606室\",\"ItemsValue\":0.0,\"OrderAmount\":0.0,\"CodAmount\":0.0,\"Remark\":\"【997125305692226:请不要发申通快递】【998649202402226:请不要发申通快递】\",\"items\":[{\"SkuCode\":\"202020033\",\"Name\":\"【白云山】板蓝根颗粒 10g*20袋 肺胃热盛所致咽喉肿痛 口烟干燥\",\"Count\":2,\"Price\":8.8000},{\"SkuCode\":\"218010043\",\"Name\":\"【云南白药】云南白药膏打孔透气 5片 用于跌打损伤 瘀血肿痛\",\"Count\":1,\"Price\":23.9000},{\"SkuCode\":\"218030017\",\"Name\":\"【云南白药】 云南白药气雾剂 30克+85克 活血散瘀 消肿\",\"Count\":1,\"Price\":31.9000}]}";

            IDictionary<string, string> d = new Dictionary<string, string>();
            d.Add("key", key);
            d.Add("action", action);
            d.Add("time", time);
            d.Add("data", data);

            string str = key + "1qaz2wsx" + action + time + data;
            string signStr = ComonUtil.Sign(str);
            d.Add("sign", signStr);

            string result = WebUtil.DoPost(reqUrl, d);
        }
    }
}
