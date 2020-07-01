/**  版本信息模板在安装目录下，可自行修改。
* Assn.cs
*
* 功 能： N/A
* 类 名： Assn
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/1/16 11:33:11   N/A    初版
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
	/// Assn:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Assn
	{
		public Assn()
		{}
		#region Model
		private int _assnid;
		private string _socialname;
		private string _socialteacher;
		private string _sociallogo;
		private DateTime? _addtime;
		private string _socialstate;
		private string _socialpurpose;
		private string _socialtype;
		/// <summary>
		/// 
		/// </summary>
		public int AssnID
		{
			set{ _assnid=value;}
			get{return _assnid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SocialName
		{
			set{ _socialname=value;}
			get{return _socialname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SocialTeacher
		{
			set{ _socialteacher=value;}
			get{return _socialteacher;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SocialLogo
		{
			set{ _sociallogo=value;}
			get{return _sociallogo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SocialState
		{
			set{ _socialstate=value;}
			get{return _socialstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SocialPurpose
		{
			set{ _socialpurpose=value;}
			get{return _socialpurpose;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SocialType
		{
			set{ _socialtype=value;}
			get{return _socialtype;}
		}
		#endregion Model

	}
}

