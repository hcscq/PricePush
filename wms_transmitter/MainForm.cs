using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using wms_transmitter.Domain;
using wms_transmitter.Dao;
using wms_transmitter.Dao.Impl;
using wms_transmitter.Service;
using System.Collections;
using wms_transmitter.Common;

namespace wms_transmitter
{
    public delegate void ActionCallEventHandler(string action, PricePush.DataType dataType = PricePush.DataType.TRYTIMES,int incCount=1);
    public partial class MainForm : Form
    {
        AcceptRequestService rs;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //启动HTTP监听服务
            rs = new AcceptRequestService();
            rs.actionevent += new ActionCallEventHandler(this.recordStatus);
            rs.syncPrice.actionevent += new ActionCallEventHandler(this.recordStatus);
            rs.StartHttp();
            //初始化界面显示
            initStatus();

        }

        //初始化页面显示状态
        private void initStatus()
        {
            if (!ComonUtil.g_WMSFunForbidon)
            {
                this.lb_OrderCacelReturnCount.Text = "0";
                this.lb_OrderEmergencyCount.Text = "0";
                this.lb_OrderInterceptCount.Text = "0";
                this.lb_OrderOutStoreCount.Text = "0";
                this.lb_OrderPauseCount.Text = "0";
                this.lb_OrderReturnCount.Text = "0";
                this.lb_OrderSendCount.Text = "0";
                this.lb_OrderStatusChangeCount.Text = "0";
                this.lb_QueryOrderStatusCount.Text = "0";
                this.lb_QueryStockCount.Text = "0";
                this.lb_refundCount.Text = "0";
                this.lb_StartTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.lb_UpdateTime.Text = "";
                this.lb_xstbptCount.Text = "0";
                this.lab_ReverseRON.Text = "0";
            }
            else
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                button_Test.Enabled = false;
                MessageBox.Show("WMS接口相关功能已禁用！","提示");
            }
            if (!ComonUtil.g_PriceFunForbidon)
            {
                ToolTip loc_tt = new ToolTip();
                loc_tt.SetToolTip(nud_Pcount,"每次推送的最大数据条数.");
                loc_tt.SetToolTip(nud_Pspan, "两次推送的最小时间间隔.");
                loc_tt.SetToolTip(lb_PallDetials, "推送到目标服务器的数据总量.");
                loc_tt.SetToolTip(lb_PfailDetials, "推送到目标服务器失败的数据总量.");
                loc_tt.SetToolTip(lb_PfailTimes, "向目标服务器推送数据失败的总次数.");
                loc_tt.SetToolTip(lb_PsucDetials, "推送到目标服务器成功的数据总量.");
                loc_tt.SetToolTip(lb_PsucTimes, "向目标服务器推送数据成功的总次数.");
                loc_tt.SetToolTip(lb_PtryTimes, "向目标服务器推送数据的总次数.");
                loc_tt.SetToolTip(lb_PnextTime, "下次向目标主机推送数据的<期望>时间.");
                this.nud_Pcount.Value = (decimal)rs.syncPrice.pushPrice.selCondition.Dcount;
                this.nud_Pspan.Value = (decimal)rs.syncPrice.pushPrice.timeSpan / 1000;
                lb_PallDetials.Text = "0";
                
                
                lb_PfailDetials.Text = "0";
                lb_PfailTimes.Text = "0";
                lb_PsucDetials.Text = "0";
                lb_PsucTimes.Text = "0";
                lb_PtryTimes.Text = "0";

                btn_writeLog.Text = rs.syncPrice.bol_allLog ? "停止截取" : "开始截取日志";
                Logger.WritingLog(rs.syncPrice.bol_allLog ? "开始截取全部日志:\r\n" : "截取全部日志结束.\r\n");
            }
            else
            {
                groupBox3.Enabled = false;
                MessageBox.Show("单价推送接口已禁用！", "提示");
            }
            btn_PricePush.Text = rs.syncPrice.pushPrice.Pause ? "启动" : "暂停";
            Logger.WritingLog(rs.syncPrice.pushPrice.Pause ? "价格推送已暂停" : "价格推送已启动");
        }

        /// <summary>
        /// 记录接口调用次数
        /// </summary>
        /// <param name="action"></param>
        private void recordStatus(string action,PricePush.DataType dataType= PricePush.DataType.TRYTIMES, int incCount=1)
        {
            switch (action)
            {
                case "sendorder":
                    incLableDisplay(lb_OrderSendCount);
                    break;
                case "sendreturnorder":
                    incLableDisplay(lb_OrderReturnCount);
                    break;
                case "reversereturnorder":
                    incLableDisplay(lab_ReverseRON);
                    break;
                case "cancelreturnorder":
                    incLableDisplay(lb_OrderCacelReturnCount);
                    break;
                case "Cancel":
                    incLableDisplay(lb_OrderInterceptCount);
                    break;
                case "lock":
                    incLableDisplay(lb_OrderPauseCount);
                    break;
                case "Urgent":
                    incLableDisplay(lb_OrderEmergencyCount);
                    break;
                case "queryStock":
                    incLableDisplay(lb_QueryStockCount);
                    break;
                case "queryOrderStatus":
                    incLableDisplay(lb_QueryOrderStatusCount);
                    break;
                case "PlatformDelivered":
                    incLableDisplay(lb_xstbptCount);
                    break;
                case "OrderState":
                    this.Invoke(new dosth(() =>
                    {
                        incLableDisplay(lb_OrderStatusChangeCount);
                        incLableDisplay(lb_OrderOutStoreCount);
                        incLableDisplay(lb_refundCount);
                    }));

                    break;
                case "PricePush":
                    UpdatePricePushLable(dataType,incCount); break;
                default: break;
            }
            this.Invoke(new dosth(() => {lb_UpdateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); }));
        }
        delegate void dosth();
        private void UpdatePricePushLable(PricePush.DataType dataType = PricePush.DataType.TRYTIMES,int incCount=0)
        {
                switch (dataType)
                {
                case PricePush.DataType.TRYTIMES:
                    this.Invoke(new dosth(() => { lb_PnextTime.Text = DateTime.Now.AddSeconds(rs.syncPrice.pushPrice.timeSpan/1000).ToString("yyyy-MM-dd HH:mm:ss"); }));
                    incLableDisplay(lb_PtryTimes, incCount); break;
                case PricePush.DataType.FAILEDTIMES: incLableDisplay(lb_PfailTimes, incCount); break;
                case PricePush.DataType.SUCCESSTIMES: incLableDisplay(lb_PsucTimes, incCount); break;
                case PricePush.DataType.SENDDETIALS: incLableDisplay(lb_PallDetials, incCount); break;
                case PricePush.DataType.DETIALSSUCCESS: incLableDisplay(lb_PsucDetials, incCount); break;
                case PricePush.DataType.DETIALSFAILED: incLableDisplay(lb_PfailDetials, incCount); break;

                case PricePush.DataType.CLOSEWINDOW: Close(); break;
                default: break;
            }
        }
        /// <summary>
        /// 调用函数
        /// </summary>
        /// <param name="lb"></param>
        private void incLableDisplay(Label lb)
        {
            lb.Text = Convert.ToString(int.Parse(lb.Text.ToString()) + 1);
        }
        private void incLableDisplay(Label lb,int inc)
        {
            this.Invoke(new dosth(() =>
            {
                lb.Text = Convert.ToString(int.Parse(lb.Text.ToString()) + inc);
            }));       
        }

        //数据库连接测试
        private void button_Test_Click(object sender, EventArgs e)
        {
            button_Test.Enabled = false;
            try
            {
                ICommonDao dao = new CommonDaoImpl();
                DateTime datetime = dao.selectDate();
                MessageBox.Show("连接服务器成功！\n\r 当前服务器时间为：" + datetime.ToString(), "信息提示");
            }
            finally {
                button_Test.Enabled = true;
            }
        }

        private void btn_PricePush_Click(object sender, EventArgs e)
        {
            rs.syncPrice.pushPrice.Pause = !rs.syncPrice.pushPrice.Pause;
            btn_PricePush.Text = rs.syncPrice.pushPrice.Pause ? "启动":"暂停";
            lb_PnextTime.Text = rs.syncPrice.pushPrice.Pause ? "已暂停":"正在启动";
            Logger.WritingLog(rs.syncPrice.pushPrice.Pause==true?"价格推送已暂停":"价格推送已启动");
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown loc_nud = (NumericUpDown)sender;
            if (loc_nud != null)
                if (loc_nud == nud_Pspan)
                    rs.syncPrice.pushPrice.timeSpan = (int)nud_Pspan.Value * 1000;
                else if (loc_nud == nud_Pcount)
                    rs.syncPrice.pushPrice.selCondition.Dcount = (int)nud_Pcount.Value;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rs.syncPrice.pushPrice.Pause != true&&!PricePush.g_IsPricePushFinish)
                if (MessageBox.Show("单价推送接口正在运行,确定关闭程序吗？", "提示") == DialogResult.OK)
                {
                    btn_PricePush.PerformClick();
                    rs.syncPrice.bol_closingWnd = true;
                    if (!PricePush.g_IsPricePushFinish)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            Logger.WritingLog("截取全部日志结束.");
            StringBuilder sb = new StringBuilder();
            sb.Append("程序成功关闭:\r\n")
                .Append("   尝试推送总次数:").Append(lb_PtryTimes.Text).Append("\r\n")
                .Append("     推送成功次数:").Append(lb_PsucTimes.Text).Append("\r\n")
                .Append("     推送失败次数:").Append(lb_PfailTimes.Text).Append("\r\n")
                .Append("       总推送条数:").Append(lb_PallDetials.Text).Append("\r\n")
                .Append("     推送失败条数:").Append(lb_PfailDetials.Text).Append("\r\n")
                .Append("     推送成功条数:").Append(lb_PsucDetials.Text).Append("\r\n");
                ;
            Logger.WritingLog(sb.ToString());

        }

        private void btn_writeLog_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            StringBuilder sb = new StringBuilder();
            rs.syncPrice.bol_allLog = !rs.syncPrice.bol_allLog;
            if (rs.syncPrice.bol_allLog)
            {
                sb.Append("开始截取全部日志:\r\n");
                btn_writeLog.Text = "停止截取";
            }
            else {
                btn_writeLog.Text = "开始截取日志";
                sb.Append("截取全部日志结束.\r\n");
            }
            btn.Enabled = true;
            Logger.WritingLog(sb.ToString());
        }
    }
}
