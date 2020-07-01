using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.ForeManagement
{
    public partial class ForeOrderShow : System.Web.UI.Page
    {
        Maticsoft.BLL.Users Users_Bll = new Maticsoft.BLL.Users();
        Maticsoft.Model.Users Users_Mol = new Maticsoft.Model.Users();
        Maticsoft.BLL.Appraise Appraise_Bll = new Maticsoft.BLL.Appraise();
        Maticsoft.Model.Appraise Appraise_Mol = new Maticsoft.Model.Appraise();
        Maticsoft.BLL.Commodity Commodity_Bll = new Maticsoft.BLL.Commodity();
        Maticsoft.Model.Commodity Commodity_Mol = new Maticsoft.Model.Commodity();
        Maticsoft.BLL.CommodityFather CommodityFather_Bll = new Maticsoft.BLL.CommodityFather();
        Maticsoft.BLL.CommoditySon CommoditySon_Bll = new Maticsoft.BLL.CommoditySon();
        Maticsoft.BLL.ShoppingCart ShoppingCart_Bll = new Maticsoft.BLL.ShoppingCart();
        Maticsoft.Model.ShoppingCart ShoppingCart_Mol = new Maticsoft.Model.ShoppingCart();
        Maticsoft.BLL.Orders Orders_Bll = new Maticsoft.BLL.Orders();
        Maticsoft.Model.Orders Orders_Mol = new Maticsoft.Model.Orders();
        Maticsoft.BLL.OrderDetail OrderDetail_Bll = new Maticsoft.BLL.OrderDetail();
        Maticsoft.Model.OrderDetail OrderDetail_Mol = new Maticsoft.Model.OrderDetail();
        protected void Page_Load(object sender, EventArgs e)
        {
            Maticsoft.Model.Orders molOrder = Orders_Bll.GetModel(Request.QueryString["OrderID"]);
            Maticsoft.Model.OrderDetail molOrderDetail = OrderDetail_Bll.GetModel(Request.QueryString["OrderID"]);
            if (UsersInfo.UserID == "")
            {
                Response.Write("<script> alert('请先登录！'); window.location.href='../Login.aspx' </script>");
                return;
            }
            if (ShoppingCart_Bll.GetRecordCount4("a.CommodityID = b.CommodityID and OrderID='" + Request.QueryString["OrderID"] + "' and a.UserID='" + UsersInfo.UserID + "'") > 2)
            {
                RadDataPager1.Visible = true;
            }
            else
            {
                RadDataPager1.Visible = false;
            }
            Lbl_OrderID.Text = molOrder.OrderID;
            Label1.Text = molOrder.AddresseeName;
            Label2.Text = molOrder.AddresseeAddress;
            Label3.Text = molOrder.AddresseeZipCode;
            Label4.Text = molOrder.AddresseePhone;
            if (molOrder.Delivery == "")
            {
                Label6.Text = "暂未选择送货方式";
            }
            else
            {
                Label6.Text = molOrder.Delivery;
            }
            if (molOrder.PayType == "")
            {
                Label7.Text = "暂未选择支付方式";
            }
            else
            {
                Label7.Text = molOrder.PayType;
            }
            Label5.Text = OrderDetail_Bll.GetList3("OrderID='" + Request.QueryString["OrderID"] + "'").Tables[0].Rows[0][0].ToString();

            Label8.Text = molOrder.TotalMoney.ToString();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ForeManagement/ForeMyOrder.aspx");
        }

        protected void RadListView1_ItemCommand(object sender, Telerik.Web.UI.RadListViewCommandEventArgs e)
        {

        }

        protected void RadListView1_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            RadListView1.DataSource = OrderDetail_Bll.GetList4("a.CommodityID = b.CommodityID and OrderID='" + Request.QueryString["OrderID"] + "' and a.UserID='" + UsersInfo.UserID + "'");
        }
    }
}