/**  版本信息模板在安装目录下，可自行修改。
* OrderDetail.cs
*
* 功 能： N/A
* 类 名： OrderDetail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/1/11 9:25:56   N/A    初版
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
    /// 数据访问类:OrderDetail
    /// </summary>
    public partial class OrderDetail
    {
        public OrderDetail()
        { }
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string OrderDetailID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from OrderDetail");
            strSql.Append(" where OrderDetailID='" + OrderDetailID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.OrderDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.OrderDetailID != null)
            {
                strSql1.Append("OrderDetailID,");
                strSql2.Append("'" + model.OrderDetailID + "',");
            }
            if (model.OrderID != null)
            {
                strSql1.Append("OrderID,");
                strSql2.Append("'" + model.OrderID + "',");
            }
            if (model.CommodityID != null)
            {
                strSql1.Append("CommodityID,");
                strSql2.Append("'" + model.CommodityID + "',");
            }
            if (model.UserID != null)
            {
                strSql1.Append("UserID,");
                strSql2.Append("'" + model.UserID + "',");
            }
            if (model.OrderNumber != null)
            {
                strSql1.Append("OrderNumber,");
                strSql2.Append("" + model.OrderNumber + ",");
            }
            if (model.AppraiseGrade != null)
            {
                strSql1.Append("AppraiseGrade,");
                strSql2.Append("" + model.AppraiseGrade + ",");
            }
            if (model.Subtotal != null)
            {
                strSql1.Append("Subtotal,");
                strSql2.Append("'" + model.Subtotal + "',");
            }
            strSql.Append("insert into OrderDetail(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
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
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.OrderDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update OrderDetail set ");
            if (model.OrderID != null)
            {
                strSql.Append("OrderID='" + model.OrderID + "',");
            }
            else
            {
                strSql.Append("OrderID= null ,");
            }
            if (model.CommodityID != null)
            {
                strSql.Append("CommodityID='" + model.CommodityID + "',");
            }
            else
            {
                strSql.Append("CommodityID= null ,");
            }
            if (model.UserID != null)
            {
                strSql.Append("UserID='" + model.UserID + "',");
            }
            else
            {
                strSql.Append("UserID= null ,");
            }
            if (model.OrderNumber != null)
            {
                strSql.Append("OrderNumber=" + model.OrderNumber + ",");
            }
            else
            {
                strSql.Append("OrderNumber= null ,");
            }
            if (model.AppraiseGrade != null)
            {
                strSql.Append("AppraiseGrade=" + model.AppraiseGrade + ",");
            }
            else
            {
                strSql.Append("AppraiseGrade= null ,");
            }
            if (model.Subtotal != null)
            {
                strSql.Append("Subtotal='" + model.Subtotal + "',");
            }
            else
            {
                strSql.Append("Subtotal= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where OrderDetailID='" + model.OrderDetailID + "' ");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public bool Delete(string OrderDetailID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from OrderDetail ");
            strSql.Append(" where OrderDetailID='" + OrderDetailID + "' ");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public bool DeleteList(string OrderDetailIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from OrderDetail ");
            strSql.Append(" where OrderDetailID in (" + OrderDetailIDlist + ")  ");
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

        public bool DeleteList2(string OrderDetailIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from OrderDetail ");
            strSql.Append(" where UserID in (" + OrderDetailIDlist + ")  ");
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
        public Maticsoft.Model.OrderDetail GetModel(string OrderDetailID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" OrderDetailID,OrderID,CommodityID,UserID,OrderNumber,AppraiseGrade,Subtotal ");
            strSql.Append(" from OrderDetail ");
            strSql.Append(" where OrderDetailID='" + OrderDetailID + "' ");
            Maticsoft.Model.OrderDetail model = new Maticsoft.Model.OrderDetail();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
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
        public Maticsoft.Model.OrderDetail DataRowToModel(DataRow row)
        {
            Maticsoft.Model.OrderDetail model = new Maticsoft.Model.OrderDetail();
            if (row != null)
            {
                if (row["OrderDetailID"] != null)
                {
                    model.OrderDetailID = row["OrderDetailID"].ToString();
                }
                if (row["OrderID"] != null)
                {
                    model.OrderID = row["OrderID"].ToString();
                }
                if (row["CommodityID"] != null)
                {
                    model.CommodityID = row["CommodityID"].ToString();
                }
                if (row["UserID"] != null)
                {
                    model.UserID = row["UserID"].ToString();
                }
                if (row["OrderNumber"] != null && row["OrderNumber"].ToString() != "")
                {
                    model.OrderNumber = int.Parse(row["OrderNumber"].ToString());
                }
                if (row["AppraiseGrade"] != null && row["AppraiseGrade"].ToString() != "")
                {
                    model.AppraiseGrade = int.Parse(row["AppraiseGrade"].ToString());
                }
                if (row["Subtotal"] != null)
                {
                    model.Subtotal = row["Subtotal"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select OrderDetailID,OrderID,CommodityID,UserID,OrderNumber,AppraiseGrade,Subtotal ");
            strSql.Append(" FROM OrderDetail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetList2(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select AVG(OrderDetail.AppraiseGrade) as AVGAppraiseGrade ");
            strSql.Append(" FROM OrderDetail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetList3(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SUM(convert(decimal(18,2),[Subtotal])) ");
            strSql.Append(" FROM OrderDetail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetList4(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select OrderDetailID,OrderID,a.CommodityID,UserID,OrderNumber,AppraiseGrade,Subtotal,b.CommodityImage,b.CommodityName ");
            strSql.Append(" FROM OrderDetail a,Commodity b ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" OrderDetailID,OrderID,CommodityID,UserID,OrderNumber,AppraiseGrade,Subtotal ");
            strSql.Append(" FROM OrderDetail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM OrderDetail ");
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

        public int GetRecordCount2(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM OrderDetail a,Orders b ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where a.OrderID=b.OrderID " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.OrderDetailID desc");
            }
            strSql.Append(")AS Row, T.*  from OrderDetail T ");
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

