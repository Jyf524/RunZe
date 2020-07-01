using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.ForeManagement
{
    public partial class ForeCollect : System.Web.UI.Page
    {
        Maticsoft.BLL.Users Users_Bll = new Maticsoft.BLL.Users();
        Maticsoft.BLL.Appraise Appraise_Bll = new Maticsoft.BLL.Appraise();
        Maticsoft.Model.Appraise Appraise_Mol = new Maticsoft.Model.Appraise();
        Maticsoft.BLL.Commodity Commodity_Bll = new Maticsoft.BLL.Commodity();
        Maticsoft.Model.Commodity Commodity_Mol = new Maticsoft.Model.Commodity();
        Maticsoft.BLL.CommodityFather CommodityFather_Bll = new Maticsoft.BLL.CommodityFather();
        Maticsoft.BLL.CommoditySon CommoditySon_Bll = new Maticsoft.BLL.CommoditySon();
        Maticsoft.BLL.ShoppingCart ShoppingCart_Bll = new Maticsoft.BLL.ShoppingCart();
        Maticsoft.Model.ShoppingCart ShoppingCart_Mol = new Maticsoft.Model.ShoppingCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UsersInfo.UserID == "")
            {
                Response.Write("<script> alert('请先登录！'); window.location.href='../Login.aspx' </script>");
                return;
            }
            if (Commodity_Bll.GetRecordCount2(" a.CommodityID = b.CommodityID and b.UserID='" + UsersInfo.UserID + "' ") > 3)
            {
                RadDataPager_1.Visible = true;
            }
            else
            {
                RadDataPager_1.Visible = false;
            }

        }

        protected void RadButton1_Click(object sender, EventArgs e)
        {

        }

        protected void RadLV_splb_ItemCommand(object sender, Telerik.Web.UI.RadListViewCommandEventArgs e)
        {
            string Collectid = e.CommandArgument.ToString();
            if (e.CommandName == "Delete")
            {
                string AppriseID1;
                AppriseID1 = e.CommandArgument.ToString();
                Appraise_Bll.DeleteList(e.CommandArgument.ToString());
                RadLV_splb.Rebind();//删除
            }
            if (e.CommandName == "Join")
            {
                string CommodityID1;
                CommodityID1 = e.CommandArgument.ToString();
                Maticsoft.Model.Commodity modelCommodity = Commodity_Bll.GetModel(CommodityID1.ToString());
                if (ShoppingCart_Bll.GetRecordCount(" CommodityID='" + CommodityID1 + "' and UserID='" + UsersInfo.UserID + "' ") > 0)
                {
                    
                    Maticsoft.Model.ShoppingCart modelShoppingCart = ShoppingCart_Bll.GetModel(CommodityID1.ToString());
                    string id = ShoppingCart_Bll.GetList(" CommodityID='" + CommodityID1 + "' and UserID='" + UsersInfo.UserID + "' ").Tables[0].Rows[0]["ShoppingCartID"].ToString();
                    modelShoppingCart = ShoppingCart_Bll.GetModel(id);
                    modelShoppingCart.ShoppingCartID = modelShoppingCart.ShoppingCartID;
                    modelShoppingCart.UserID = UsersInfo.UserID;
                    modelShoppingCart.CommodityID = modelCommodity.CommodityID;
                    modelShoppingCart.OrderNumber = modelShoppingCart.OrderNumber + 1;

                    if (modelShoppingCart.OrderNumber > modelCommodity.Stock)
                    {
                        RadAjaxManager1.Alert("库存不足!");
                        return;
                    }
                    ShoppingCart_Bll.Update(modelShoppingCart);
                }
                else
                {
                    Maticsoft.Model.Users modelusers = Users_Bll.GetModel(UsersInfo.UserID);
                    decimal discount1;
                    if (modelusers.UserGrade == "VIP")
                    {
                        discount1 = Convert.ToDecimal(0.95);
                    }
                    else
                    {
                        discount1 = Convert.ToDecimal(1);
                    }
                    ShoppingCart_Mol.ShoppingCartID = DateTime.Now.ToString("yyyyMMddhhmmss");
                    ShoppingCart_Mol.UserID = UsersInfo.UserID;
                    ShoppingCart_Mol.CommodityID = CommodityID1;
                    ShoppingCart_Mol.OrderNumber = 1;
                    ShoppingCart_Mol.Subtotal = ((ShoppingCart_Mol.OrderNumber * modelCommodity.VIPPrice)*discount1).ToString();
                    ShoppingCart_Bll.Add(ShoppingCart_Mol);
                }
                RadAjaxManager1.Alert("已添加到购物车!");
            }
        }

        protected void RadLV_splb_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            RadLV_splb.DataSource = Commodity_Bll.GetList4("a.CommodityID = b.CommodityID and b.UserID='" + UsersInfo.UserID + "'");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void RadLV_splb_PageIndexChanged(object sender, Telerik.Web.UI.RadListViewPageChangedEventArgs e)
        {
            RadLV_splb.Rebind();
        }

        protected void RadLV_splb_ItemDataBound(object sender, Telerik.Web.UI.RadListViewItemEventArgs e)
        {
            string id = e.Item.OwnerListView.DataKeyValues[e.Item.OwnerListView.DataKeyValues.Count - 1]["AppriseID"].ToString();
            LinkButton LinkButton1 = e.Item.FindControl("LinkButton1") as LinkButton;
            if (LinkButton1 != null)
            {
                Appraise_Mol = Appraise_Bll.GetModel(id);
                Commodity_Mol = Commodity_Bll.GetModel(Appraise_Mol.CommodityID);
                if (Commodity_Mol.Stock == 0 || Commodity_Mol.CommodityState == "下架")
                {
                    LinkButton1.Visible = false;
                }
            }
        }

    }
}