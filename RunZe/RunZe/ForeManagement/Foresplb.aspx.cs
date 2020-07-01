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
    public partial class WebForm1 : System.Web.UI.Page
    {
        Maticsoft.BLL.Users Users_Bll = new Maticsoft.BLL.Users();
        Maticsoft.BLL.Commodity Commodity_Bll = new Maticsoft.BLL.Commodity();
        Maticsoft.BLL.CommodityFather CommodityFather_Bll = new Maticsoft.BLL.CommodityFather();
        Maticsoft.BLL.CommoditySon CommoditySon_Bll = new Maticsoft.BLL.CommoditySon();
        Maticsoft.BLL.ShoppingCart ShoppingCart_Bll = new Maticsoft.BLL.ShoppingCart();
        Maticsoft.Model.ShoppingCart ShoppingCart_Mol = new Maticsoft.Model.ShoppingCart();
        static string sqlselect = "";
        public String CommodityFatherID
        {
            get
            { return ViewState["_CommodityFatherID"] == null ? string.Empty : ViewState["_CommodityFatherID"].ToString(); }
            set
            { ViewState["_CommodityFatherID"] = value; }
        }
        public String CommoditySonID
        {
            get
            { return ViewState["_CommoditySonID"] == null ? string.Empty : ViewState["_CommoditySonID"].ToString(); }
            set
            { ViewState["_CommoditySonID"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["search"]))
                {
                    DataLoad();
                }
                else
                {
                    sqlselect = "";
                }
            }
        }

        protected void RadLV_splb_ItemCommand(object sender, Telerik.Web.UI.RadListViewCommandEventArgs e)
        {
            
            if (e.CommandName == "buy")
            {
                string CommodityID1;
                CommodityID1 = e.CommandArgument.ToString();
                decimal discount1 = Convert.ToDecimal(1);
                Maticsoft.Model.Users modelusers = Users_Bll.GetModel(UsersInfo.UserID);
                Maticsoft.Model.Commodity Commoditymol = Commodity_Bll.GetModel(CommodityID1);

                if (UsersInfo.UserID == "")
                {
                    ShoppingItem ShoppingItem = new ShoppingItem();
                    if (ShoppingCar.ShoppingList.Where(x => x.CommodityID == CommodityID1).Count() > 0)//判断是否购买商品
                    {
                        ShoppingItem = ShoppingCar.ShoppingList.Where(x => x.CommodityID == CommodityID1).SingleOrDefault();//获取ID
                        ShoppingItem.CommodityID = CommodityID1;//商品ID
                        ShoppingItem.CommodityImage = Commoditymol.CommodityImage;//商品图片
                        ShoppingItem.CommodityName = Commoditymol.CommodityName;//商品名称
                        ShoppingItem.VIPPrice = Convert.ToDecimal(Commoditymol.VIPPrice);//商品会员价
                        ShoppingItem.OrderNumber = ShoppingItem.OrderNumber + 1;//数量
                        if (ShoppingItem.OrderNumber > Commoditymol.Stock)
                        {
                            ShoppingItem.OrderNumber = Convert.ToInt32(Commoditymol.Stock);
                            RadAjaxManager1.Alert("库存不足!");
                            return;
                        }

                        ShoppingItem.Subtotal = ShoppingItem.OrderNumber * Convert.ToDecimal(Commoditymol.VIPPrice) * discount1;//商品小计
                        ShoppingCar.ShoppingList.Remove(ShoppingCar.ShoppingList.Where(x => x.CommodityID == CommodityID1).SingleOrDefault());//移除
                        ShoppingCar.ShoppingList.Add(ShoppingItem);
                        RadAjaxManager1.Alert("已加入购物车!");
                    }
                    else
                    {

                        ShoppingItem.ShoppingCartID = DateTime.Now.ToString("yyyyMMddHHmmssms");//购物车ID
                        ShoppingItem.CommodityID = CommodityID1;//商品ID
                        ShoppingItem.CommodityImage = Commoditymol.CommodityImage;//商品图片
                        ShoppingItem.CommodityName = Commoditymol.CommodityName;//商品名称
                        ShoppingItem.VIPPrice = Convert.ToDecimal(Commoditymol.VIPPrice);//商品会员价
                        ShoppingItem.OrderNumber = 1;//商品数量
                        if (ShoppingItem.OrderNumber > Commoditymol.Stock)
                        {
                            RadAjaxManager1.Alert("库存不足!");
                            return;
                        }
                        ShoppingItem.Subtotal = Convert.ToDecimal(Commoditymol.VIPPrice) * discount1;//商品小计
                        ShoppingCar.ShoppingList.Add(ShoppingItem);//添加
                        RadAjaxManager1.Alert("添加成功！");
                        return;

                    }

                }
                else if (ShoppingCart_Bll.GetRecordCount(" CommodityID='" + CommodityID1 + "' and UserID='" + UsersInfo.UserID + "' ") > 0)
                {
                    if (modelusers.UserGrade == "VIP")
                    {
                        discount1 = Convert.ToDecimal(0.95);
                    }
                    else
                    {
                        discount1 = Convert.ToDecimal(1);
                    }
                    Maticsoft.Model.Commodity modelCommodity = Commodity_Bll.GetModel(CommodityID1);
                    string id = ShoppingCart_Bll.GetList(" CommodityID='" + CommodityID1 + "' and UserID='" + UsersInfo.UserID + "' ").Tables[0].Rows[0]["ShoppingCartID"].ToString();
                    ShoppingCart_Mol = ShoppingCart_Bll.GetModel(id);
                    ShoppingCart_Mol.ShoppingCartID = ShoppingCart_Mol.ShoppingCartID;
                    ShoppingCart_Mol.UserID = UsersInfo.UserID;
                    ShoppingCart_Mol.CommodityID = modelCommodity.CommodityID;
                    ShoppingCart_Mol.OrderNumber = ShoppingCart_Mol.OrderNumber + 1;
                    ShoppingCart_Mol.Subtotal = (Convert.ToInt32(modelCommodity.VIPPrice) * discount1).ToString();//商品小计

                    if (ShoppingCart_Mol.OrderNumber > modelCommodity.Stock)
                    {
                        Response.Write("<script>alert('库存不足!')</script>");
                        return;
                    }
                    ShoppingCart_Bll.Update(ShoppingCart_Mol);
                    Response.Write("<script>alert('已添加到购物车!')</script>");
                }                    
                else
                {
                    Maticsoft.Model.Commodity modelCommodity = Commodity_Bll.GetModel(CommodityID1);
                    ShoppingCart_Mol.ShoppingCartID = DateTime.Now.ToString("yyyyMMddhhmmss");
                    ShoppingCart_Mol.UserID = UsersInfo.UserID;
                    ShoppingCart_Mol.CommodityID = e.CommandArgument.ToString();
                    ShoppingCart_Mol.OrderNumber = 1;
                    ShoppingCart_Mol.Subtotal = (1 * Convert.ToInt32(modelCommodity.VIPPrice) * discount1).ToString();//商品小计
                    ShoppingCart_Bll.Add(ShoppingCart_Mol);
                    Response.Write("<script>alert('已添加到购物车!')</script>");
                }
            }
        }

        protected void RadLV_splb_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            RadLV_splb.DataSource = Commodity_Bll.GetList(sqlselect);
        }


        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void RadLV_splb_PageIndexChanged(object sender, Telerik.Web.UI.RadListViewPageChangedEventArgs e)
        {
            //RadLV_splb.Rebind();
        }

        protected void RadLV_Son_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            //RadLV_Son.DataSource = CommoditySon_Bll.GetList("");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void DataLoad()
        {
            sqlselect = "";
            sqlselect += "  CommodityState = '上架' ";
            if (Request.QueryString["search"] != null)
            {
                if (!string.IsNullOrEmpty(sqlselect))
                {
                    sqlselect += " and ";
                }
                sqlselect += " CommodityName like '%" + Request.QueryString["search"] + "%' ";

                if (!string.IsNullOrEmpty(Request.QueryString["search"]))
                {
                    RadLV_splb.Rebind();
                }
            }
            if (Request.QueryString["search1"] != null)
            {
                if (!string.IsNullOrEmpty(sqlselect))
                {
                    sqlselect += " and ";
                }
                sqlselect = " CommoditySonID = '" + Request.QueryString["search1"] + "' ";

                if (!string.IsNullOrEmpty(Request.QueryString["search1"]))
                {
                    RadLV_splb.Rebind();
                }
            }

            if (Request.QueryString["search2"] != null)
            {
                if (!string.IsNullOrEmpty(sqlselect))
                {
                    sqlselect += " and ";
                }
                sqlselect = " CommodityFatherID = '" + Request.QueryString["search2"] + "' ";

                if (!string.IsNullOrEmpty(Request.QueryString["search2"]))
                {
                    RadLV_splb.Rebind();
                }

            }
            


        }

        protected void RadLV_Son_ItemCommand(object sender, Telerik.Web.UI.RadListViewCommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            RadLV_splb.DataSource = Commodity_Bll.GetList(0, " CommoditySonID='" + e.CommandArgument + "'", "CommodityTime desc");
            if (Commodity_Bll.GetList(0, " CommoditySonID='" + e.CommandArgument + "'", "CommodityTime desc").Tables[0].Rows.Count != 0)
            {
                RadDataPager_1.Visible = true;
            }
            else
            {
                RadDataPager_1.Visible = false;
            }
            if (Commodity_Bll.GetList(0, " CommoditySonID='" + e.CommandArgument + "'", "CommodityTime desc").Tables[0].Rows.Count < 20)
            {
                RadDataPager_1.Visible = false;
            }
        }

        protected void RadLV_Father_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            RadLV_Father.DataSource = CommodityFather_Bll.GetList2("");
            DataLoad();
        }


        protected void RadLV_Father_ItemCommand(object sender, Telerik.Web.UI.RadListViewCommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            RadLV_splb.DataSource = Commodity_Bll.GetList(0, " CommodityFatherID='" + e.CommandArgument + "'", "CommodityTime desc");
           
        }

        protected void RadLV_Father_ItemDataBound(object sender, Telerik.Web.UI.RadListViewItemEventArgs e)
        {
            Telerik.Web.UI.RadListView RadLV_Son = e.Item.FindControl("RadLV_Son") as Telerik.Web.UI.RadListView;
            if (RadLV_Son != null)
            {
                RadLV_Son.DataSource = CommoditySon_Bll.GetList(" CommodityFatherID='" + e.Item.OwnerListView.DataKeyValues[e.Item.OwnerListView.DataKeyValues.Count - 1]["CommodityFatherID"].ToString() + "' ");
                RadLV_Son.DataBind();
            }
        }

        protected void RadButton1_Click(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {

        }
    }
}