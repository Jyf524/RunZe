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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Assn
	/// </summary>
	public partial class Assn
	{
		public Assn()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AssnID", "Assn"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AssnID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Assn");
			strSql.Append(" where AssnID="+AssnID+" ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Assn model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.AssnID != null)
			{
				strSql1.Append("AssnID,");
				strSql2.Append(""+model.AssnID+",");
			}
			if (model.SocialName != null)
			{
				strSql1.Append("SocialName,");
				strSql2.Append("'"+model.SocialName+"',");
			}
			if (model.SocialTeacher != null)
			{
				strSql1.Append("SocialTeacher,");
				strSql2.Append("'"+model.SocialTeacher+"',");
			}
			if (model.SocialLogo != null)
			{
				strSql1.Append("SocialLogo,");
				strSql2.Append("'"+model.SocialLogo+"',");
			}
			if (model.AddTime != null)
			{
				strSql1.Append("AddTime,");
				strSql2.Append("'"+model.AddTime+"',");
			}
			if (model.SocialState != null)
			{
				strSql1.Append("SocialState,");
				strSql2.Append("'"+model.SocialState+"',");
			}
			if (model.SocialPurpose != null)
			{
				strSql1.Append("SocialPurpose,");
				strSql2.Append("'"+model.SocialPurpose+"',");
			}
			if (model.SocialType != null)
			{
				strSql1.Append("SocialType,");
				strSql2.Append("'"+model.SocialType+"',");
			}
			strSql.Append("insert into Assn(");
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
		public bool Update(Maticsoft.Model.Assn model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Assn set ");
			if (model.SocialName != null)
			{
				strSql.Append("SocialName='"+model.SocialName+"',");
			}
			else
			{
				strSql.Append("SocialName= null ,");
			}
			if (model.SocialTeacher != null)
			{
				strSql.Append("SocialTeacher='"+model.SocialTeacher+"',");
			}
			else
			{
				strSql.Append("SocialTeacher= null ,");
			}
			if (model.SocialLogo != null)
			{
				strSql.Append("SocialLogo='"+model.SocialLogo+"',");
			}
			else
			{
				strSql.Append("SocialLogo= null ,");
			}
			if (model.AddTime != null)
			{
				strSql.Append("AddTime='"+model.AddTime+"',");
			}
			else
			{
				strSql.Append("AddTime= null ,");
			}
			if (model.SocialState != null)
			{
				strSql.Append("SocialState='"+model.SocialState+"',");
			}
			else
			{
				strSql.Append("SocialState= null ,");
			}
			if (model.SocialPurpose != null)
			{
				strSql.Append("SocialPurpose='"+model.SocialPurpose+"',");
			}
			else
			{
				strSql.Append("SocialPurpose= null ,");
			}
			if (model.SocialType != null)
			{
				strSql.Append("SocialType='"+model.SocialType+"',");
			}
			else
			{
				strSql.Append("SocialType= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where AssnID="+ model.AssnID+" ");
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
		public bool Delete(int AssnID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Assn ");
			strSql.Append(" where AssnID="+AssnID+" " );
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
		public bool DeleteList(string AssnIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Assn ");
			strSql.Append(" where AssnID in ("+AssnIDlist + ")  ");
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
		public Maticsoft.Model.Assn GetModel(int AssnID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" AssnID,SocialName,SocialTeacher,SocialLogo,AddTime,SocialState,SocialPurpose,SocialType ");
			strSql.Append(" from Assn ");
			strSql.Append(" where AssnID="+AssnID+" " );
			Maticsoft.Model.Assn model=new Maticsoft.Model.Assn();
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
		public Maticsoft.Model.Assn DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Assn model=new Maticsoft.Model.Assn();
			if (row != null)
			{
				if(row["AssnID"]!=null && row["AssnID"].ToString()!="")
				{
					model.AssnID=int.Parse(row["AssnID"].ToString());
				}
				if(row["SocialName"]!=null)
				{
					model.SocialName=row["SocialName"].ToString();
				}
				if(row["SocialTeacher"]!=null)
				{
					model.SocialTeacher=row["SocialTeacher"].ToString();
				}
				if(row["SocialLogo"]!=null)
				{
					model.SocialLogo=row["SocialLogo"].ToString();
				}
				if(row["AddTime"]!=null && row["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(row["AddTime"].ToString());
				}
				if(row["SocialState"]!=null)
				{
					model.SocialState=row["SocialState"].ToString();
				}
				if(row["SocialPurpose"]!=null)
				{
					model.SocialPurpose=row["SocialPurpose"].ToString();
				}
				if(row["SocialType"]!=null)
				{
					model.SocialType=row["SocialType"].ToString();
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
			strSql.Append("select AssnID,SocialName,SocialTeacher,SocialLogo,AddTime,SocialState,SocialPurpose,SocialType ");
			strSql.Append(" FROM Assn ");
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
			strSql.Append(" AssnID,SocialName,SocialTeacher,SocialLogo,AddTime,SocialState,SocialPurpose,SocialType ");
			strSql.Append(" FROM Assn ");
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
			strSql.Append("select count(1) FROM Assn ");
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
				strSql.Append("order by T.AssnID desc");
			}
			strSql.Append(")AS Row, T.*  from Assn T ");
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

