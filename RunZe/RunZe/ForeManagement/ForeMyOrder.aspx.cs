using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.ForeManagement
{
    public partial class ForeMyOrder : System.Web.UI.Page
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
                Response.Write("<script> alert('请先登录！'); window.location.href='../Login.aspx' </script>");
                return;
            }
            if (Orders_Bll.GetRecordCount2("UserID='" + UsersInfo.UserID + "'") > 10)
            {
                RadDataPager1.Visible = true;
            }
            else
            {
                RadDataPager1.Visible = false;
            }


        }


        protected void RadListView1_ItemCommand(object sender, Telerik.Web.UI.RadListViewCommandEventArgs e)
        {
            string OrderID;
            OrderID = e.CommandArgument.ToString();
            Maticsoft.Model.Users molUsers = Users_Bll.GetModel(UsersInfo.UserID);
            if (e.CommandName == "Pay")
            {
                Response.Write("<script>window.location.href='/ForeManagement/ForeOrdersDetail.aspx?OrderID=" + OrderID + "'</script>");
            
            }
            if (e.CommandName == "Cancel")
            {
                Maticsoft.Model.Orders molOrders = Orders_Bll.GetModel(OrderID);
                molOrders.OrderState = "订单取消";
                Orders_Bll.Update(molOrders);
            }
            if (e.CommandName == "Hurry")
            {
                Response.Write("<script> alert('催单成功！')</script>");
            }
            if (e.CommandName == "Check")
            {

                Orders_Mol = Orders_Bll.GetModel(OrderID);//引用
                
               
                DataSet ds = new DataSet();
                ds = Orders_Bll.GetList2(0, " a.OrderID='" + OrderID + "' ", " OrderDate");
                Users_Mol = Users_Bll.GetModel(UsersInfo.UserID);//引用
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //增加销售数量
                    Commodity_Mol = Commodity_Bll.GetModel(dr["CommodityID"].ToString());
                    Commodity_Mol.CommoditySaled = Commodity_Mol.CommoditySaled + Convert.ToInt32(dr["OrderNumber"]);
                    Commodity_Bll.Update(Commodity_Mol);//更新
                    //增加积分点数
                    string str = dr["BuyScore"].ToString();
                    string shu = dr["OrderNumber"].ToString();
                    Users_Mol.UserScore += Convert.ToInt32(str) * Convert.ToInt32(shu);
                }
                Users_Mol.UserGrade = "VIP";
                Orders_Mol.OrderState = "完成";
                Orders_Bll.Update(Orders_Mol);//更新
                Users_Bll.Update(Users_Mol);//更新
                RadListView1.Rebind();



                Maticsoft.Model.Orders molOrders = Orders_Bll.GetModel(OrderID);
                //Maticsoft.Model.Commodity molCommodity = Commodity_Bll.GetModel(OrderID);
                //int total = Orders_Bll.GetTotal(OrderID);
                //molUsers.UserScore += total;
                //molOrders.OrderState = "完成";
                Orders_Bll.Update(molOrders);
            }
            if (e.CommandName == "Score")
            {

            }
        }

        protected void RadListView1_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Orders_Bll.GetList3(" a.OrderState = '待付款' ");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Maticsoft.Model.Orders modelorders = new Maticsoft.Model.Orders();
                modelorders = Orders_Bll.GetModel(dr["OrderID"].ToString());
                modelorders.OrderState = "订单取消";
                Orders_Bll.Update(modelorders);
            }
            RadListView1.DataSource = Orders_Bll.GetList2("UserID='" + UsersInfo.UserID + "'");
        }

        protected void RadListView1_ItemDataBound(object sender, Telerik.Web.UI.RadListViewItemEventArgs e)
        {
                string id = e.Item.OwnerListView.DataKeyValues[e.Item.OwnerListView.DataKeyValues.Count - 1]["OrderID"].ToString();
                LinkButton LinkBtn_Pay = e.Item.FindControl("LinkBtn_Pay") as LinkButton;
                LinkButton LinkBtn_Cancel = e.Item.FindControl("LinkBtn_Cancel") as LinkButton;
                LinkButton LinkBtn_Hurry = e.Item.FindControl("LinkBtn_Hurry") as LinkButton;
                LinkButton LinkBtn_Check = e.Item.FindControl("LinkBtn_Check") as LinkButton;
                LinkButton LinBtn_Score = e.Item.FindControl("LinBtn_Score") as LinkButton;
                Orders_Mol = Orders_Bll.GetModel(id);
                LinkBtn_Pay.Visible = false;
                LinkBtn_Cancel.Visible = false;
                LinkBtn_Hurry.Visible = false;
                LinkBtn_Check.Visible = false;
                LinBtn_Score.Visible = false;
                switch (Orders_Mol.OrderState)
                {
                    case "待付款":
                        LinkBtn_Pay.Visible = true;
                        LinkBtn_Cancel.Visible = true;
                        break;
                    case "已付款待发货":
                        LinkBtn_Hurry.Visible = true;
                        break;
                    case "已发货":
                        LinkBtn_Check.Visible = true;
                        break;
                    case "完成":
                        LinBtn_Score.Visible = true;
                        break;
                    case "订单取消":

                        break;
                }

        }
    }
}