/**  版本信息模板在安装目录下，可自行修改。
* Commodity.cs
*
* 功 能： N/A
* 类 名： Commodity
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/1/14 11:42:19   N/A    初版
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
	/// 数据访问类:Commodity
	/// </summary>
	public partial class Commodity
	{
		public Commodity()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CommodityID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Commodity");
			strSql.Append(" where CommodityID='"+CommodityID+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Commodity model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.CommodityID != null)
			{
				strSql1.Append("CommodityID,");
				strSql2.Append("'"+model.CommodityID+"',");
			}
			if (model.CommodityFatherID != null)
			{
				strSql1.Append("CommodityFatherID,");
				strSql2.Append("'"+model.CommodityFatherID+"',");
			}
			if (model.CommoditySonID != null)
			{
				strSql1.Append("CommoditySonID,");
				strSql2.Append("'"+model.CommoditySonID+"',");
			}
			if (model.CommodityName != null)
			{
				strSql1.Append("CommodityName,");
				strSql2.Append("'"+model.CommodityName+"',");
			}
			if (model.CommodityPrice != null)
			{
				strSql1.Append("CommodityPrice,");
				strSql2.Append("'"+model.CommodityPrice+"',");
			}
			if (model.MarketPrice != null)
			{
				strSql1.Append("MarketPrice,");
				strSql2.Append(""+model.MarketPrice+",");
			}
			if (model.VIPPrice != null)
			{
				strSql1.Append("VIPPrice,");
				strSql2.Append(""+model.VIPPrice+",");
			}
			if (model.Stock != null)
			{
				strSql1.Append("Stock,");
				strSql2.Append(""+model.Stock+",");
			}
			if (model.BuyScore != null)
			{
				strSql1.Append("BuyScore,");
				strSql2.Append("'"+model.BuyScore+"',");
			}
			if (model.CommodityImage != null)
			{
				strSql1.Append("CommodityImage,");
				strSql2.Append("'"+model.CommodityImage+"',");
			}
			if (model.CommodityType != null)
			{
				strSql1.Append("CommodityType,");
				strSql2.Append("'"+model.CommodityType+"',");
			}
			if (model.CommoditySaled != null)
			{
				strSql1.Append("CommoditySaled,");
				strSql2.Append(""+model.CommoditySaled+",");
			}
			if (model.Introduce != null)
			{
				strSql1.Append("Introduce,");
				strSql2.Append("'"+model.Introduce+"',");
			}
			if (model.CommodityTime != null)
			{
				strSql1.Append("CommodityTime,");
				strSql2.Append("'"+model.CommodityTime+"',");
			}
			if (model.Recommend != null)
			{
				strSql1.Append("Recommend,");
				strSql2.Append("'"+model.Recommend+"',");
			}
			if (model.CommodityState != null)
			{
				strSql1.Append("CommodityState,");
				strSql2.Append("'"+model.CommodityState+"',");
			}
			if (model.Score != null)
			{
				strSql1.Append("Score,");
				strSql2.Append("'"+model.Score+"',");
			}
			if (model.ScoreTimes != null)
			{
				strSql1.Append("ScoreTimes,");
				strSql2.Append("'"+model.ScoreTimes+"',");
			}
			strSql.Append("insert into Commodity(");
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
		public bool Update(Maticsoft.Model.Commodity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Commodity set ");
			if (model.CommodityFatherID != null)
			{
				strSql.Append("CommodityFatherID='"+model.CommodityFatherID+"',");
			}
			else
			{
				strSql.Append("CommodityFatherID= null ,");
			}
			if (model.CommoditySonID != null)
			{
				strSql.Append("CommoditySonID='"+model.CommoditySonID+"',");
			}
			else
			{
				strSql.Append("CommoditySonID= null ,");
			}
			if (model.CommodityName != null)
			{
				strSql.Append("CommodityName='"+model.CommodityName+"',");
			}
			else
			{
				strSql.Append("CommodityName= null ,");
			}
			if (model.CommodityPrice != null)
			{
				strSql.Append("CommodityPrice='"+model.CommodityPrice+"',");
			}
			else
			{
				strSql.Append("CommodityPrice= null ,");
			}
			if (model.MarketPrice != null)
			{
				strSql.Append("MarketPrice="+model.MarketPrice+",");
			}
			else
			{
				strSql.Append("MarketPrice= null ,");
			}
			if (model.VIPPrice != null)
			{
				strSql.Append("VIPPrice="+model.VIPPrice+",");
			}
			else
			{
				strSql.Append("VIPPrice= null ,");
			}
			if (model.Stock != null)
			{
				strSql.Append("Stock="+model.Stock+",");
			}
			else
			{
				strSql.Append("Stock= null ,");
			}
			if (model.BuyScore != null)
			{
				strSql.Append("BuyScore='"+model.BuyScore+"',");
			}
			else
			{
				strSql.Append("BuyScore= null ,");
			}
			if (model.CommodityImage != null)
			{
				strSql.Append("CommodityImage='"+model.CommodityImage+"',");
			}
			else
			{
				strSql.Append("CommodityImage= null ,");
			}
			if (model.CommodityType != null)
			{
				strSql.Append("CommodityType='"+model.CommodityType+"',");
			}
			else
			{
				strSql.Append("CommodityType= null ,");
			}
			if (model.CommoditySaled != null)
			{
				strSql.Append("CommoditySaled="+model.CommoditySaled+",");
			}
			else
			{
				strSql.Append("CommoditySaled= null ,");
			}
			if (model.Introduce != null)
			{
				strSql.Append("Introduce='"+model.Introduce+"',");
			}
			else
			{
				strSql.Append("Introduce= null ,");
			}
			if (model.CommodityTime != null)
			{
				strSql.Append("CommodityTime='"+model.CommodityTime+"',");
			}
			else
			{
				strSql.Append("CommodityTime= null ,");
			}
			if (model.Recommend != null)
			{
				strSql.Append("Recommend='"+model.Recommend+"',");
			}
			else
			{
				strSql.Append("Recommend= null ,");
			}
			if (model.CommodityState != null)
			{
				strSql.Append("CommodityState='"+model.CommodityState+"',");
			}
			else
			{
				strSql.Append("CommodityState= null ,");
			}
			if (model.Score != null)
			{
				strSql.Append("Score='"+model.Score+"',");
			}
			else
			{
				strSql.Append("Score= null ,");
			}
			if (model.ScoreTimes != null)
			{
				strSql.Append("ScoreTimes='"+model.ScoreTimes+"',");
			}
			else
			{
				strSql.Append("ScoreTimes= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where CommodityID='"+ model.CommodityID+"' ");
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
		public bool Delete(string CommodityID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Commodity ");
			strSql.Append(" where CommodityID='"+CommodityID+"' " );
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
		public bool DeleteList(string CommodityIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Commodity ");
			strSql.Append(" where CommodityID in ("+CommodityIDlist + ")  ");
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
		public Maticsoft.Model.Commodity GetModel(string CommodityID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" CommodityID,CommodityFatherID,CommoditySonID,CommodityName,CommodityPrice,MarketPrice,VIPPrice,Stock,BuyScore,CommodityImage,CommodityType,CommoditySaled,Introduce,CommodityTime,Recommend,CommodityState,Score,ScoreTimes ");
			strSql.Append(" from Commodity ");
			strSql.Append(" where CommodityID='"+CommodityID+"' " );
			Maticsoft.Model.Commodity model=new Maticsoft.Model.Commodity();
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
		public Maticsoft.Model.Commodity DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Commodity model=new Maticsoft.Model.Commodity();
			if (row != null)
			{
				if(row["CommodityID"]!=null)
				{
					model.CommodityID=row["CommodityID"].ToString();
				}
				if(row["CommodityFatherID"]!=null)
				{
					model.CommodityFatherID=row["CommodityFatherID"].ToString();
				}
				if(row["CommoditySonID"]!=null)
				{
					model.CommoditySonID=row["CommoditySonID"].ToString();
				}
				if(row["CommodityName"]!=null)
				{
					model.CommodityName=row["CommodityName"].ToString();
				}
				if(row["CommodityPrice"]!=null)
				{
					model.CommodityPrice=row["CommodityPrice"].ToString();
				}
				if(row["MarketPrice"]!=null && row["MarketPrice"].ToString()!="")
				{
					model.MarketPrice=decimal.Parse(row["MarketPrice"].ToString());
				}
				if(row["VIPPrice"]!=null && row["VIPPrice"].ToString()!="")
				{
					model.VIPPrice=decimal.Parse(row["VIPPrice"].ToString());
				}
				if(row["Stock"]!=null && row["Stock"].ToString()!="")
				{
					model.Stock=int.Parse(row["Stock"].ToString());
				}
				if(row["BuyScore"]!=null)
				{
					model.BuyScore=row["BuyScore"].ToString();
				}
				if(row["CommodityImage"]!=null)
				{
					model.CommodityImage=row["CommodityImage"].ToString();
				}
				if(row["CommodityType"]!=null)
				{
					model.CommodityType=row["CommodityType"].ToString();
				}
				if(row["CommoditySaled"]!=null && row["CommoditySaled"].ToString()!="")
				{
					model.CommoditySaled=int.Parse(row["CommoditySaled"].ToString());
				}
				if(row["Introduce"]!=null)
				{
					model.Introduce=row["Introduce"].ToString();
				}
				if(row["CommodityTime"]!=null && row["CommodityTime"].ToString()!="")
				{
					model.CommodityTime=DateTime.Parse(row["CommodityTime"].ToString());
				}
				if(row["Recommend"]!=null)
				{
					model.Recommend=row["Recommend"].ToString();
				}
				if(row["CommodityState"]!=null)
				{
					model.CommodityState=row["CommodityState"].ToString();
				}
				if(row["Score"]!=null)
				{
					model.Score=row["Score"].ToString();
				}
				if(row["ScoreTimes"]!=null)
				{
					model.ScoreTimes=row["ScoreTimes"].ToString();
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
			strSql.Append("select CommodityID,CommodityFatherID,CommoditySonID,CommodityName,CommodityPrice,MarketPrice,VIPPrice,Stock,BuyScore,CommodityImage,CommodityType,CommoditySaled,Introduce,CommodityTime,Recommend,CommodityState,Score,ScoreTimes ");
			strSql.Append(" FROM Commodity ");
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
			strSql.Append(" CommodityID,CommodityFatherID,CommoditySonID,CommodityName,CommodityPrice,MarketPrice,VIPPrice,Stock,BuyScore,CommodityImage,CommodityType,CommoditySaled,Introduce,CommodityTime,Recommend,CommodityState,Score,ScoreTimes ");
			strSql.Append(" FROM Commodity ");
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
			strSql.Append("select count(1) FROM Commodity ");
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
				strSql.Append("order by T.CommodityID desc");
			}
			strSql.Append(")AS Row, T.*  from Commodity T ");
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

