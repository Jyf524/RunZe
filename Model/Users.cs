﻿/**  版本信息模板在安装目录下，可自行修改。
* Users.cs
*
* 功 能： N/A
* 类 名： Users
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/1/14 11:42:22   N/A    初版
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
	/// Users:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Users
	{
		public Users()
		{}
		#region Model
		private string _userid;
		private string _username;
		private string _userpassword;
		private string _userrealname;
		private string _usersex;
		private string _useremail;
		private string _usergrade;
		private int? _userscore;
		private string _province;
		private string _city;
		private string _address1;
		private string _useridentity;
		private DateTime? _registtime;
		private string _phone;
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
		public string Username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserPassword
		{
			set{ _userpassword=value;}
			get{return _userpassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserRealName
		{
			set{ _userrealname=value;}
			get{return _userrealname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserSex
		{
			set{ _usersex=value;}
			get{return _usersex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserEmail
		{
			set{ _useremail=value;}
			get{return _useremail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserGrade
		{
			set{ _usergrade=value;}
			get{return _usergrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserScore
		{
			set{ _userscore=value;}
			get{return _userscore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string City
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address1
		{
			set{ _address1=value;}
			get{return _address1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserIdentity
		{
			set{ _useridentity=value;}
			get{return _useridentity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RegistTime
		{
			set{ _registtime=value;}
			get{return _registtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		#endregion Model

	}
}

