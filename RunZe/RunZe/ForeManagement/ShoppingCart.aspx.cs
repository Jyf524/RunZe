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
    public partial class ShoppingCart : System.Web.UI.Page
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
        public int num;
        protected void Page_Load(object sender, EventArgs e)
        {
            hidden();
            string UserID1;
            if (UsersInfo.UserID != "")
            {
                UserID1 = UsersInfo.UserID;
                Maticsoft.Model.Users modelUsers = Users_Bll.GetModel(UserID1);
                if (modelUsers.UserGrade == "VIP")
                {
                    Lbl_discount.Text = "0.95";
                }
                if (modelUsers.UserGrade == "会员")
                {
                    Lbl_discount.Text = "1";
                }
            }
            else
            {
                Lbl_discount.Text = "1";
            }


        }

        protected void hidden()
        {
            if (UsersInfo.UserID != "")
            {
                if (ShoppingCart_Bll.GetRecordCount2(" a.CommodityID = b.CommodityID and a.UserID='" + UsersInfo.UserID + "' ") > 5)
                {
                    RadDataPager1.Visible = true;
                }
                else
                {
                    RadDataPager1.Visible = false;
                }
                if (ShoppingCart_Bll.GetRecordCount3("a.CommodityID = b.CommodityID and a.UserID='" + UsersInfo.UserID + "'") == 0)
                {
                    content_buy.Visible = false;
                }
            }
            else
            {
                if (ShoppingCar.ShoppingList.Count == 0)
                {
                    content_buy.Visible = false;
                }
                else
                {
                    content_buy.Visible = true;
                }

                if (ShoppingCar.ShoppingList.Count > 5)
                {
                    RadDataPager1.Visible = true;
                }
                else
                {
                    RadDataPager1.Visible = false;
                }
            }

        }

        protected void RadListView1_ItemCommand(object sender, Telerik.Web.UI.RadListViewCommandEventArgs e)
        {
            string ShoppingCartID1;
            ShoppingCartID1 = e.CommandArgument.ToString();
            Telerik.Web.UI.RadNumericTextBox Commoditynum = e.ListViewItem.FindControl("Commoditynum") as Telerik.Web.UI.RadNumericTextBox;
            Maticsoft.Model.ShoppingCart modelShoppingCart = ShoppingCart_Bll.GetModel(ShoppingCartID1);
            Maticsoft.Model.Users modelUsers = Users_Bll.GetModel(UsersInfo.UserID);
            if (e.CommandName == "Delete")
            {
                if (UsersInfo.UserID != "")
                {
                    ShoppingCart_Bll.DeleteList(e.CommandArgument.ToString());
                    RadListView1.Rebind();//删除
                    if (ShoppingCart_Bll.GetRecordCount3("a.CommodityID = b.CommodityID and a.UserID='" + UsersInfo.UserID + "'") == 0)
                    {
                        content_buy.Visible = false;
                    }
                }
                else
                {
                    string id = e.CommandArgument.ToString();
                    ShoppingItem si = new ShoppingItem();
                    si = ShoppingCar.ShoppingList.Where(x => x.CommodityID == id).SingleOrDefault();

                    ShoppingCar.ShoppingList.Remove(ShoppingCar.ShoppingList.Where(x => x.ShoppingCartID == id).SingleOrDefault());
                    ShoppingItem jsnum = new ShoppingItem();
                    decimal zongji = 0;
                    foreach (var item in ShoppingCar.ShoppingList)
                    {

                        zongji += item.Subtotal;
                        Lbl_totalprice.Text = zongji.ToString();
                    }
                    hidden();
                    RadListView1.Rebind();//刷新                
                }
            }
            if (e.CommandName == "Add")
            {
                string CommodityID1;
                CommodityID1 = e.CommandArgument.ToString();
                Maticsoft.Model.Commodity modelCommodity = Commodity_Bll.GetModel(CommodityID1);
                num = Convert.ToInt32(Commoditynum.Text);
                if (num < Convert.ToInt32(modelCommodity.Stock))
                {
                    num++;
                    Commoditynum.Text = num.ToString();

                }
                else
                {
                    Commoditynum.Text = num.ToString();
                }
                if (UsersInfo.UserID != "")
                {
                    string CommodityID2;
                    CommodityID2 = e.CommandArgument.ToString();
                    
                    string ShoppingCartID2 = ShoppingCart_Bll.GetList(" CommodityID='" + CommodityID2 + "' and UserID='" + UsersInfo.UserID + "' ").Tables[0].Rows[0]["ShoppingCartID"].ToString();
                    Maticsoft.Model.Commodity modelCommodity2 = Commodity_Bll.GetModel(CommodityID2);
                    modelCommodity2 = Commodity_Bll.GetModel(CommodityID2);
                    modelUsers = Users_Bll.GetModel(UsersInfo.UserID);
                    decimal discount1;
                    if (modelUsers.UserGrade == "VIP")
                    {
                        discount1 = Convert.ToDecimal(0.95);
                    }
                    else
                    {
                        discount1 = Convert.ToDecimal(1);
                    }
                    modelShoppingCart = ShoppingCart_Bll.GetModel(ShoppingCartID2);//获取id所在行数据
                    modelShoppingCart.OrderNumber = Convert.ToInt32(Commoditynum.Text);//商品数量
                    modelShoppingCart.Subtotal = (Convert.ToInt32(Commoditynum.Text) * Convert.ToInt32(modelCommodity2.VIPPrice) * discount1).ToString();//商品小计
                    ShoppingCart_Bll.Update(modelShoppingCart);
                    RadListView1.Rebind();
                }
                else
                {
                    string CommodityID3;
                    CommodityID3 = e.CommandArgument.ToString();
                    ShoppingItem si = new ShoppingItem();
                    si = ShoppingCar.ShoppingList.Where(x => x.CommodityID == CommodityID3).First();
                    Commodity_Mol = Commodity_Bll.GetModel(si.CommodityID);
                    if (si.OrderNumber + 1 <= Commodity_Mol.Stock)
                    {
                        int num1 = si.OrderNumber + 1;
                        si.OrderNumber = num1;
                        Decimal b = num * Convert.ToDecimal(Commodity_Mol.VIPPrice) * 1;
                        si.Subtotal = b;
                        ShoppingCar.ShoppingList.Remove(ShoppingCar.ShoppingList.Where(x => x.CommodityID == CommodityID3).SingleOrDefault());
                        ShoppingCar.ShoppingList.Add(si);
                        ShoppingItem jsnum = new ShoppingItem();
                        decimal zongji = 0;
                        foreach (var item in ShoppingCar.ShoppingList)
                        {

                            zongji += item.Subtotal;
                            Lbl_totalprice.Text = zongji.ToString();
                        }
                        RadListView1.Rebind();
                    }
                    else
                    {
                        RadAjaxManager1.Alert("已经最大了");
                    }
                }

            }
            if (e.CommandName == "Jian")
            {
                num = Convert.ToInt32(Commoditynum.Text);
                if (num <= 0)
                {
                    num = 1;
                }
                else
                {
                    num--;
                }
                Commoditynum.Text = num.ToString();

                if (UsersInfo.UserID != "")
                {
                    string CommodityID2;
                    CommodityID2 = e.CommandArgument.ToString();
                    string ShoppingCartID2 = ShoppingCart_Bll.GetList(" CommodityID='" + CommodityID2 + "' and UserID='" + UsersInfo.UserID + "' ").Tables[0].Rows[0]["ShoppingCartID"].ToString();
                    Maticsoft.Model.Commodity modelCommodity2 = Commodity_Bll.GetModel(CommodityID2);
                    modelCommodity2 = Commodity_Bll.GetModel(CommodityID2);
                    modelUsers = Users_Bll.GetModel(UsersInfo.UserID);
                    decimal discount1;
                    if (modelUsers.UserGrade == "VIP")
                    {
                        discount1 = Convert.ToDecimal(0.95);
                    }
                    else
                    {
                        discount1 = Convert.ToDecimal(1);
                    }
                    modelShoppingCart = ShoppingCart_Bll.GetModel(ShoppingCartID2);//获取id所在行数据
                    modelShoppingCart.OrderNumber = Convert.ToInt32(Commoditynum.Text);//商品数量
                    modelShoppingCart.Subtotal = (Convert.ToInt32(Commoditynum.Text) * Convert.ToInt32(modelCommodity2.VIPPrice) * discount1).ToString();//商品小计
                    ShoppingCart_Bll.Update(modelShoppingCart);
                    RadListView1.Rebind();
                }
                else
                {
                    string id = e.CommandArgument.ToString();
                    ShoppingItem si = new ShoppingItem();
                    si = ShoppingCar.ShoppingList.Where(x => x.CommodityID == id).First();
                    if (si.OrderNumber > 1)
                    {
                        int num1 = si.OrderNumber - 1;
                        si.OrderNumber = num1;
                        Commodity_Mol = Commodity_Bll.GetModel(si.CommodityID);
                        Decimal b = num * Convert.ToDecimal(Commodity_Mol.VIPPrice) * 1;
                        si.Subtotal = b;
                        ShoppingCar.ShoppingList.Remove(ShoppingCar.ShoppingList.Where(x => x.CommodityID == id).SingleOrDefault());
                        ShoppingCar.ShoppingList.Add(si);
                        ShoppingItem jsnum = new ShoppingItem();
                        decimal zongji = 0;
                        foreach (var item in ShoppingCar.ShoppingList)
                        {

                            zongji += item.Subtotal;
                            Lbl_totalprice.Text = zongji.ToString();
                        }
                        RadListView1.Rebind();
                    }
                    else
                    {
                        RadAjaxManager1.Alert("已经最小了");
                    }
                }
            }
        }

        protected void RadListView1_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            if (UsersInfo.UserID == "")
            {
                RadListView1.DataSource = ShoppingCar.ShoppingList.OrderBy(x => x.ShoppingCartID);
                decimal sum = 0;
                foreach (var item in ShoppingCar.ShoppingList)
                {
                    sum = sum + Convert.ToDecimal(item.Subtotal);
                }
                Lbl_totalprice.Text = sum.ToString();
            }
            else
            {
                RadListView1.DataSource = ShoppingCart_Bll.GetList2("a.CommodityID = b.CommodityID and a.UserID='" + UsersInfo.UserID + "'");
                Lbl_totalprice.Text = ShoppingCart_Bll.GetList3("UserID='" + UsersInfo.UserID + "'").Tables[0].Rows[0][0].ToString();
            }
        }

        protected void RadListView1_PageIndexChanged(object sender, Telerik.Web.UI.RadListViewPageChangedEventArgs e)
        {

        }

        protected void Linkbtn_delete_all_word_Click(object sender, EventArgs e)
        {
            if (UsersInfo.UserID != "")
            {
                ShoppingCart_Bll.DeleteList2(UsersInfo.UserID);
                RadListView1.Rebind();
                hidden();
            }
            else
            {
                ShoppingCar.ShoppingList.Clear();
                RadListView1.Rebind();
                hidden();
            }

        }

        protected void Linkbtn_buyall_word_Click(object sender, EventArgs e)
        {
            Maticsoft.Model.Users modelUsers = Users_Bll.GetModel(UsersInfo.UserID);
            Maticsoft.Model.Orders modelOrders = new Maticsoft.Model.Orders();
            Maticsoft.Model.OrderDetail modelOrderDetail = new Maticsoft.Model.OrderDetail();

            if (UsersInfo.UserID != "")
            {
                DataSet dsbasket = new DataSet();
                dsbasket = ShoppingCart_Bll.GetList(" UserID ='" + UsersInfo.UserID + "' ");
                foreach (DataRow drbasket in dsbasket.Tables[0].Rows)
                {
                    Commodity_Mol = Commodity_Bll.GetModel(drbasket["CommodityID"].ToString());
                    if (Convert.ToInt32(drbasket["OrderNumber"]) >= Commodity_Mol.Stock)
                    {
                        RadAjaxManager1.Alert("库存不足!");
                        return;
                    }
                }

                if (modelUsers.UserRealName == "" && modelUsers.Address1 == "")
                {
                    Response.Write("<script> alert('请完善个人信息！'); window.location.href='ForeVIP.aspx' </script>");
                }
                else
                {

                    modelOrders.OrderID = DateTime.Now.ToString("yyyyMMddHHmmss");//订单号

                    modelOrders.UserID = UsersInfo.UserID;//用户ID
                    modelOrders.OrderDate = DateTime.Now;//下单时间
                    modelOrders.OrderState = "待付款";
                    modelOrders.TotalMoney = Convert.ToDecimal(Lbl_totalprice.Text);//总金额

                    modelOrders.AddresseeName = modelUsers.UserRealName;
                    modelOrders.AddresseePhone = modelUsers.Phone;
                    modelOrders.AddresseeAddress = modelUsers.Province + modelUsers.City + modelUsers.Address1;

                    Orders_Bll.Add(modelOrders); //订单表

                    DataSet ds = new DataSet();
                    ds = ShoppingCart_Bll.GetList(" UserID='" + UsersInfo.UserID + "' ");
                    string id = DateTime.Now.ToString("yyyyMMddHHmmss");
                    int i = 0;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        i++;
                        modelOrderDetail.OrderDetailID = id + i.ToString();
                        modelOrderDetail.OrderID = modelOrders.OrderID;
                        modelOrderDetail.UserID = UsersInfo.UserID;
                        modelOrderDetail.CommodityID = dr["CommodityID"].ToString();
                        modelOrderDetail.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
                        modelOrderDetail.Subtotal = dr["Subtotal"].ToString();
                        OrderDetail_Bll.Add(modelOrderDetail);
                        Commodity_Mol = Commodity_Bll.GetModel(dr["CommodityID"].ToString());
                        if (ShoppingCart_Mol.OrderNumber > Commodity_Mol.Stock)
                        {
                            RadAjaxManager1.Alert("库存不足!");
                            return;
                        }
                        Commodity_Mol.Stock = Commodity_Mol.Stock - Convert.ToInt32(dr["OrderNumber"]);


                        if (Commodity_Mol.Stock <= 0)
                        {
                            Commodity_Mol.CommodityState = "下架";
                        }

                        Commodity_Bll.Update(Commodity_Mol);
                    }



                    ShoppingCart_Bll.DeleteList2(UsersInfo.UserID);
                    hidden();
                    RadListView1.Rebind();
                    Response.Write("<script> alert('下单成功！'); window.location.href='ForeOrdersDetail.aspx?OrderID=" + modelOrders.OrderID + "' </script>");
                }
            }
            else
            {
                Response.Write("<script> alert('请先登陆！'); window.location.href='/Login.aspx' </script>");
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_jian_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_add_Click(object sender, EventArgs e)
        {

        }

        protected void Linkbtn_continue_word_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HomePage.aspx");
        }




    }
}