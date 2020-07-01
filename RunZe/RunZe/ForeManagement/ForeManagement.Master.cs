using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.ForeManagement
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UsersInfo.UserID == "")
                {
                    Label1.Text = "请登录";
                    Label2.Text = "免费注册";
                    Label3.Text = "";
                    Label4.Text = "";
                }
                else
                {
                    Label1.Text = "";
                    Label2.Text = "";
                    Label3.Text = "欢迎回来," + UsersInfo.UserName + "";
                    Label4.Text = "注销";
                }
                RadTextBox1.Text = Request.QueryString["search"];
            }
        }

        protected void Btn_search_Click(object sender, EventArgs e)
        {
            string search = RadTextBox1.Text;
            if (RadTextBox1.Text == "")
            {
                Response.Write("<script> alert('请输入关键字！')</script>");
            }
            else
            {
                Response.Redirect("/ForeManagement/Foresplb.aspx?search=" + search + "");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            UsersInfo.UserID = "";
            Response.Redirect("/ForeManagement/Foresplb.aspx");
        }   

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/HomePage.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ForeManagement/ForeVIP.aspx?ID=" + UsersInfo.UserID + "");
        }
    }
}