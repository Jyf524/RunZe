using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.ForeManagement
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        Maticsoft.BLL.Users Users_Bll = new Maticsoft.BLL.Users();
        Maticsoft.Model.Users User_Model = new Maticsoft.Model.Users();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UsersInfo.UserID == "")
            {
                Response.Write("<script> alert('请先登录！'); window.location.href='../Login.aspx' </script>");
                return;
            }
        }

        protected void Btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForeVIP.aspx");
        }

        protected void Btn_Check_Click(object sender, EventArgs e)
        {
            Maticsoft.Model.Users modelnew = Users_Bll.GetModel(UsersInfo.UserID);//引用id所在行的数据
            string path = "^[a-zA-Z0-9_]{6,16}$";
            Regex rx = new Regex(path);
            if (RadTextBox1.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入原密码!");
            }
            else if (RadTextBox1.Text != modelnew.UserPassword)
            {
                RadAjaxManager1.Alert("原密码错误!");
            }
            else if (RadTextBox2.Text == modelnew.UserPassword)
            {
                RadAjaxManager1.Alert("不能与原密码相同!");
            }
            else if (RadTextBox2.Text == "")
            {
                RadAjaxManager1.Alert("请输入新密码!");
            }
            else if (!rx.IsMatch(RadTextBox2.Text))
            {
                RadTextBox2.Text = "";
                RadAjaxManager1.Alert("密码格式错误!");
            }
            else if (RadTextBox3.Text == "")
            {
                RadAjaxManager1.Alert("请确认密码!");
            }
            else if (RadTextBox2.Text != RadTextBox3.Text)
            {
                RadAjaxManager1.Alert("两次密码输入不一致!");
            }
            else
            {
                User_Model = Users_Bll.GetModel(UsersInfo.UserID);
                User_Model.UserPassword  = RadTextBox3.Text;//添加数据
                Users_Bll.Update(User_Model);
                Response.Write("<script>alert('修改成功!');window.location.href='../Login.aspx'</script>");
            }
        }
    }
}