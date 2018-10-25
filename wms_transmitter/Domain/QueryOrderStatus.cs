
using System;
namespace wms_transmitter.Domain
{
	/// <summary>
	/// 出库任务单汇总
	/// </summary>
	[Serializable]
    public partial class QueryOrderStatus
	{
		#region Model
		private string _djbh;
		private string _djzt="0";
        private string _operator; 
        private string _operation; 
        private string _operateTime;

        /// <summary>
		/// 操作人
		/// </summary>
        public string OPERATOR
        {
            set { _operator = value; }
            get { return _operator; }
        }
        /// <summary>
        /// 操作
        /// </summary>
        public string OPERATION //OPERATION
        {
            set { _operation = value; }
            get { return _operation; }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public string OPERATETIME
        {
            set { _operateTime = value; }
            get { return _operateTime; }
        }


		/// <summary>
		/// 单据编号
		/// </summary>
		public string DJBH 
		{
			set{ _djbh=value;}
			get{return _djbh;}
		}
		
		
	
		
		/// <summary>
		/// 单据状态
		/// </summary>
		public string DJZT
		{
			set{ _djzt=value;}
			get{return _djzt;}
		}
		
		
		
	
		
	
		#endregion Model

	}
}

