/**  版本信息模板在安装目录下，可自行修改。
* Commodity.cs
*
* 功 能： N/A
* 类 名： Commodity
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/1/10 14:40:06   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Commodity:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Commodity
	{
		public Commodity()
		{}
		#region Model
		private string _commodityid;
		private string _commodityfatherid;
		private string _commoditysonid;
		private string _commodityname;
		private string _commodityprice;
		private decimal? _marketprice;
		private decimal? _vipprice;
		private int? _stock;
		private string _buyscore;
		private string _commodityimage;
		private string _commoditytype;
		private int? _commoditysaled;
		private string _introduce;
		private DateTime? _commoditytime;
		private string _recommend;
		private string _commoditystate;
		private string _score;
		private string _scoretimes;
		/// <summary>
		/// 
		/// </summary>
		public string CommodityID
		{
			set{ _commodityid=value;}
			get{return _commodityid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CommodityFatherID
		{
			set{ _commodityfatherid=value;}
			get{return _commodityfatherid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CommoditySonID
		{
			set{ _commoditysonid=value;}
			get{return _commoditysonid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CommodityName
		{
			set{ _commodityname=value;}
			get{return _commodityname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CommodityPrice
		{
			set{ _commodityprice=value;}
			get{return _commodityprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MarketPrice
		{
			set{ _marketprice=value;}
			get{return _marketprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? VIPPrice
		{
			set{ _vipprice=value;}
			get{return _vipprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Stock
		{
			set{ _stock=value;}
			get{return _stock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BuyScore
		{
			set{ _buyscore=value;}
			get{return _buyscore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CommodityImage
		{
			set{ _commodityimage=value;}
			get{return _commodityimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CommodityType
		{
			set{ _commoditytype=value;}
			get{return _commoditytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CommoditySaled
		{
			set{ _commoditysaled=value;}
			get{return _commoditysaled;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Introduce
		{
			set{ _introduce=value;}
			get{return _introduce;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CommodityTime
		{
			set{ _commoditytime=value;}
			get{return _commoditytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Recommend
		{
			set{ _recommend=value;}
			get{return _recommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CommodityState
		{
			set{ _commoditystate=value;}
			get{return _commoditystate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Score
		{
			set{ _score=value;}
			get{return _score;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ScoreTimes
		{
			set{ _scoretimes=value;}
			get{return _scoretimes;}
		}
		#endregion Model

	}
}

