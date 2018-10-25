
using System;
namespace wms_transmitter.Domain
{
	/// <summary>
	/// 出库任务单汇总
	/// </summary>
	[Serializable]
	public partial class OUT_SALE_TASK_M
	{
		#region Model
		private string _djbh;
		private string _dwid;
		private string _zcqqsh;
		private string _zcqzzh;
		private string _kplb="0";
		private string _djbh_sj;
		private string _sf_zx="否";
		private string _sf_lstd="否";
		private string _fhtbh="000";
		private string _ry_kpy;
		private string _ry_fuhy;
		private string _sf_dyfhd="否";
		private string _sf_ps="是";
		private string _jhsx;
		private string _zsbz="0";
		private string _sf_zy="0";
		private string _cxbz="0";
		private decimal _sl_pxs=0 ;
		private string _djzt="0";
		private DateTime? _rq;
		private decimal _yxj=0 ;
		private string _zylb="0";
		private string _bch="0";
		private string _sf_dyzjbq="是";
		private string _dwid_ej;
		private string _sf_ffcp="否";
		private string _zcqzjh;
		private string _sf_zjhd="是";
		private string _sf_lhhd="是";
		private string _sf_zshyhd="是";
		private string _ddlx;
		private string _sf_clddd="否";
		private string _yzid;
		private string _sf_sd="否";
		private DateTime? _rq_sd;
		private string _ry_sd;
		private string _ry_js;
		private DateTime? _rq_js;
		private string _sf_th="否";
		private string _ry_th;
		private DateTime? _rq_th;
		private string _sdbz;
		/// <summary>
		/// 单据编号
		/// </summary>
		public string DJBH
		{
			set{ _djbh=value;}
			get{return _djbh;}
		}
		/// <summary>
		/// 单位内码
		/// </summary>
		public string DWID
		{
			set{ _dwid=value;}
			get{return _dwid;}
		}
		/// <summary>
		/// 暂存区内码
		/// </summary>
		public string ZCQQSH
		{
			set{ _zcqqsh=value;}
			get{return _zcqqsh;}
		}
		/// <summary>
		/// 暂存区内码
		/// </summary>
		public string ZCQZZH
		{
			set{ _zcqzzh=value;}
			get{return _zcqzzh;}
		}
		/// <summary>
		/// 业务类别
		/// </summary>
		public string KPLB
		{
			set{ _kplb=value;}
			get{return _kplb;}
		}
		/// <summary>
		/// 作业单编号
		/// </summary>
		public string DJBH_SJ
		{
			set{ _djbh_sj=value;}
			get{return _djbh_sj;}
		}
		/// <summary>
		/// 是否执行
		/// </summary>
		public string SF_ZX
		{
			set{ _sf_zx=value;}
			get{return _sf_zx;}
		}
		/// <summary>
		/// 是否绿色通道
		/// </summary>
		public string SF_LSTD
		{
			set{ _sf_lstd=value;}
			get{return _sf_lstd;}
		}
		/// <summary>
		/// 复核台编号
		/// </summary>
		public string FHTBH
		{
			set{ _fhtbh=value;}
			get{return _fhtbh;}
		}
		/// <summary>
		/// 开票员
		/// </summary>
		public string RY_KPY
		{
			set{ _ry_kpy=value;}
			get{return _ry_kpy;}
		}
		/// <summary>
		/// 复核员
		/// </summary>
		public string RY_FUHY
		{
			set{ _ry_fuhy=value;}
			get{return _ry_fuhy;}
		}
		/// <summary>
		/// 是否打印复核单
		/// </summary>
		public string SF_DYFHD
		{
			set{ _sf_dyfhd=value;}
			get{return _sf_dyfhd;}
		}
		/// <summary>
		/// 是否配送
		/// </summary>
		public string SF_PS
		{
			set{ _sf_ps=value;}
			get{return _sf_ps;}
		}
		/// <summary>
		/// 拣货顺序号
		/// </summary>
		public string JHSX
		{
			set{ _jhsx=value;}
			get{return _jhsx;}
		}
		/// <summary>
		/// 整散标志
		/// </summary>
		public string ZSBZ
		{
			set{ _zsbz=value;}
			get{return _zsbz;}
		}
		/// <summary>
		/// 是否中药
		/// </summary>
		public string SF_ZY
		{
			set{ _sf_zy=value;}
			get{return _sf_zy;}
		}
		/// <summary>
		/// 查询标志
		/// </summary>
		public string CXBZ
		{
			set{ _cxbz=value;}
			get{return _cxbz;}
		}
		/// <summary>
		/// 拼箱数
		/// </summary>
		public decimal SL_PXS
		{
			set{ _sl_pxs=value;}
			get{return _sl_pxs;}
		}
		/// <summary>
		/// 单据状态
		/// </summary>
		public string DJZT
		{
			set{ _djzt=value;}
			get{return _djzt;}
		}
		/// <summary>
		/// 日期
		/// </summary>
		public DateTime? RQ
		{
			set{ _rq=value;}
			get{return _rq;}
		}
		/// <summary>
		/// 优先级
		/// </summary>
		public decimal YXJ
		{
			set{ _yxj=value;}
			get{return _yxj;}
		}
		/// <summary>
		/// 作业类别
		/// </summary>
		public string ZYLB
		{
			set{ _zylb=value;}
			get{return _zylb;}
		}
		/// <summary>
		/// 波次号
		/// </summary>
		public string BCH
		{
			set{ _bch=value;}
			get{return _bch;}
		}
		/// <summary>
		/// 是否打印整件标签
		/// </summary>
		public string SF_DYZJBQ
		{
			set{ _sf_dyzjbq=value;}
			get{return _sf_dyzjbq;}
		}
		/// <summary>
		/// 二级单位内码
		/// </summary>
		public string DWID_EJ
		{
			set{ _dwid_ej=value;}
			get{return _dwid_ej;}
		}
		/// <summary>
		/// 是否发放赠品
		/// </summary>
		public string SF_FFCP
		{
			set{ _sf_ffcp=value;}
			get{return _sf_ffcp;}
		}
		/// <summary>
		/// 暂存区内码
		/// </summary>
		public string ZCQZJH
		{
			set{ _zcqzjh=value;}
			get{return _zcqzjh;}
		}
		/// <summary>
		/// 是否整件活动
		/// </summary>
		public string SF_ZJHD
		{
			set{ _sf_zjhd=value;}
			get{return _sf_zjhd;}
		}
		/// <summary>
		/// 是否零货活动
		/// </summary>
		public string SF_LHHD
		{
			set{ _sf_lhhd=value;}
			get{return _sf_lhhd;}
		}
		/// <summary>
		/// 是否整散合一活动
		/// </summary>
		public string SF_ZSHYHD
		{
			set{ _sf_zshyhd=value;}
			get{return _sf_zshyhd;}
		}
		/// <summary>
		/// 订单类型(A小订单，B中订单，C大订单)
		/// </summary>
		public string DDLX
		{
			set{ _ddlx=value;}
			get{return _ddlx;}
		}
		/// <summary>
		/// 是否拆零大订单
		/// </summary>
		public string SF_CLDDD
		{
			set{ _sf_clddd=value;}
			get{return _sf_clddd;}
		}
		/// <summary>
		/// 业主ID
		/// </summary>
		public string YZID
		{
			set{ _yzid=value;}
			get{return _yzid;}
		}
		/// <summary>
		/// 是否锁定
		/// </summary>
		public string SF_SD
		{
			set{ _sf_sd=value;}
			get{return _sf_sd;}
		}
		/// <summary>
		/// 锁定时间
		/// </summary>
		public DateTime? RQ_SD
		{
			set{ _rq_sd=value;}
			get{return _rq_sd;}
		}
		/// <summary>
		/// 锁定人员
		/// </summary>
		public string RY_SD
		{
			set{ _ry_sd=value;}
			get{return _ry_sd;}
		}
		/// <summary>
		/// 解锁人员
		/// </summary>
		public string RY_JS
		{
			set{ _ry_js=value;}
			get{return _ry_js;}
		}
		/// <summary>
		/// 解锁时间
		/// </summary>
		public DateTime? RQ_JS
		{
			set{ _rq_js=value;}
			get{return _rq_js;}
		}
		/// <summary>
		/// 是否销售退回
		/// </summary>
		public string SF_TH
		{
			set{ _sf_th=value;}
			get{return _sf_th;}
		}
		/// <summary>
		/// 销售退回确认人员
		/// </summary>
		public string RY_TH
		{
			set{ _ry_th=value;}
			get{return _ry_th;}
		}
		/// <summary>
		/// 销售退回时间
		/// </summary>
		public DateTime? RQ_TH
		{
			set{ _rq_th=value;}
			get{return _rq_th;}
		}
		/// <summary>
		/// 锁定备注
		/// </summary>
		public string SDBZ
		{
			set{ _sdbz=value;}
			get{return _sdbz;}
		}
		#endregion Model

	}
}

