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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Orders
	/// </summary>
	public partial class Orders
	{
		public Orders()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string OrderID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Orders");
			strSql.Append(" where OrderID='"+OrderID+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Orders model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.OrderID != null)
			{
				strSql1.Append("OrderID,");
				strSql2.Append("'"+model.OrderID+"',");
			}
			if (model.UserID != null)
			{
				strSql1.Append("UserID,");
				strSql2.Append("'"+model.UserID+"',");
			}
			if (model.OrderDate != null)
			{
				strSql1.Append("OrderDate,");
				strSql2.Append("'"+model.OrderDate+"',");
			}
			if (model.OrderState != null)
			{
				strSql1.Append("OrderState,");
				strSql2.Append("'"+model.OrderState+"',");
			}
			if (model.CommodityID != null)
			{
				strSql1.Append("CommodityID,");
				strSql2.Append("'"+model.CommodityID+"',");
			}
			if (model.OrderNumber != null)
			{
				strSql1.Append("OrderNumber,");
				strSql2.Append("'"+model.OrderNumber+"',");
			}
			if (model.AddresseeName != null)
			{
				strSql1.Append("AddresseeName,");
				strSql2.Append("'"+model.AddresseeName+"',");
			}
			if (model.AddresseeAddress != null)
			{
				strSql1.Append("AddresseeAddress,");
				strSql2.Append("'"+model.AddresseeAddress+"',");
			}
			if (model.AddresseeZipCode != null)
			{
				strSql1.Append("AddresseeZipCode,");
				strSql2.Append("'"+model.AddresseeZipCode+"',");
			}
			if (model.AddresseePhone != null)
			{
				strSql1.Append("AddresseePhone,");
				strSql2.Append("'"+model.AddresseePhone+"',");
			}
			if (model.TotalMoney != null)
			{
				strSql1.Append("TotalMoney,");
				strSql2.Append(""+model.TotalMoney+",");
			}
			if (model.PayType != null)
			{
				strSql1.Append("PayType,");
				strSql2.Append("'"+model.PayType+"',");
			}
			if (model.Delivery != null)
			{
				strSql1.Append("Delivery,");
				strSql2.Append("'"+model.Delivery+"',");
			}
			if (model.Message != null)
			{
				strSql1.Append("Message,");
				strSql2.Append("'"+model.Message+"',");
			}
			if (model.OrderImage != null)
			{
				strSql1.Append("OrderImage,");
				strSql2.Append("'"+model.OrderImage+"',");
			}
			if (model.CommodityName != null)
			{
				strSql1.Append("CommodityName,");
				strSql2.Append("'"+model.CommodityName+"',");
			}
			if (model.Price != null)
			{
				strSql1.Append("Price,");
				strSql2.Append(""+model.Price+",");
			}
			strSql.Append("insert into Orders(");
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
		public bool Update(Maticsoft.Model.Orders model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Orders set ");
			if (model.UserID != null)
			{
				strSql.Append("UserID='"+model.UserID+"',");
			}
			else
			{
				strSql.Append("UserID= null ,");
			}
			if (model.OrderDate != null)
			{
				strSql.Append("OrderDate='"+model.OrderDate+"',");
			}
			else
			{
				strSql.Append("OrderDate= null ,");
			}
			if (model.OrderState != null)
			{
				strSql.Append("OrderState='"+model.OrderState+"',");
			}
			else
			{
				strSql.Append("OrderState= null ,");
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
				strSql.Append("OrderNumber='"+model.OrderNumber+"',");
			}
			else
			{
				strSql.Append("OrderNumber= null ,");
			}
			if (model.AddresseeName != null)
			{
				strSql.Append("AddresseeName='"+model.AddresseeName+"',");
			}
			else
			{
				strSql.Append("AddresseeName= null ,");
			}
			if (model.AddresseeAddress != null)
			{
				strSql.Append("AddresseeAddress='"+model.AddresseeAddress+"',");
			}
			else
			{
				strSql.Append("AddresseeAddress= null ,");
			}
			if (model.AddresseeZipCode != null)
			{
				strSql.Append("AddresseeZipCode='"+model.AddresseeZipCode+"',");
			}
			else
			{
				strSql.Append("AddresseeZipCode= null ,");
			}
			if (model.AddresseePhone != null)
			{
				strSql.Append("AddresseePhone='"+model.AddresseePhone+"',");
			}
			else
			{
				strSql.Append("AddresseePhone= null ,");
			}
			if (model.TotalMoney != null)
			{
				strSql.Append("TotalMoney="+model.TotalMoney+",");
			}
			else
			{
				strSql.Append("TotalMoney= null ,");
			}
			if (model.PayType != null)
			{
				strSql.Append("PayType='"+model.PayType+"',");
			}
			else
			{
				strSql.Append("PayType= null ,");
			}
			if (model.Delivery != null)
			{
				strSql.Append("Delivery='"+model.Delivery+"',");
			}
			else
			{
				strSql.Append("Delivery= null ,");
			}
			if (model.Message != null)
			{
				strSql.Append("Message='"+model.Message+"',");
			}
			else
			{
				strSql.Append("Message= null ,");
			}
			if (model.OrderImage != null)
			{
				strSql.Append("OrderImage='"+model.OrderImage+"',");
			}
			else
			{
				strSql.Append("OrderImage= null ,");
			}
			if (model.CommodityName != null)
			{
				strSql.Append("CommodityName='"+model.CommodityName+"',");
			}
			else
			{
				strSql.Append("CommodityName= null ,");
			}
			if (model.Price != null)
			{
				strSql.Append("Price="+model.Price+",");
			}
			else
			{
				strSql.Append("Price= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where OrderID='"+ model.OrderID+"' ");
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
		public bool Delete(string OrderID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Orders ");
			strSql.Append(" where OrderID='"+OrderID+"' " );
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
		public bool DeleteList(string OrderIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Orders ");
			strSql.Append(" where OrderID in ("+OrderIDlist + ")  ");
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

        public bool DeleteList2(string OrderIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Orders ");
            strSql.Append(" where UserID in (" + OrderIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Maticsoft.Model.Orders GetModel(string OrderID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" OrderID,UserID,OrderDate,OrderState,CommodityID,OrderNumber,AddresseeName,AddresseeAddress,AddresseeZipCode,AddresseePhone,TotalMoney,PayType,Delivery,Message,OrderImage,CommodityName,Price ");
			strSql.Append(" from Orders ");
			strSql.Append(" where OrderID='"+OrderID+"' " );
			Maticsoft.Model.Orders model=new Maticsoft.Model.Orders();
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
		public Maticsoft.Model.Orders DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Orders model=new Maticsoft.Model.Orders();
			if (row != null)
			{
				if(row["OrderID"]!=null)
				{
					model.OrderID=row["OrderID"].ToString();
				}
				if(row["UserID"]!=null)
				{
					model.UserID=row["UserID"].ToString();
				}
				if(row["OrderDate"]!=null && row["OrderDate"].ToString()!="")
				{
					model.OrderDate=DateTime.Parse(row["OrderDate"].ToString());
				}
				if(row["OrderState"]!=null)
				{
					model.OrderState=row["OrderState"].ToString();
				}
				if(row["CommodityID"]!=null)
				{
					model.CommodityID=row["CommodityID"].ToString();
				}
				if(row["OrderNumber"]!=null)
				{
					model.OrderNumber=row["OrderNumber"].ToString();
				}
				if(row["AddresseeName"]!=null)
				{
					model.AddresseeName=row["AddresseeName"].ToString();
				}
				if(row["AddresseeAddress"]!=null)
				{
					model.AddresseeAddress=row["AddresseeAddress"].ToString();
				}
				if(row["AddresseeZipCode"]!=null)
				{
					model.AddresseeZipCode=row["AddresseeZipCode"].ToString();
				}
				if(row["AddresseePhone"]!=null)
				{
					model.AddresseePhone=row["AddresseePhone"].ToString();
				}
				if(row["TotalMoney"]!=null && row["TotalMoney"].ToString()!="")
				{
					model.TotalMoney=decimal.Parse(row["TotalMoney"].ToString());
				}
				if(row["PayType"]!=null)
				{
					model.PayType=row["PayType"].ToString();
				}
				if(row["Delivery"]!=null)
				{
					model.Delivery=row["Delivery"].ToString();
				}
				if(row["Message"]!=null)
				{
					model.Message=row["Message"].ToString();
				}
				if(row["OrderImage"]!=null)
				{
					model.OrderImage=row["OrderImage"].ToString();
				}
				if(row["CommodityName"]!=null)
				{
					model.CommodityName=row["CommodityName"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
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
			strSql.Append("select OrderID,UserID,OrderDate,OrderState,CommodityID,OrderNumber,AddresseeName,AddresseeAddress,AddresseeZipCode,AddresseePhone,TotalMoney,PayType,Delivery,Message,OrderImage,CommodityName,Price ");
			strSql.Append(" FROM Orders ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public DataSet GetList2(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *");
            strSql.Append(" FROM Orders ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetList3(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from Orders a where DateDiff(dd,a.OrderDate,getdate())>=7 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
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
			strSql.Append(" OrderID,UserID,OrderDate,OrderState,CommodityID,OrderNumber,AddresseeName,AddresseeAddress,AddresseeZipCode,AddresseePhone,TotalMoney,PayType,Delivery,Message,OrderImage,CommodityName,Price ");
			strSql.Append(" FROM Orders ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

        public DataSet GetList2(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" *  ");
            strSql.Append(" FROM OrderDetail b,Orders a,Commodity c where  c.CommodityID = b.CommodityID and a.OrderID = b.OrderID");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
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
			strSql.Append("select count(1) FROM Orders ");
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

        public int GetRecordCount2(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Orders ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
				strSql.Append("order by T.OrderID desc");
			}
			strSql.Append(")AS Row, T.*  from Orders T ");
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
        public int GetTotal(string OrderID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SUM(CONVERT(int,Commodity.BuyScore)* OrderDetail.OrderNumber) as total  ");
            strSql.Append(" from OrderDetail,Commodity ");
            strSql.Append(" where  OrderDetail.CommodityID=Commodity.CommodityID and OrderDetail.OrderID='"+OrderID+"' ");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            return Convert.ToInt32(obj);
        }
		#endregion  MethodEx
	}
}

