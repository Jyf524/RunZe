﻿/**  版本信息模板在安装目录下，可自行修改。
* CommodityFather.cs
*
* 功 能： N/A
* 类 名： CommodityFather
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/1/14 11:42:20   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:CommodityFather
	/// </summary>
	public partial class CommodityFather
	{
		public CommodityFather()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CommodityFatherID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CommodityFather");
			strSql.Append(" where CommodityFatherID='"+CommodityFatherID+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.CommodityFather model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.CommodityFatherID != null)
			{
				strSql1.Append("CommodityFatherID,");
				strSql2.Append("'"+model.CommodityFatherID+"',");
			}
			if (model.CommodityFatherName != null)
			{
				strSql1.Append("CommodityFatherName,");
				strSql2.Append("'"+model.CommodityFatherName+"',");
			}
			strSql.Append("insert into CommodityFather(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.CommodityFather model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CommodityFather set ");
			if (model.CommodityFatherName != null)
			{
				strSql.Append("CommodityFatherName='"+model.CommodityFatherName+"',");
			}
			else
			{
				strSql.Append("CommodityFatherName= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where CommodityFatherID='"+ model.CommodityFatherID+"' ");
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string CommodityFatherID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CommodityFather ");
			strSql.Append(" where CommodityFatherID='"+CommodityFatherID+"' " );
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string CommodityFatherIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CommodityFather ");
			strSql.Append(" where CommodityFatherID in ("+CommodityFatherIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.CommodityFather GetModel(string CommodityFatherID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" CommodityFatherID,CommodityFatherName ");
			strSql.Append(" from CommodityFather ");
			strSql.Append(" where CommodityFatherID='"+CommodityFatherID+"' " );
			Maticsoft.Model.CommodityFather model=new Maticsoft.Model.CommodityFather();
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.CommodityFather DataRowToModel(DataRow row)
		{
			Maticsoft.Model.CommodityFather model=new Maticsoft.Model.CommodityFather();
			if (row != null)
			{
				if(row["CommodityFatherID"]!=null)
				{
					model.CommodityFatherID=row["CommodityFatherID"].ToString();
				}
				if(row["CommodityFatherName"]!=null)
				{
					model.CommodityFatherName=row["CommodityFatherName"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CommodityFatherID,CommodityFatherName ");
			strSql.Append(" FROM CommodityFather ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" CommodityFatherID,CommodityFatherName ");
			strSql.Append(" FROM CommodityFather ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM CommodityFather ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.CommodityFatherID desc");
			}
			strSql.Append(")AS Row, T.*  from CommodityFather T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

