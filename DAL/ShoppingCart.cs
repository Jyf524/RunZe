/**  版本信息模板在安装目录下，可自行修改。
* ShoppingCart.cs
*
* 功 能： N/A
* 类 名： ShoppingCart
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/1/14 11:42:21   N/A    初版
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
	/// 数据访问类:ShoppingCart
	/// </summary>
	public partial class ShoppingCart
	{
		public ShoppingCart()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ShoppingCartID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ShoppingCart");
			strSql.Append(" where ShoppingCartID='"+ShoppingCartID+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.ShoppingCart model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ShoppingCartID != null)
			{
				strSql1.Append("ShoppingCartID,");
				strSql2.Append("'"+model.ShoppingCartID+"',");
			}
			if (model.UserID != null)
			{
				strSql1.Append("UserID,");
				strSql2.Append("'"+model.UserID+"',");
			}
			if (model.CommodityID != null)
			{
				strSql1.Append("CommodityID,");
				strSql2.Append("'"+model.CommodityID+"',");
			}
			if (model.OrderNumber != null)
			{
				strSql1.Append("OrderNumber,");
				strSql2.Append(""+model.OrderNumber+",");
			}
			if (model.Subtotal != null)
			{
				strSql1.Append("Subtotal,");
				strSql2.Append("'"+model.Subtotal+"',");
			}
			strSql.Append("insert into ShoppingCart(");
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
		public bool Update(Maticsoft.Model.ShoppingCart model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ShoppingCart set ");
			if (model.UserID != null)
			{
				strSql.Append("UserID='"+model.UserID+"',");
			}
			else
			{
				strSql.Append("UserID= null ,");
			}
			if (model.CommodityID != null)
			{
				strSql.Append("CommodityID='"+model.CommodityID+"',");
			}
			else
			{
				strSql.Append("CommodityID= null ,");
			}
			if (model.OrderNumber != null)
			{
				strSql.Append("OrderNumber="+model.OrderNumber+",");
			}
			else
			{
				strSql.Append("OrderNumber= null ,");
			}
			if (model.Subtotal != null)
			{
				strSql.Append("Subtotal='"+model.Subtotal+"',");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where ShoppingCartID='"+ model.ShoppingCartID+"' ");
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
		public bool Delete(string ShoppingCartID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ShoppingCart ");
			strSql.Append(" where ShoppingCartID='"+ShoppingCartID+"' " );
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
		public bool DeleteList(string ShoppingCartIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ShoppingCart ");
			strSql.Append(" where ShoppingCartID in ("+ShoppingCartIDlist + ")  ");
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
		public Maticsoft.Model.ShoppingCart GetModel(string ShoppingCartID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" ShoppingCartID,UserID,CommodityID,OrderNumber,Subtotal ");
			strSql.Append(" from ShoppingCart ");
			strSql.Append(" where ShoppingCartID='"+ShoppingCartID+"' " );
			Maticsoft.Model.ShoppingCart model=new Maticsoft.Model.ShoppingCart();
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
		public Maticsoft.Model.ShoppingCart DataRowToModel(DataRow row)
		{
			Maticsoft.Model.ShoppingCart model=new Maticsoft.Model.ShoppingCart();
			if (row != null)
			{
				if(row["ShoppingCartID"]!=null)
				{
					model.ShoppingCartID=row["ShoppingCartID"].ToString();
				}
				if(row["UserID"]!=null)
				{
					model.UserID=row["UserID"].ToString();
				}
				if(row["CommodityID"]!=null)
				{
					model.CommodityID=row["CommodityID"].ToString();
				}
				if(row["OrderNumber"]!=null && row["OrderNumber"].ToString()!="")
				{
					model.OrderNumber=int.Parse(row["OrderNumber"].ToString());
				}
				if(row["Subtotal"]!=null)
				{
					model.Subtotal=row["Subtotal"].ToString();
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
			strSql.Append("select ShoppingCartID,UserID,CommodityID,OrderNumber,Subtotal ");
			strSql.Append(" FROM ShoppingCart ");
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
			strSql.Append(" ShoppingCartID,UserID,CommodityID,OrderNumber,Subtotal ");
			strSql.Append(" FROM ShoppingCart ");
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
			strSql.Append("select count(1) FROM ShoppingCart ");
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
				strSql.Append("order by T.ShoppingCartID desc");
			}
			strSql.Append(")AS Row, T.*  from ShoppingCart T ");
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

