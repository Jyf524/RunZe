using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.BackManagement
{
    public partial class Backddgl : System.Web.UI.Page
    {
        Maticsoft.BLL.Orders Order_DLL = new Maticsoft.BLL.Orders();
        string sqlstring = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            if (!IsPostBack)
            {
                Session["sqlselect"] = "";
            }
            if (UsersInfo.UserID == "")
            {
                Response.Write("<script> alert('请先登录！'); window.location.href='/BackLogin.aspx' </script>");
                return;
            }
            Button1.Attributes["onclick"] = "OpenEdit();return false;";//添加
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            sqlstring = Session["sqlselect"].ToString();
            RadGrid1.DataSource = Order_DLL.GetList(sqlstring);
        }

        protected void RadGrid1_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "Delete")//删除数据
            {
                Order_DLL.Delete(e.CommandArgument.ToString());
                RadGrid1.Rebind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (RadTextBox1.Text != "")
            {
                Session["sqlselect"] = " OrderID like '%" + RadTextBox1.Text + "%' ";
            }
            else if(RadDropDownList1.SelectedValue == "1")
            {

            }

            else if (RadDropDownList1.SelectedValue == "2")
            {
                if (Session["sqlselect"] != "")
                {
                    Session["sqlselect"] += " and ";
                }
                Session["sqlselect"] = " OrderState='" + RadDropDownList1.SelectedText + "' ";
            }

            else if (RadDropDownList1.SelectedValue == "3")
            {
                if (Session["sqlselect"] != "")
                {
                    Session["sqlselect"] += " and ";
                }
                Session["sqlselect"] = " OrderState='" + RadDropDownList1.SelectedText + "' ";
            }

            else if (RadDropDownList1.SelectedValue == "4")
            {
                if (Session["sqlselect"] != "")
                {
                    Session["sqlselect"] += " and ";
                }
                Session["sqlselect"] = " OrderState='" + RadDropDownList1.SelectedText + "' ";
            }

            else if (RadDropDownList1.SelectedValue == "5")
            {
                if (Session["sqlselect"] != "")
                {
                    Session["sqlselect"] += " and ";
                }
                Session["sqlselect"] = " OrderState='" + RadDropDownList1.SelectedText + "' ";
            }

            else if (RadDropDownList1.SelectedValue == "6")
            {
                if (Session["sqlselect"] != "")
                {
                    Session["sqlselect"] += " and ";
                }
                Session["sqlselect"] = " OrderState='" + RadDropDownList1.SelectedText + "' ";
            }             
            RadGrid1.Rebind();
        }
    }
}