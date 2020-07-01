/**  版本信息模板在安装目录下，可自行修改。
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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Users
	/// </summary>
	public partial class Users
	{
		public Users()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string UserID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Users");
			strSql.Append(" where UserID='"+UserID+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.UserID != null)
			{
				strSql1.Append("UserID,");
				strSql2.Append("'"+model.UserID+"',");
			}
			if (model.Username != null)
			{
				strSql1.Append("Username,");
				strSql2.Append("'"+model.Username+"',");
			}
			if (model.UserPassword != null)
			{
				strSql1.Append("UserPassword,");
				strSql2.Append("'"+model.UserPassword+"',");
			}
			if (model.UserRealName != null)
			{
				strSql1.Append("UserRealName,");
				strSql2.Append("'"+model.UserRealName+"',");
			}
			if (model.UserSex != null)
			{
				strSql1.Append("UserSex,");
				strSql2.Append("'"+model.UserSex+"',");
			}
			if (model.UserEmail != null)
			{
				strSql1.Append("UserEmail,");
				strSql2.Append("'"+model.UserEmail+"',");
			}
			if (model.UserGrade != null)
			{
				strSql1.Append("UserGrade,");
				strSql2.Append("'"+model.UserGrade+"',");
			}
			if (model.UserScore != null)
			{
				strSql1.Append("UserScore,");
				strSql2.Append(""+model.UserScore+",");
			}
			if (model.Province != null)
			{
				strSql1.Append("Province,");
				strSql2.Append("'"+model.Province+"',");
			}
			if (model.City != null)
			{
				strSql1.Append("City,");
				strSql2.Append("'"+model.City+"',");
			}
			if (model.Address1 != null)
			{
				strSql1.Append("Address1,");
				strSql2.Append("'"+model.Address1+"',");
			}
			if (model.UserIdentity != null)
			{
				strSql1.Append("UserIdentity,");
				strSql2.Append("'"+model.UserIdentity+"',");
			}
			if (model.RegistTime != null)
			{
				strSql1.Append("RegistTime,");
				strSql2.Append("'"+model.RegistTime+"',");
			}
			if (model.Phone != null)
			{
				strSql1.Append("Phone,");
				strSql2.Append("'"+model.Phone+"',");
			}
			strSql.Append("insert into Users(");
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
		public bool Update(Maticsoft.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Users set ");
			if (model.Username != null)
			{
				strSql.Append("Username='"+model.Username+"',");
			}
			else
			{
				strSql.Append("Username= null ,");
			}
			if (model.UserPassword != null)
			{
				strSql.Append("UserPassword='"+model.UserPassword+"',");
			}
			else
			{
				strSql.Append("UserPassword= null ,");
			}
			if (model.UserRealName != null)
			{
				strSql.Append("UserRealName='"+model.UserRealName+"',");
			}
			else
			{
				strSql.Append("UserRealName= null ,");
			}
			if (model.UserSex != null)
			{
				strSql.Append("UserSex='"+model.UserSex+"',");
			}
			else
			{
				strSql.Append("UserSex= null ,");
			}
			if (model.UserEmail != null)
			{
				strSql.Append("UserEmail='"+model.UserEmail+"',");
			}
			else
			{
				strSql.Append("UserEmail= null ,");
			}
			if (model.UserGrade != null)
			{
				strSql.Append("UserGrade='"+model.UserGrade+"',");
			}
			else
			{
				strSql.Append("UserGrade= null ,");
			}
			if (model.UserScore != null)
			{
				strSql.Append("UserScore="+model.UserScore+",");
			}
			else
			{
				strSql.Append("UserScore= null ,");
			}
			if (model.Province != null)
			{
				strSql.Append("Province='"+model.Province+"',");
			}
			else
			{
				strSql.Append("Province= null ,");
			}
			if (model.City != null)
			{
				strSql.Append("City='"+model.City+"',");
			}
			else
			{
				strSql.Append("City= null ,");
			}
			if (model.Address1 != null)
			{
				strSql.Append("Address1='"+model.Address1+"',");
			}
			else
			{
				strSql.Append("Address1= null ,");
			}
			if (model.UserIdentity != null)
			{
				strSql.Append("UserIdentity='"+model.UserIdentity+"',");
			}
			else
			{
				strSql.Append("UserIdentity= null ,");
			}
			if (model.RegistTime != null)
			{
				strSql.Append("RegistTime='"+model.RegistTime+"',");
			}
			else
			{
				strSql.Append("RegistTime= null ,");
			}
			if (model.Phone != null)
			{
				strSql.Append("Phone='"+model.Phone+"',");
			}
			else
			{
				strSql.Append("Phone= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where UserID='"+ model.UserID+"' ");
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
		public bool Delete(string UserID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Users ");
			strSql.Append(" where UserID='"+UserID+"' " );
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
		public bool DeleteList(string UserIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Users ");
			strSql.Append(" where UserID in ("+UserIDlist + ")  ");
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
		public Maticsoft.Model.Users GetModel(string UserID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" UserID,Username,UserPassword,UserRealName,UserSex,UserEmail,UserGrade,UserScore,Province,City,Address1,UserIdentity,RegistTime,Phone ");
			strSql.Append(" from Users ");
			strSql.Append(" where UserID='"+UserID+"' " );
			Maticsoft.Model.Users model=new Maticsoft.Model.Users();
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
		public Maticsoft.Model.Users DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Users model=new Maticsoft.Model.Users();
			if (row != null)
			{
				if(row["UserID"]!=null)
				{
					model.UserID=row["UserID"].ToString();
				}
				if(row["Username"]!=null)
				{
					model.Username=row["Username"].ToString();
				}
				if(row["UserPassword"]!=null)
				{
					model.UserPassword=row["UserPassword"].ToString();
				}
				if(row["UserRealName"]!=null)
				{
					model.UserRealName=row["UserRealName"].ToString();
				}
				if(row["UserSex"]!=null)
				{
					model.UserSex=row["UserSex"].ToString();
				}
				if(row["UserEmail"]!=null)
				{
					model.UserEmail=row["UserEmail"].ToString();
				}
				if(row["UserGrade"]!=null)
				{
					model.UserGrade=row["UserGrade"].ToString();
				}
				if(row["UserScore"]!=null && row["UserScore"].ToString()!="")
				{
					model.UserScore=int.Parse(row["UserScore"].ToString());
				}
				if(row["Province"]!=null)
				{
					model.Province=row["Province"].ToString();
				}
				if(row["City"]!=null)
				{
					model.City=row["City"].ToString();
				}
				if(row["Address1"]!=null)
				{
					model.Address1=row["Address1"].ToString();
				}
				if(row["UserIdentity"]!=null)
				{
					model.UserIdentity=row["UserIdentity"].ToString();
				}
				if(row["RegistTime"]!=null && row["RegistTime"].ToString()!="")
				{
					model.RegistTime=DateTime.Parse(row["RegistTime"].ToString());
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
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
			strSql.Append("select UserID,Username,UserPassword,UserRealName,UserSex,UserEmail,UserGrade,UserScore,Province,City,Address1,UserIdentity,RegistTime,Phone ");
			strSql.Append(" FROM Users ");
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
			strSql.Append(" UserID,Username,UserPassword,UserRealName,UserSex,UserEmail,UserGrade,UserScore,Province,City,Address1,UserIdentity,RegistTime,Phone ");
			strSql.Append(" FROM Users ");
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
			strSql.Append("select count(1) FROM Users ");
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
				strSql.Append("order by T.UserID desc");
			}
			strSql.Append(")AS Row, T.*  from Users T ");
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

