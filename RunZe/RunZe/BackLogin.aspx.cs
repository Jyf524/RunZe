using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe
{
    public partial class BackLogin : System.Web.UI.Page
    {
        Maticsoft.BLL.Users User_Bll = new Maticsoft.BLL.Users();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            if ( RadTextBox1.Text== "")
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
            if (User_Bll.GetRecordCount(" Username='" + RadTextBox1.Text + "' ") == 0)
            {
                Label1.Text = "该账户不存在";
                Label1.Visible = true;
                return;
            }
            if (User_Bll.GetRecordCount(" Username='" + RadTextBox1.Text + "' and UserPassword='" + RadTextBox3.Text + "'") == 0)
            {
                Label2.Text = "密码错误";
                Label2.Visible = true;
                return;
            }
            if (Session["CheckCode"].ToString().ToLower() != RadTextBox2.Text.ToLower())
            {
                Label3.Text = "验证码错误";
                Label3.Visible = true;
                return;
            }
            DataSet ds = User_Bll.GetList(" Username='" + RadTextBox1.Text + "' ");
            if (ds.Tables[0].Rows[0]["UserIdentity"].ToString() != "管理员")
            {
                Label1.Text = "您没有权限";
                Label1.Visible = true;
                return;
            }
            UsersInfo.UserID = ds.Tables[0].Rows[0]["UserID"].ToString();
            UsersInfo.UserRole = ds.Tables[0].Rows[0]["UserIdentity"].ToString();
            UsersInfo.UserName = ds.Tables[0].Rows[0]["Username"].ToString();


            //UsersInfo user = new UsersInfo();
            //UsersInfo.UserName = RadTextBox1.Text;
            //UsersInfo.UserRole = RadTextBox2.Text;
            Response.Redirect("~/BackManagement/BackIndex.aspx");
        }
    }
}