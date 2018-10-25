

using System;

namespace wms_transmitter.Domain
{
	/// <summary>
	/// 商品总库存
	/// </summary>
	[Serializable]
    public partial class Stock
	{
		#region Model
        private string _SPBH;

		private string _spid;

		private decimal _sl_kc=0 ;


        /// <summary>
        /// 商品编号
        /// </summary>
        public string SPBH
        {
            set { _SPBH = value; }
            get { return _SPBH; }
        }

		/// <summary>
		/// 商品内码
		/// </summary>
		public string SPID
		{
			set{ _spid=value;}
			get{return _spid;}
		}
	
		/// <summary>
		/// 库存数量
		/// </summary>
		public decimal SL_KC
		{
			set{ _sl_kc=value;}
			get{return _sl_kc;}
		}
		
		
		
	
		#endregion Model

	}
}

