/**  版本信息模板在安装目录下，可自行修改。
* CommoditySon.cs
*
* 功 能： N/A
* 类 名： CommoditySon
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
	/// 数据访问类:CommoditySon
	/// </summary>
	public partial class CommoditySon
	{
		public CommoditySon()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CommoditySonID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CommoditySon");
			strSql.Append(" where CommoditySonID='"+CommoditySonID+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.CommoditySon model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.CommoditySonID != null)
			{
				strSql1.Append("CommoditySonID,");
				strSql2.Append("'"+model.CommoditySonID+"',");
			}
			if (model.CommodityFatherID != null)
			{
				strSql1.Append("CommodityFatherID,");
				strSql2.Append("'"+model.CommodityFatherID+"',");
			}
			if (model.CommoditySonName != null)
			{
				strSql1.Append("CommoditySonName,");
				strSql2.Append("'"+model.CommoditySonName+"',");
			}
			strSql.Append("insert into CommoditySon(");
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
		public bool Update(Maticsoft.Model.CommoditySon model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CommoditySon set ");
			if (model.CommodityFatherID != null)
			{
				strSql.Append("CommodityFatherID='"+model.CommodityFatherID+"',");
			}
			else
			{
				strSql.Append("CommodityFatherID= null ,");
			}
			if (model.CommoditySonName != null)
			{
				strSql.Append("CommoditySonName='"+model.CommoditySonName+"',");
			}
			else
			{
				strSql.Append("CommoditySonName= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where CommoditySonID='"+ model.CommoditySonID+"' ");
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
		public bool Delete(string CommoditySonID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CommoditySon ");
			strSql.Append(" where CommoditySonID='"+CommoditySonID+"' " );
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
		public bool DeleteList(string CommoditySonIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CommoditySon ");
			strSql.Append(" where CommoditySonID in ("+CommoditySonIDlist + ")  ");
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
		public Maticsoft.Model.CommoditySon GetModel(string CommoditySonID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" CommoditySonID,CommodityFatherID,CommoditySonName ");
			strSql.Append(" from CommoditySon ");
			strSql.Append(" where CommoditySonID='"+CommoditySonID+"' " );
			Maticsoft.Model.CommoditySon model=new Maticsoft.Model.CommoditySon();
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
		public Maticsoft.Model.CommoditySon DataRowToModel(DataRow row)
		{
			Maticsoft.Model.CommoditySon model=new Maticsoft.Model.CommoditySon();
			if (row != null)
			{
				if(row["CommoditySonID"]!=null)
				{
					model.CommoditySonID=row["CommoditySonID"].ToString();
				}
				if(row["CommodityFatherID"]!=null)
				{
					model.CommodityFatherID=row["CommodityFatherID"].ToString();
				}
				if(row["CommoditySonName"]!=null)
				{
					model.CommoditySonName=row["CommoditySonName"].ToString();
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
			strSql.Append("select CommoditySonID,CommodityFatherID,CommoditySonName ");
			strSql.Append(" FROM CommoditySon ");
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
			strSql.Append(" CommoditySonID,CommodityFatherID,CommoditySonName ");
			strSql.Append(" FROM CommoditySon ");
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
			strSql.Append("select count(1) FROM CommoditySon ");
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
				strSql.Append("order by T.CommoditySonID desc");
			}
			strSql.Append(")AS Row, T.*  from CommoditySon T ");
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

