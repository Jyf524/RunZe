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
namespace Maticsoft.Model
{
    /// <summary>
    /// OrderDetail:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class OrderDetail
    {
        public OrderDetail()
        { }
        #region Model
        private string _orderdetailid;
        private string _orderid;
        private string _commodityid;
        private string _userid;
        private int? _ordernumber;
        private int? _appraisegrade;
        private string _subtotal;
        /// <summary>
        /// 
        /// </summary>
        public string OrderDetailID
        {
            set { _orderdetailid = value; }
            get { return _orderdetailid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OrderID
        {
            set { _orderid = value; }
            get { return _orderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CommodityID
        {
            set { _commodityid = value; }
            get { return _commodityid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? OrderNumber
        {
            set { _ordernumber = value; }
            get { return _ordernumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? AppraiseGrade
        {
            set { _appraisegrade = value; }
            get { return _appraisegrade; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Subtotal
        {
            set { _subtotal = value; }
            get { return _subtotal; }
        }
        #endregion Model

    }
}

