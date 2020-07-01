using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe
{
    public partial class Login : System.Web.UI.Page
    {
        Maticsoft.BLL.Users User_Bll = new Maticsoft.BLL.Users();
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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = "^[a-zA-Z0-9_]+$";
            Regex rxusername = new Regex(username);
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            if (RadTextBox1.Text == "")
            {
                Label1.Text = "账户不能为空";
                Label1.Visible = true;
                return;
            }
            if (RadTextBox3.Text == "")
            {
                Label2.Text = "密码不能为空";
                Label2.Visible = true;
                return;
            }
            if (RadTextBox2.Text == "")
            {
                Label3.Text = "验证码不能为空";
                Label3.Visible = true;
                return;
            }
            if (!rxusername.IsMatch(RadTextBox1.Text))
            {
                Label1.Text = "账户格式错误";
                Label1.Visible = true;
                return;
            }
            if (User_Bll.GetRecordCount(" Username='" + RadTextBox1.Text + "' ") == 0)
            {
                Label1.Text = "该账户不存在";
                Label1.Visible = true;
                return;
            }
            if (!rxusername.IsMatch(RadTextBox3.Text))
            {
                
                Label1.Text = "密码格式错误";
                Label1.Visible = true;
                return;
            }
            if (User_Bll.GetRecordCount(" Username='" + RadTextBox1.Text + "' and UserPassword='" + RadTextBox3.Text + "'") == 0)
            {
                Label2.Text = "密码错误";
                Label2.Visible = true;
                return;
            }
            if (Session["CheckCode"].ToString().ToLower() != RadTextBox2.Text.ToLower() )
            {
                Label3.Text = "验证码错误";
                Label3.Visible = true;
                return;
            }
            
            DataSet ds = User_Bll.GetList(" Username='" + RadTextBox1.Text + "' ");
            
            UsersInfo.UserID = ds.Tables[0].Rows[0]["UserID"].ToString();
            UsersInfo.UserRole = ds.Tables[0].Rows[0]["UserIdentity"].ToString();
            UsersInfo.UserName = ds.Tables[0].Rows[0]["Username"].ToString();
            if (ds.Tables[0].Rows[0]["UserIdentity"].ToString() == "管理员")
            {
                RadAjaxManager1.Alert("该账户无效!");
                RadTextBox1.Text = "";
                RadTextBox2.Text = "";
                RadTextBox3.Text = "";
                return;
            }
            if (ShoppingCar.ShoppingList.Count != 0)
            {
                Users_Mol = User_Bll.GetModel(UsersInfo.UserID);
                decimal discount1;
                if (Users_Mol.UserGrade == "VIP")
                {
                    discount1 = Convert.ToDecimal(0.95);
                }
                else
                {
                    discount1 = Convert.ToDecimal(1);
                }
                    if (ShoppingCar.ShoppingList.Count != 0)//泛型中有数据
                    {
                        int i = 0;
                        foreach (var item in ShoppingCar.ShoppingList)
                        {
                            Commodity_Mol = Commodity_Bll.GetModel(item.CommodityID);
                            if (ShoppingCart_Bll.GetRecordCount(" UserID ='" + UsersInfo.UserID + "' and CommodityID ='" + item.CommodityID + "' ") != 0)
                            {
                                string basketid = ShoppingCart_Bll.GetList(" UserID ='" + UsersInfo.UserID + "' and CommodityID ='" + item.CommodityID + "' ").Tables[0].Rows[0]["ShoppingCartID"].ToString();
                                ShoppingCart_Mol = ShoppingCart_Bll.GetModel(basketid);
                                ShoppingCart_Mol.OrderNumber = ShoppingCart_Mol.OrderNumber + item.OrderNumber;
                                if (ShoppingCart_Mol.OrderNumber > Commodity_Mol.Stock)
                                {
                                    ShoppingCart_Mol.OrderNumber = Commodity_Mol.Stock;
                                }
                                ShoppingCart_Mol.Subtotal = (Convert.ToDecimal(ShoppingCart_Mol.OrderNumber) * Convert.ToDecimal(item.VIPPrice) * discount1).ToString("F2");
                                ShoppingCart_Bll.Update(ShoppingCart_Mol);
                            }
                            else
                            {
                                ShoppingCart_Mol.ShoppingCartID = DateTime.Now.ToString("yyyyMMddHHmmss") + i.ToString();
                                i++;
                                ShoppingCart_Mol.UserID = UsersInfo.UserID;
                                ShoppingCart_Mol.CommodityID = item.CommodityID;
                                ShoppingCart_Mol.OrderNumber = item.OrderNumber;
                                if (ShoppingCart_Mol.OrderNumber > Commodity_Mol.Stock)
                                {
                                    ShoppingCart_Mol.OrderNumber = Commodity_Mol.Stock;
                                }
                                ShoppingCart_Mol.Subtotal = ( item.Subtotal *  discount1).ToString("F2");
                                ShoppingCart_Bll.Add(ShoppingCart_Mol);
                            }
                        }
                        ShoppingCar.ShoppingList.Clear();
                    }
                }
            Response.Redirect("HomePage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ForeManagement/VIP_Regsiter.aspx");
        }
    }
}