namespace wms_transmitter
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Test = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_ReverseRON = new System.Windows.Forms.Label();
            this.lab_ReverseROI = new System.Windows.Forms.Label();
            this.lb_QueryOrderStatusCount = new System.Windows.Forms.Label();
            this.lb_QueryStockCount = new System.Windows.Forms.Label();
            this.lb_OrderCacelReturnCount = new System.Windows.Forms.Label();
            this.lb_OrderReturnCount = new System.Windows.Forms.Label();
            this.lb_OrderEmergencyCount = new System.Windows.Forms.Label();
            this.lb_OrderPauseCount = new System.Windows.Forms.Label();
            this.lb_OrderInterceptCount = new System.Windows.Forms.Label();
            this.lb_OrderSendCount = new System.Windows.Forms.Label();
            this.label_QueryOrderStatusCount = new System.Windows.Forms.Label();
            this.label_QueryStockCount = new System.Windows.Forms.Label();
            this.label_OrderCacelReturnCount = new System.Windows.Forms.Label();
            this.label_OrderReturnCount = new System.Windows.Forms.Label();
            this.label_OrderEmergencyCount = new System.Windows.Forms.Label();
            this.label_OrderPauseCount = new System.Windows.Forms.Label();
            this.label_OrderInterceptCount = new System.Windows.Forms.Label();
            this.label_OrderSendCount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_xstbptCount = new System.Windows.Forms.Label();
            this.lb_xstbpt = new System.Windows.Forms.Label();
            this.lb_OrderOutStoreCount = new System.Windows.Forms.Label();
            this.lb_refundCount = new System.Windows.Forms.Label();
            this.lb_OrderStatusChangeCount = new System.Windows.Forms.Label();
            this.label_OrderOutStoreCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_OrderStatusChangeCount = new System.Windows.Forms.Label();
            this.label_StartTime = new System.Windows.Forms.Label();
            this.label_UpdateTime = new System.Windows.Forms.Label();
            this.lb_StartTime = new System.Windows.Forms.Label();
            this.lb_UpdateTime = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_PricePush = new System.Windows.Forms.Button();
            this.lb_PfailDetials = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_PsucDetials = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_PallDetials = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lb_PnextTime = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nud_Pcount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_Pspan = new System.Windows.Forms.NumericUpDown();
            this.lb_PfailTimes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_PsucTimes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_PtryTimes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_writeLog = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Pcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Pspan)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Test
            // 
            this.button_Test.Location = new System.Drawing.Point(337, 405);
            this.button_Test.Margin = new System.Windows.Forms.Padding(2);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(125, 36);
            this.button_Test.TabIndex = 0;
            this.button_Test.Text = "数据库连接测试";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lab_ReverseRON);
            this.groupBox1.Controls.Add(this.lab_ReverseROI);
            this.groupBox1.Controls.Add(this.lb_QueryOrderStatusCount);
            this.groupBox1.Controls.Add(this.lb_QueryStockCount);
            this.groupBox1.Controls.Add(this.lb_OrderCacelReturnCount);
            this.groupBox1.Controls.Add(this.lb_OrderReturnCount);
            this.groupBox1.Controls.Add(this.lb_OrderEmergencyCount);
            this.groupBox1.Controls.Add(this.lb_OrderPauseCount);
            this.groupBox1.Controls.Add(this.lb_OrderInterceptCount);
            this.groupBox1.Controls.Add(this.lb_OrderSendCount);
            this.groupBox1.Controls.Add(this.label_QueryOrderStatusCount);
            this.groupBox1.Controls.Add(this.label_QueryStockCount);
            this.groupBox1.Controls.Add(this.label_OrderCacelReturnCount);
            this.groupBox1.Controls.Add(this.label_OrderReturnCount);
            this.groupBox1.Controls.Add(this.label_OrderEmergencyCount);
            this.groupBox1.Controls.Add(this.label_OrderPauseCount);
            this.groupBox1.Controls.Add(this.label_OrderInterceptCount);
            this.groupBox1.Controls.Add(this.label_OrderSendCount);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(22, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(440, 170);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "管易>WMS";
            // 
            // lab_ReverseRON
            // 
            this.lab_ReverseRON.AutoSize = true;
            this.lab_ReverseRON.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_ReverseRON.ForeColor = System.Drawing.Color.Red;
            this.lab_ReverseRON.Location = new System.Drawing.Point(368, 57);
            this.lab_ReverseRON.Name = "lab_ReverseRON";
            this.lab_ReverseRON.Size = new System.Drawing.Size(33, 12);
            this.lab_ReverseRON.TabIndex = 22;
            this.lab_ReverseRON.Text = "9999";
            // 
            // lab_ReverseROI
            // 
            this.lab_ReverseROI.AutoSize = true;
            this.lab_ReverseROI.Location = new System.Drawing.Point(296, 57);
            this.lab_ReverseROI.Name = "lab_ReverseROI";
            this.lab_ReverseROI.Size = new System.Drawing.Size(65, 12);
            this.lab_ReverseROI.TabIndex = 21;
            this.lab_ReverseROI.Text = "反审退货：";
            // 
            // lb_QueryOrderStatusCount
            // 
            this.lb_QueryOrderStatusCount.AutoSize = true;
            this.lb_QueryOrderStatusCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_QueryOrderStatusCount.ForeColor = System.Drawing.Color.Red;
            this.lb_QueryOrderStatusCount.Location = new System.Drawing.Point(368, 136);
            this.lb_QueryOrderStatusCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_QueryOrderStatusCount.Name = "lb_QueryOrderStatusCount";
            this.lb_QueryOrderStatusCount.Size = new System.Drawing.Size(33, 12);
            this.lb_QueryOrderStatusCount.TabIndex = 20;
            this.lb_QueryOrderStatusCount.Tag = "0";
            this.lb_QueryOrderStatusCount.Text = "9999";
            // 
            // lb_QueryStockCount
            // 
            this.lb_QueryStockCount.AutoSize = true;
            this.lb_QueryStockCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_QueryStockCount.ForeColor = System.Drawing.Color.Red;
            this.lb_QueryStockCount.Location = new System.Drawing.Point(368, 109);
            this.lb_QueryStockCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_QueryStockCount.Name = "lb_QueryStockCount";
            this.lb_QueryStockCount.Size = new System.Drawing.Size(33, 12);
            this.lb_QueryStockCount.TabIndex = 19;
            this.lb_QueryStockCount.Tag = "0";
            this.lb_QueryStockCount.Text = "9999";
            // 
            // lb_OrderCacelReturnCount
            // 
            this.lb_OrderCacelReturnCount.AutoSize = true;
            this.lb_OrderCacelReturnCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_OrderCacelReturnCount.ForeColor = System.Drawing.Color.Red;
            this.lb_OrderCacelReturnCount.Location = new System.Drawing.Point(368, 83);
            this.lb_OrderCacelReturnCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_OrderCacelReturnCount.Name = "lb_OrderCacelReturnCount";
            this.lb_OrderCacelReturnCount.Size = new System.Drawing.Size(33, 12);
            this.lb_OrderCacelReturnCount.TabIndex = 18;
            this.lb_OrderCacelReturnCount.Tag = "0";
            this.lb_OrderCacelReturnCount.Text = "9999";
            // 
            // lb_OrderReturnCount
            // 
            this.lb_OrderReturnCount.AutoSize = true;
            this.lb_OrderReturnCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_OrderReturnCount.ForeColor = System.Drawing.Color.Red;
            this.lb_OrderReturnCount.Location = new System.Drawing.Point(368, 31);
            this.lb_OrderReturnCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_OrderReturnCount.Name = "lb_OrderReturnCount";
            this.lb_OrderReturnCount.Size = new System.Drawing.Size(33, 12);
            this.lb_OrderReturnCount.TabIndex = 17;
            this.lb_OrderReturnCount.Tag = "0";
            this.lb_OrderReturnCount.Text = "9999";
            // 
            // lb_OrderEmergencyCount
            // 
            this.lb_OrderEmergencyCount.AutoSize = true;
            this.lb_OrderEmergencyCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_OrderEmergencyCount.ForeColor = System.Drawing.Color.Red;
            this.lb_OrderEmergencyCount.Location = new System.Drawing.Point(114, 137);
            this.lb_OrderEmergencyCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_OrderEmergencyCount.Name = "lb_OrderEmergencyCount";
            this.lb_OrderEmergencyCount.Size = new System.Drawing.Size(33, 12);
            this.lb_OrderEmergencyCount.TabIndex = 16;
            this.lb_OrderEmergencyCount.Tag = "0";
            this.lb_OrderEmergencyCount.Text = "9999";
            // 
            // lb_OrderPauseCount
            // 
            this.lb_OrderPauseCount.AutoSize = true;
            this.lb_OrderPauseCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_OrderPauseCount.ForeColor = System.Drawing.Color.Red;
            this.lb_OrderPauseCount.Location = new System.Drawing.Point(114, 101);
            this.lb_OrderPauseCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_OrderPauseCount.Name = "lb_OrderPauseCount";
            this.lb_OrderPauseCount.Size = new System.Drawing.Size(33, 12);
            this.lb_OrderPauseCount.TabIndex = 15;
            this.lb_OrderPauseCount.Tag = "0";
            this.lb_OrderPauseCount.Text = "9999";
            // 
            // lb_OrderInterceptCount
            // 
            this.lb_OrderInterceptCount.AutoSize = true;
            this.lb_OrderInterceptCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_OrderInterceptCount.ForeColor = System.Drawing.Color.Red;
            this.lb_OrderInterceptCount.Location = new System.Drawing.Point(114, 63);
            this.lb_OrderInterceptCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_OrderInterceptCount.Name = "lb_OrderInterceptCount";
            this.lb_OrderInterceptCount.Size = new System.Drawing.Size(33, 12);
            this.lb_OrderInterceptCount.TabIndex = 14;
            this.lb_OrderInterceptCount.Tag = "0";
            this.lb_OrderInterceptCount.Text = "9999";
            // 
            // lb_OrderSendCount
            // 
            this.lb_OrderSendCount.AutoSize = true;
            this.lb_OrderSendCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_OrderSendCount.ForeColor = System.Drawing.Color.Red;
            this.lb_OrderSendCount.Location = new System.Drawing.Point(114, 30);
            this.lb_OrderSendCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_OrderSendCount.Name = "lb_OrderSendCount";
            this.lb_OrderSendCount.Size = new System.Drawing.Size(33, 12);
            this.lb_OrderSendCount.TabIndex = 13;
            this.lb_OrderSendCount.Tag = "0";
            this.lb_OrderSendCount.Text = "9999";
            // 
            // label_QueryOrderStatusCount
            // 
            this.label_QueryOrderStatusCount.AutoSize = true;
            this.label_QueryOrderStatusCount.Location = new System.Drawing.Point(272, 136);
            this.label_QueryOrderStatusCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_QueryOrderStatusCount.Name = "label_QueryOrderStatusCount";
            this.label_QueryOrderStatusCount.Size = new System.Drawing.Size(89, 12);
            this.label_QueryOrderStatusCount.TabIndex = 12;
            this.label_QueryOrderStatusCount.Text = "订单状态查询：";
            // 
            // label_QueryStockCount
            // 
            this.label_QueryStockCount.AutoSize = true;
            this.label_QueryStockCount.Location = new System.Drawing.Point(296, 109);
            this.label_QueryStockCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_QueryStockCount.Name = "label_QueryStockCount";
            this.label_QueryStockCount.Size = new System.Drawing.Size(65, 12);
            this.label_QueryStockCount.TabIndex = 11;
            this.label_QueryStockCount.Text = "库存查询：";
            // 
            // label_OrderCacelReturnCount
            // 
            this.label_OrderCacelReturnCount.AutoSize = true;
            this.label_OrderCacelReturnCount.Location = new System.Drawing.Point(296, 83);
            this.label_OrderCacelReturnCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OrderCacelReturnCount.Name = "label_OrderCacelReturnCount";
            this.label_OrderCacelReturnCount.Size = new System.Drawing.Size(65, 12);
            this.label_OrderCacelReturnCount.TabIndex = 10;
            this.label_OrderCacelReturnCount.Text = "取消退货：";
            // 
            // label_OrderReturnCount
            // 
            this.label_OrderReturnCount.AutoSize = true;
            this.label_OrderReturnCount.Location = new System.Drawing.Point(308, 30);
            this.label_OrderReturnCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OrderReturnCount.Name = "label_OrderReturnCount";
            this.label_OrderReturnCount.Size = new System.Drawing.Size(53, 12);
            this.label_OrderReturnCount.TabIndex = 9;
            this.label_OrderReturnCount.Text = "退货单：";
            // 
            // label_OrderEmergencyCount
            // 
            this.label_OrderEmergencyCount.AutoSize = true;
            this.label_OrderEmergencyCount.Location = new System.Drawing.Point(48, 137);
            this.label_OrderEmergencyCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OrderEmergencyCount.Name = "label_OrderEmergencyCount";
            this.label_OrderEmergencyCount.Size = new System.Drawing.Size(65, 12);
            this.label_OrderEmergencyCount.TabIndex = 8;
            this.label_OrderEmergencyCount.Text = "订单加急：";
            // 
            // label_OrderPauseCount
            // 
            this.label_OrderPauseCount.AutoSize = true;
            this.label_OrderPauseCount.Location = new System.Drawing.Point(48, 101);
            this.label_OrderPauseCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OrderPauseCount.Name = "label_OrderPauseCount";
            this.label_OrderPauseCount.Size = new System.Drawing.Size(65, 12);
            this.label_OrderPauseCount.TabIndex = 7;
            this.label_OrderPauseCount.Text = "暂停订单：";
            // 
            // label_OrderInterceptCount
            // 
            this.label_OrderInterceptCount.AutoSize = true;
            this.label_OrderInterceptCount.Location = new System.Drawing.Point(48, 63);
            this.label_OrderInterceptCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OrderInterceptCount.Name = "label_OrderInterceptCount";
            this.label_OrderInterceptCount.Size = new System.Drawing.Size(65, 12);
            this.label_OrderInterceptCount.TabIndex = 6;
            this.label_OrderInterceptCount.Text = "拦截订单：";
            // 
            // label_OrderSendCount
            // 
            this.label_OrderSendCount.AutoSize = true;
            this.label_OrderSendCount.Location = new System.Drawing.Point(48, 30);
            this.label_OrderSendCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OrderSendCount.Name = "label_OrderSendCount";
            this.label_OrderSendCount.Size = new System.Drawing.Size(65, 12);
            this.label_OrderSendCount.TabIndex = 5;
            this.label_OrderSendCount.Text = "发送订单：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_xstbptCount);
            this.groupBox2.Controls.Add(this.lb_xstbpt);
            this.groupBox2.Controls.Add(this.lb_OrderOutStoreCount);
            this.groupBox2.Controls.Add(this.lb_refundCount);
            this.groupBox2.Controls.Add(this.lb_OrderStatusChangeCount);
            this.groupBox2.Controls.Add(this.label_OrderOutStoreCount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label_OrderStatusChangeCount);
            this.groupBox2.Location = new System.Drawing.Point(22, 195);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(440, 80);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WMS>管易";
            // 
            // lb_xstbptCount
            // 
            this.lb_xstbptCount.AutoSize = true;
            this.lb_xstbptCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_xstbptCount.ForeColor = System.Drawing.Color.Red;
            this.lb_xstbptCount.Location = new System.Drawing.Point(368, 56);
            this.lb_xstbptCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_xstbptCount.Name = "lb_xstbptCount";
            this.lb_xstbptCount.Size = new System.Drawing.Size(33, 12);
            this.lb_xstbptCount.TabIndex = 24;
            this.lb_xstbptCount.Tag = "0";
            this.lb_xstbptCount.Text = "9999";
            // 
            // lb_xstbpt
            // 
            this.lb_xstbpt.AutoSize = true;
            this.lb_xstbpt.Location = new System.Drawing.Point(253, 55);
            this.lb_xstbpt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_xstbpt.Name = "lb_xstbpt";
            this.lb_xstbpt.Size = new System.Drawing.Size(113, 12);
            this.lb_xstbpt.TabIndex = 23;
            this.lb_xstbpt.Text = "销售出库同步平台：";
            // 
            // lb_OrderOutStoreCount
            // 
            this.lb_OrderOutStoreCount.AutoSize = true;
            this.lb_OrderOutStoreCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_OrderOutStoreCount.ForeColor = System.Drawing.Color.Red;
            this.lb_OrderOutStoreCount.Location = new System.Drawing.Point(368, 33);
            this.lb_OrderOutStoreCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_OrderOutStoreCount.Name = "lb_OrderOutStoreCount";
            this.lb_OrderOutStoreCount.Size = new System.Drawing.Size(33, 12);
            this.lb_OrderOutStoreCount.TabIndex = 22;
            this.lb_OrderOutStoreCount.Tag = "0";
            this.lb_OrderOutStoreCount.Text = "9999";
            // 
            // lb_refundCount
            // 
            this.lb_refundCount.AutoSize = true;
            this.lb_refundCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_refundCount.ForeColor = System.Drawing.Color.Red;
            this.lb_refundCount.Location = new System.Drawing.Point(115, 58);
            this.lb_refundCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_refundCount.Name = "lb_refundCount";
            this.lb_refundCount.Size = new System.Drawing.Size(33, 12);
            this.lb_refundCount.TabIndex = 21;
            this.lb_refundCount.Tag = "0";
            this.lb_refundCount.Text = "9999";
            // 
            // lb_OrderStatusChangeCount
            // 
            this.lb_OrderStatusChangeCount.AutoSize = true;
            this.lb_OrderStatusChangeCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_OrderStatusChangeCount.ForeColor = System.Drawing.Color.Red;
            this.lb_OrderStatusChangeCount.Location = new System.Drawing.Point(115, 33);
            this.lb_OrderStatusChangeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_OrderStatusChangeCount.Name = "lb_OrderStatusChangeCount";
            this.lb_OrderStatusChangeCount.Size = new System.Drawing.Size(33, 12);
            this.lb_OrderStatusChangeCount.TabIndex = 21;
            this.lb_OrderStatusChangeCount.Tag = "0";
            this.lb_OrderStatusChangeCount.Text = "9999";
            // 
            // label_OrderOutStoreCount
            // 
            this.label_OrderOutStoreCount.AutoSize = true;
            this.label_OrderOutStoreCount.Location = new System.Drawing.Point(289, 33);
            this.label_OrderOutStoreCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OrderOutStoreCount.Name = "label_OrderOutStoreCount";
            this.label_OrderOutStoreCount.Size = new System.Drawing.Size(77, 12);
            this.label_OrderOutStoreCount.TabIndex = 11;
            this.label_OrderOutStoreCount.Text = "出库单同步：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "销售退回：";
            // 
            // label_OrderStatusChangeCount
            // 
            this.label_OrderStatusChangeCount.AutoSize = true;
            this.label_OrderStatusChangeCount.Location = new System.Drawing.Point(27, 33);
            this.label_OrderStatusChangeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OrderStatusChangeCount.Name = "label_OrderStatusChangeCount";
            this.label_OrderStatusChangeCount.Size = new System.Drawing.Size(89, 12);
            this.label_OrderStatusChangeCount.TabIndex = 10;
            this.label_OrderStatusChangeCount.Text = "订单状态更改：";
            // 
            // label_StartTime
            // 
            this.label_StartTime.AutoSize = true;
            this.label_StartTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_StartTime.ForeColor = System.Drawing.Color.Navy;
            this.label_StartTime.Location = new System.Drawing.Point(42, 405);
            this.label_StartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StartTime.Name = "label_StartTime";
            this.label_StartTime.Size = new System.Drawing.Size(70, 12);
            this.label_StartTime.TabIndex = 13;
            this.label_StartTime.Text = "启动时间：";
            // 
            // label_UpdateTime
            // 
            this.label_UpdateTime.AutoSize = true;
            this.label_UpdateTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_UpdateTime.ForeColor = System.Drawing.Color.Navy;
            this.label_UpdateTime.Location = new System.Drawing.Point(20, 429);
            this.label_UpdateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UpdateTime.Name = "label_UpdateTime";
            this.label_UpdateTime.Size = new System.Drawing.Size(96, 12);
            this.label_UpdateTime.TabIndex = 14;
            this.label_UpdateTime.Text = "最后更新时间：";
            // 
            // lb_StartTime
            // 
            this.lb_StartTime.AutoSize = true;
            this.lb_StartTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_StartTime.ForeColor = System.Drawing.Color.ForestGreen;
            this.lb_StartTime.Location = new System.Drawing.Point(113, 405);
            this.lb_StartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_StartTime.Name = "lb_StartTime";
            this.lb_StartTime.Size = new System.Drawing.Size(117, 12);
            this.lb_StartTime.TabIndex = 15;
            this.lb_StartTime.Text = "2015-08-17 20:11";
            // 
            // lb_UpdateTime
            // 
            this.lb_UpdateTime.AutoSize = true;
            this.lb_UpdateTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_UpdateTime.ForeColor = System.Drawing.Color.ForestGreen;
            this.lb_UpdateTime.Location = new System.Drawing.Point(113, 429);
            this.lb_UpdateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_UpdateTime.Name = "lb_UpdateTime";
            this.lb_UpdateTime.Size = new System.Drawing.Size(117, 12);
            this.lb_UpdateTime.TabIndex = 16;
            this.lb_UpdateTime.Text = "2015-08-17 22:00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_writeLog);
            this.groupBox3.Controls.Add(this.btn_PricePush);
            this.groupBox3.Controls.Add(this.lb_PfailDetials);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lb_PsucDetials);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lb_PallDetials);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.lb_PnextTime);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.nud_Pcount);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.nud_Pspan);
            this.groupBox3.Controls.Add(this.lb_PfailTimes);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lb_PsucTimes);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lb_PtryTimes);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(22, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 119);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "单价推送";
            // 
            // btn_PricePush
            // 
            this.btn_PricePush.Location = new System.Drawing.Point(359, 55);
            this.btn_PricePush.Name = "btn_PricePush";
            this.btn_PricePush.Size = new System.Drawing.Size(75, 23);
            this.btn_PricePush.TabIndex = 45;
            this.btn_PricePush.Text = "启动";
            this.btn_PricePush.UseVisualStyleBackColor = true;
            this.btn_PricePush.Click += new System.EventHandler(this.btn_PricePush_Click);
            // 
            // lb_PfailDetials
            // 
            this.lb_PfailDetials.AutoSize = true;
            this.lb_PfailDetials.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_PfailDetials.ForeColor = System.Drawing.Color.Red;
            this.lb_PfailDetials.Location = new System.Drawing.Point(313, 60);
            this.lb_PfailDetials.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PfailDetials.Name = "lb_PfailDetials";
            this.lb_PfailDetials.Size = new System.Drawing.Size(33, 12);
            this.lb_PfailDetials.TabIndex = 44;
            this.lb_PfailDetials.Tag = "0";
            this.lb_PfailDetials.Text = "9999";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(237, 60);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 43;
            this.label15.Text = "失败计数：";
            // 
            // lb_PsucDetials
            // 
            this.lb_PsucDetials.AutoSize = true;
            this.lb_PsucDetials.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_PsucDetials.ForeColor = System.Drawing.Color.Red;
            this.lb_PsucDetials.Location = new System.Drawing.Point(200, 60);
            this.lb_PsucDetials.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PsucDetials.Name = "lb_PsucDetials";
            this.lb_PsucDetials.Size = new System.Drawing.Size(33, 12);
            this.lb_PsucDetials.TabIndex = 42;
            this.lb_PsucDetials.Tag = "0";
            this.lb_PsucDetials.Text = "9999";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(127, 60);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 41;
            this.label17.Text = "成功计数：";
            // 
            // lb_PallDetials
            // 
            this.lb_PallDetials.AutoSize = true;
            this.lb_PallDetials.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_PallDetials.ForeColor = System.Drawing.Color.Red;
            this.lb_PallDetials.Location = new System.Drawing.Point(90, 60);
            this.lb_PallDetials.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PallDetials.Name = "lb_PallDetials";
            this.lb_PallDetials.Size = new System.Drawing.Size(33, 12);
            this.lb_PallDetials.TabIndex = 40;
            this.lb_PallDetials.Tag = "0";
            this.lb_PallDetials.Text = "9999";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 60);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 39;
            this.label19.Text = "总推送条数：";
            // 
            // lb_PnextTime
            // 
            this.lb_PnextTime.AutoSize = true;
            this.lb_PnextTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_PnextTime.ForeColor = System.Drawing.Color.Red;
            this.lb_PnextTime.Location = new System.Drawing.Point(299, 94);
            this.lb_PnextTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PnextTime.Name = "lb_PnextTime";
            this.lb_PnextTime.Size = new System.Drawing.Size(33, 12);
            this.lb_PnextTime.TabIndex = 38;
            this.lb_PnextTime.Tag = "0";
            this.lb_PnextTime.Text = "----";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(215, 94);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 12);
            this.label13.TabIndex = 37;
            this.label13.Text = "下次推送时间：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "条/次";
            // 
            // nud_Pcount
            // 
            this.nud_Pcount.Location = new System.Drawing.Point(134, 92);
            this.nud_Pcount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Pcount.Name = "nud_Pcount";
            this.nud_Pcount.Size = new System.Drawing.Size(39, 21);
            this.nud_Pcount.TabIndex = 34;
            this.nud_Pcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Pcount.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 33;
            this.label9.Text = "秒";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "推送间隔：";
            // 
            // nud_Pspan
            // 
            this.nud_Pspan.Location = new System.Drawing.Point(72, 92);
            this.nud_Pspan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Pspan.Name = "nud_Pspan";
            this.nud_Pspan.Size = new System.Drawing.Size(38, 21);
            this.nud_Pspan.TabIndex = 31;
            this.nud_Pspan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Pspan.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // lb_PfailTimes
            // 
            this.lb_PfailTimes.AutoSize = true;
            this.lb_PfailTimes.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_PfailTimes.ForeColor = System.Drawing.Color.Red;
            this.lb_PfailTimes.Location = new System.Drawing.Point(313, 33);
            this.lb_PfailTimes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PfailTimes.Name = "lb_PfailTimes";
            this.lb_PfailTimes.Size = new System.Drawing.Size(33, 12);
            this.lb_PfailTimes.TabIndex = 30;
            this.lb_PfailTimes.Tag = "0";
            this.lb_PfailTimes.Text = "9999";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "失败计数：";
            // 
            // lb_PsucTimes
            // 
            this.lb_PsucTimes.AutoSize = true;
            this.lb_PsucTimes.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_PsucTimes.ForeColor = System.Drawing.Color.Red;
            this.lb_PsucTimes.Location = new System.Drawing.Point(200, 33);
            this.lb_PsucTimes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PsucTimes.Name = "lb_PsucTimes";
            this.lb_PsucTimes.Size = new System.Drawing.Size(33, 12);
            this.lb_PsucTimes.TabIndex = 28;
            this.lb_PsucTimes.Tag = "0";
            this.lb_PsucTimes.Text = "9999";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "成功计数：";
            // 
            // lb_PtryTimes
            // 
            this.lb_PtryTimes.AutoSize = true;
            this.lb_PtryTimes.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_PtryTimes.ForeColor = System.Drawing.Color.Red;
            this.lb_PtryTimes.Location = new System.Drawing.Point(90, 33);
            this.lb_PtryTimes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PtryTimes.Name = "lb_PtryTimes";
            this.lb_PtryTimes.Size = new System.Drawing.Size(33, 12);
            this.lb_PtryTimes.TabIndex = 26;
            this.lb_PtryTimes.Tag = "0";
            this.lb_PtryTimes.Text = "9999";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "总尝试次数：";
            // 
            // btn_writeLog
            // 
            this.btn_writeLog.Location = new System.Drawing.Point(359, 26);
            this.btn_writeLog.Name = "btn_writeLog";
            this.btn_writeLog.Size = new System.Drawing.Size(75, 23);
            this.btn_writeLog.TabIndex = 46;
            this.btn_writeLog.Text = "记录日志";
            this.btn_writeLog.UseVisualStyleBackColor = true;
            this.btn_writeLog.Click += new System.EventHandler(this.btn_writeLog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 454);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lb_UpdateTime);
            this.Controls.Add(this.lb_StartTime);
            this.Controls.Add(this.label_UpdateTime);
            this.Controls.Add(this.label_StartTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Test);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WMS数据接口系统（状态显示窗口）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Pcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Pspan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_QueryOrderStatusCount;
        private System.Windows.Forms.Label label_QueryStockCount;
        private System.Windows.Forms.Label label_OrderCacelReturnCount;
        private System.Windows.Forms.Label label_OrderReturnCount;
        private System.Windows.Forms.Label label_OrderEmergencyCount;
        private System.Windows.Forms.Label label_OrderPauseCount;
        private System.Windows.Forms.Label label_OrderInterceptCount;
        private System.Windows.Forms.Label label_OrderSendCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_OrderOutStoreCount;
        private System.Windows.Forms.Label label_OrderStatusChangeCount;
        private System.Windows.Forms.Label label_StartTime;
        private System.Windows.Forms.Label label_UpdateTime;
        private System.Windows.Forms.Label lb_StartTime;
        private System.Windows.Forms.Label lb_UpdateTime;
        private System.Windows.Forms.Label lb_QueryOrderStatusCount;
        private System.Windows.Forms.Label lb_QueryStockCount;
        private System.Windows.Forms.Label lb_OrderCacelReturnCount;
        private System.Windows.Forms.Label lb_OrderReturnCount;
        private System.Windows.Forms.Label lb_OrderEmergencyCount;
        private System.Windows.Forms.Label lb_OrderPauseCount;
        private System.Windows.Forms.Label lb_OrderInterceptCount;
        private System.Windows.Forms.Label lb_OrderSendCount;
        private System.Windows.Forms.Label lb_OrderOutStoreCount;
        private System.Windows.Forms.Label lb_OrderStatusChangeCount;
        private System.Windows.Forms.Label lb_refundCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_xstbptCount;
        private System.Windows.Forms.Label lb_xstbpt;
        private System.Windows.Forms.Label lab_ReverseRON;
        private System.Windows.Forms.Label lab_ReverseROI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_PfailDetials;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_PsucDetials;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb_PallDetials;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lb_PnextTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nud_Pcount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_Pspan;
        private System.Windows.Forms.Label lb_PfailTimes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_PsucTimes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_PtryTimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_PricePush;
        private System.Windows.Forms.Button btn_writeLog;
    }
}

