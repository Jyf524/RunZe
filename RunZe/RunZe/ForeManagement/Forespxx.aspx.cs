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
    public partial class Forespxx : System.Web.UI.Page
    {
        Maticsoft.BLL.Users Users_Bll = new Maticsoft.BLL.Users();
        Maticsoft.BLL.Commodity Commodity_Bll = new Maticsoft.BLL.Commodity();
        Maticsoft.Model.Commodity Commodity_Mol = new Maticsoft.Model.Commodity();
        Maticsoft.BLL.Appraise Appraise_Bll = new Maticsoft.BLL.Appraise();
        Maticsoft.Model.Appraise Appraise_Mol = new Maticsoft.Model.Appraise();
        Maticsoft.BLL.ShoppingCart ShoppingCart_Bll = new Maticsoft.BLL.ShoppingCart();
        Maticsoft.Model.ShoppingCart ShoppingCart_Mol = new Maticsoft.Model.ShoppingCart();
        Maticsoft.BLL.OrderDetail OrderDetail_Bll = new Maticsoft.BLL.OrderDetail();
        Maticsoft.Model.OrderDetail OrderDetail_Mol = new Maticsoft.Model.OrderDetail();
        public int num;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                num = 1;
                Commoditynum.Text = num.ToString();
                if (!String.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    Maticsoft.Model.Commodity modelnew = Commodity_Bll.GetModel(Request.QueryString["ID"].ToString());//引用id所在行的数据
                    Image1.ImageUrl = modelnew.CommodityImage;
                    Label1.Text = modelnew.CommodityName;
                    Label2.Text = modelnew.CommodityType;
                    Label3.Text = modelnew.MarketPrice.ToString();
                    Label4.Text = modelnew.VIPPrice.ToString();
                    Label6.Text = modelnew.CommoditySaled.ToString();
                    Label7.Text = modelnew.Stock.ToString();
                    Label8.Text = modelnew.Introduce;
                    Label5.Text = modelnew.CommodityState;
                    pinfen();
                    if (Appraise_Bll.GetRecordCount(" CommodityID='" + Request.QueryString["ID"] + "' and UserID='" + UsersInfo.UserID + "' ") > 0)
                    {
                        ImageButton1.ImageUrl = "~/image/star.png";
                    }
                    else
                    {
                        ImageButton1.ImageUrl = "~/image/kstar.png";
                    }
                    if (Label8.Text != "")
                    {
                        Label8.Visible = true;
                    }
                    if (modelnew.Stock == 0)
                    {
                        Commoditynum.Visible = false;
                        Button1.Visible = false;
                        Btn_add.Visible = false;
                        Btn_jian.Visible = false;
                    }
                }

                else
                {
                    Response.Redirect("Foresplb.aspx");
                }
            }
        }


        protected void pinfen()
        {
            lbl_pf.Text = OrderDetail_Bll.GetList2(" CommodityID='" + Request.QueryString["ID"].ToString() + "' ").Tables[0].Rows[0]["AVGAppraiseGrade"].ToString();
            if (OrderDetail_Bll.GetList2(" CommodityID='" + Request.QueryString["ID"].ToString() + "' ").Tables[0].Rows[0]["AVGAppraiseGrade"].ToString() == "")
            {
                lbl_pf.Text = "暂无";
            }
            if (OrderDetail_Bll.GetRecordCount2(" and a.CommodityID='" + Request.QueryString["ID"].ToString() + "' and a.UserID='" + UsersInfo.UserID + "'and a.AppraiseGrade is null  and b.OrderState='完成' ") == 0)
            {
                content_main_left_score2.Visible = false;
            }
            else
            {
                content_main_left_score2.Visible = true;
            }
        }

        protected void Btn_jian_Click(object sender, EventArgs e)
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
        }

        protected void Btn_add_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(Commoditynum.Text);
            if (num < Convert.ToInt32(Label7.Text))
            {
                num++;
                Commoditynum.Text = num.ToString();
                return;
            }
            else
            {
                num--;
            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (UsersInfo.UserID == "")
            {
                Response.Write("<script> alert('请先登录！'); window.location.href='../Login.aspx' </script>");
                return;
            }
           
            else
            {
                Maticsoft.Model.Commodity modelnew = Commodity_Bll.GetModel(Request.QueryString["ID"].ToString());
                Appraise_Mol.AppriseID = DateTime.Now.ToString("yyyyMMddhhmmss");
                Appraise_Mol.CommodityID = modelnew.CommodityID;
                Appraise_Mol.UserID = UsersInfo.UserID;
                if (Appraise_Bll.GetRecordCount(" CommodityID='" + Request.QueryString["ID"] + "' and UserID='" + UsersInfo.UserID + "' ") > 0)
                {
                    Appraise_Bll.Delete(Appraise_Bll.GetList(" CommodityID='" + Request.QueryString["ID"] + "' and UserID='" + UsersInfo.UserID + "' ").Tables[0].Rows[0]["AppriseID"].ToString());
                    ImageButton1.ImageUrl = "~/image/kstar.png";
                }
                else
                {
                    Appraise_Bll.Add(Appraise_Mol);
                    ImageButton1.ImageUrl = "~/image/star.png";
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (UsersInfo.UserID == "")
            //{
            //    Response.Write("<script> alert('请先登录！'); window.location.href='../Login.aspx' </script>");
            //    return;
            //}

            decimal discount;

            Commodity_Mol = Commodity_Bll.GetModel(Request.QueryString["ID"].ToString());
            if (UsersInfo.UserID == "")
            {
                discount = Convert.ToDecimal(1);
                ShoppingItem ShoppingItem = new ShoppingItem();
                if (ShoppingCar.ShoppingList.Where(x => x.CommodityID == Request.QueryString["ID"].ToString()).Count() > 0)//判断是否购买商品
                {
                    ShoppingItem = ShoppingCar.ShoppingList.Where(x => x.CommodityID == Request.QueryString["ID"].ToString()).SingleOrDefault();//获取ID
                    if (Commoditynum.Text == "")
                    {
                        RadAjaxManager1.Alert("请输入数量!");
                        return;
                    }
                    int goodsnum = ShoppingItem.OrderNumber + Convert.ToInt32(Commoditynum.Text);//数量
                    if (goodsnum > Commodity_Mol.Stock)
                    {
                        RadAjaxManager1.Alert("库存不足!");
                        return;
                    }
                    ShoppingItem.CommodityID = Request.QueryString["ID"].ToString();//商品ID
                    ShoppingItem.CommodityImage = Commodity_Mol.CommodityImage;//商品图片
                    ShoppingItem.CommodityName = Commodity_Mol.CommodityName;//商品名称
                    ShoppingItem.VIPPrice = Convert.ToDecimal(Commodity_Mol.VIPPrice);//商品会员价
                    ShoppingItem.Subtotal = goodsnum * Convert.ToDecimal(Commodity_Mol.VIPPrice) * discount;//商品小计
                    //ShoppingCar.ShoppingList.Remove(ShoppingCar.ShoppingList.Where(x => x.CommodityID == Request.QueryString["ID"].ToString()).SingleOrDefault());//移除
                    //ShoppingCar.ShoppingList.Add(ShoppingItem);
                    RadAjaxManager1.Alert("已加入购物车!");
                }
                else
                {
                    discount = Convert.ToDecimal(1);
                    ShoppingItem.ShoppingCartID = DateTime.Now.ToString("yyyyMMddHHmmssms");//购物车ID
                    if (Commoditynum.Text == "")
                    {
                        RadAjaxManager1.Alert("请输入数量!");
                        return;
                    }
                    ShoppingItem.OrderNumber = Convert.ToInt32(Commoditynum.Text);//购物车数量
                    if (ShoppingItem.OrderNumber > Commodity_Mol.Stock)
                    {
                        RadAjaxManager1.Alert("库存不足!");
                        return;
                    }
                    ShoppingItem.CommodityID = Request.QueryString["ID"].ToString();//商品ID
                    ShoppingItem.CommodityImage = Commodity_Mol.CommodityImage;//商品图片
                    ShoppingItem.CommodityName = Commodity_Mol.CommodityName;//商品名称
                    ShoppingItem.VIPPrice = Convert.ToDecimal(Commodity_Mol.VIPPrice);//商品会员价
                    ShoppingItem.Subtotal = Convert.ToDecimal(Commoditynum.Text) * Convert.ToDecimal(Commodity_Mol.VIPPrice) * discount;//商品小计
                    ShoppingCar.ShoppingList.Add(ShoppingItem);//添加
                    RadAjaxManager1.Alert("添加成功！");
                    return;
                }
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
                if (num > Convert.ToInt32(Label7.Text))
                {
                    RadAjaxManager1.Alert("数量不能超过库存!");
                    return;
                }
                if (ShoppingCart_Bll.GetRecordCount(" CommodityID='" + Request.QueryString["ID"] + "' and UserID='" + UsersInfo.UserID + "' ") > 0)
                {
                    Maticsoft.Model.Commodity modelCommodity = Commodity_Bll.GetModel(Request.QueryString["ID"].ToString());
                    Maticsoft.Model.ShoppingCart modelShoppingCart = ShoppingCart_Bll.GetModel(Request.QueryString["ID"].ToString());
                    string id = ShoppingCart_Bll.GetList(" CommodityID='" + Request.QueryString["ID"] + "' and UserID='" + UsersInfo.UserID + "' ").Tables[0].Rows[0]["ShoppingCartID"].ToString();
                    ShoppingCart_Mol = ShoppingCart_Bll.GetModel(id);
                    ShoppingCart_Mol.ShoppingCartID = ShoppingCart_Mol.ShoppingCartID;
                    ShoppingCart_Mol.UserID = UsersInfo.UserID;
                    ShoppingCart_Mol.CommodityID = modelCommodity.CommodityID;
                    if (Commoditynum.Text == "")
                    {
                        RadAjaxManager1.Alert("请输入数量!");
                        return;
                    }


                    ShoppingCart_Mol.OrderNumber = Convert.ToInt32(Commoditynum.Text) + ShoppingCart_Mol.OrderNumber;

                    if (ShoppingCart_Mol.OrderNumber > modelCommodity.Stock)
                    {
                        RadAjaxManager1.Alert("库存不足!");
                        return;
                    }

                    ShoppingCart_Mol.Subtotal = (ShoppingCart_Mol.OrderNumber * Convert.ToInt32(modelCommodity.VIPPrice) * discount1).ToString();//商品小计

                    ShoppingCart_Bll.Update(ShoppingCart_Mol);
                }
                else
                {
                    Maticsoft.Model.Commodity modelCommodity = Commodity_Bll.GetModel(Request.QueryString["ID"].ToString());
                    ShoppingCart_Mol.ShoppingCartID = DateTime.Now.ToString("yyyyMMddhhmmss");
                    ShoppingCart_Mol.UserID = UsersInfo.UserID;
                    ShoppingCart_Mol.CommodityID = Request.QueryString["ID"];
                    ShoppingCart_Mol.OrderNumber = Convert.ToInt32(Commoditynum.Text);
                    ShoppingCart_Mol.Subtotal = (Convert.ToInt32(Commoditynum.Text) * Convert.ToInt32(modelCommodity.VIPPrice) * discount1).ToString();//商品小计
                    ShoppingCart_Mol.OrderNumber = Convert.ToInt32(Commoditynum.Text);

                    if (ShoppingCart_Mol.OrderNumber > modelCommodity.Stock)
                    {
                        RadAjaxManager1.Alert("库存不足!");
                        return;
                    }
                    ShoppingCart_Bll.Add(ShoppingCart_Mol);

                }
                RadAjaxManager1.Alert("已添加到购物车!");
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (UsersInfo.UserID == "")
            {
                Response.Write("<script> alert('请先登录！'); window.location.href='../Login.aspx' </script>");
                return;
            }
            if (OrderDetail_Bll.GetRecordCount(" CommodityID='" + Request.QueryString["ID"].ToString() + "' and UserID='" + UsersInfo.UserID + "' ") <= 0)
            {
                RadRating1.Visible = false;
                Button2.Visible = false;
            }
            else
            {
                try
                {
                    string OrdersDetailedid = OrderDetail_Bll.GetList(" CommodityID='" + Request.QueryString["ID"].ToString() + "' and UserID='" + UsersInfo.UserID + "'and AppraiseGrade is null ").Tables[0].Rows[0]["OrderDetailID"].ToString();
                    Maticsoft.Model.OrderDetail molorderdetail = OrderDetail_Bll.GetModel(OrdersDetailedid);
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('已经评过分，请刷新后重试!')</script>");
                    if (OrderDetail_Bll.GetRecordCount(" CommodityID='" + Request.QueryString["ID"].ToString() + "' and UserID='" + UsersInfo.UserID + "' ") > 0)
                    {
                        RadRating1.Visible = false;
                        Button2.Visible = false;
                    }
                    return;

                }
                string OrdersDetailedid1 = OrderDetail_Bll.GetList(" CommodityID='" + Request.QueryString["ID"].ToString() + "' and UserID='" + UsersInfo.UserID + "'and AppraiseGrade is null ").Tables[0].Rows[0]["OrderDetailID"].ToString();
                Maticsoft.Model.OrderDetail molorderdetail1 = OrderDetail_Bll.GetModel(OrdersDetailedid1);
                if (RadRating1.Value == 0)
                {
                    Response.Write("<script>alert('请评分!')</script>");
                    return;
                }
                if (RadRating1.Value == 1)
                {
                    molorderdetail1.AppraiseGrade = 40;
                }
                if (RadRating1.Value == 2)
                {
                    molorderdetail1.AppraiseGrade = 60;
                }
                if (RadRating1.Value == 3)
                {
                    molorderdetail1.AppraiseGrade = 80;
                }
                if (RadRating1.Value == 4)
                {
                    molorderdetail1.AppraiseGrade = 100;
                }
                OrderDetail_Bll.Update(molorderdetail1);
                pinfen();
                RadAjaxManager1.Alert("评分成功!");
                if (OrderDetail_Bll.GetRecordCount(" CommodityID='" + Request.QueryString["ID"].ToString() + "' and UserID='" + UsersInfo.UserID + "' ") > 0)
                {
                    RadRating1.Visible = false;
                    Button2.Visible = false;
                }
            }
        }
    }
}