using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.BackManagement
{
    public partial class Backddxx : System.Web.UI.Page
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
            if (UsersInfo.UserID == "")
            {
                Response.Write("<script> alert('请先登录！'); window.location.href='/BackLogin.aspx' </script>");
                return;
            }
            if (ShoppingCart_Bll.GetRecordCount4("a.CommodityID = b.CommodityID and OrderID='" + Request.QueryString["ID"] + "'") > 5)
            {
                RadDataPager1.Visible = true;
            }
            else
            {
                RadDataPager1.Visible = false;
            }
            if (!IsPostBack)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    Maticsoft.Model.Orders modelnew = Orders_Bll.GetModel(Request.QueryString["ID"].ToString());//引用id所在行的数据
                    Lbl_ddh.Text = modelnew.OrderID;//添加数据
                    Lbl_shfs.Text = modelnew.Delivery;
                    Lbl_shrxx.Text = modelnew.AddresseeName;
                    Lbl_zffs.Text = modelnew.PayType;
                    Lbl_money.Text = modelnew.TotalMoney.ToString();
                    Lbl_State.Text = modelnew.OrderState;
                    if (modelnew.OrderState != "已付款待发货")
                    {
                        Button1.Visible = false;
                    }
                }
                else
                {
                    Response.Redirect("Backddgl.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Orders_Mol = Orders_Bll.GetModel(Request.QueryString["ID"].ToString());//引用id所在行的数据
            Orders_Mol.OrderState = "已发货";
            Orders_Bll.Update(Orders_Mol);
            Response.Write("<script>alert('发货成功!');window.location.href='Backddgl.aspx'</script>");
        }

        protected void Button2_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("Backddgl.aspx");
        }

        protected void RadListView1_ItemCommand(object sender, Telerik.Web.UI.RadListViewCommandEventArgs e)
        {

        }

        protected void RadListView1_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            RadListView1.DataSource = OrderDetail_Bll.GetList4("a.CommodityID = b.CommodityID and OrderID='" + Request.QueryString["ID"] + "'");
        }
    }
}