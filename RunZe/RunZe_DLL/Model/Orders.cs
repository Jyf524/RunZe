/**  版本信息模板在安装目录下，可自行修改。
* Orders.cs
*
* 功 能： N/A
* 类 名： Orders
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/1/10 14:40:07   N/A    初版
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
	/// Orders:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Orders
	{
		public Orders()
		{}
		#region Model
		private string _orderid;
		private string _userid;
		private DateTime? _orderdate;
		private string _orderstate;
		private string _commodityid;
		private string _ordernumber;
		private string _addresseename;
		private string _addresseeaddress;
		private string _addresseezipcode;
		private string _addresseephone;
		private decimal? _totalmoney;
		private string _paytype;
		private string _delivery;
		private string _message;
		private string _orderimage;
		private string _commodityname;
		private decimal? _price;
		/// <summary>
		/// 
		/// </summary>
		public string OrderID
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OrderDate
		{
			set{ _orderdate=value;}
			get{return _orderdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderState
		{
			set{ _orderstate=value;}
			get{return _orderstate;}
		}
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
		public string OrderNumber
		{
			set{ _ordernumber=value;}
			get{return _ordernumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AddresseeName
		{
			set{ _addresseename=value;}
			get{return _addresseename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AddresseeAddress
		{
			set{ _addresseeaddress=value;}
			get{return _addresseeaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AddresseeZipCode
		{
			set{ _addresseezipcode=value;}
			get{return _addresseezipcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AddresseePhone
		{
			set{ _addresseephone=value;}
			get{return _addresseephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalMoney
		{
			set{ _totalmoney=value;}
			get{return _totalmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayType
		{
			set{ _paytype=value;}
			get{return _paytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Delivery
		{
			set{ _delivery=value;}
			get{return _delivery;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Message
		{
			set{ _message=value;}
			get{return _message;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderImage
		{
			set{ _orderimage=value;}
			get{return _orderimage;}
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
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		#endregion Model

	}
}

