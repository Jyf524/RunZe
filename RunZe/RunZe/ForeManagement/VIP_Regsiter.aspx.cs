using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.ForeManagement
{
    public partial class VIP_Regsiter : System.Web.UI.Page
    {
        Maticsoft.BLL.Users Users_Bll = new Maticsoft.BLL.Users();
        Maticsoft.Model.Users Users_Mol = new Maticsoft.Model.Users();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string email = @"^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$";
            Regex rxemail = new Regex(email);
            string phone = "^((13[0-9])|(14[5,7])|(15[0-3,5-9])|(17[0,3,5-8])|(18[0-9])|166|198|199|(147))\\d{8}$";
            Regex rxphone = new Regex(phone);
            string username = @"^\w+$";
            Regex rxusername = new Regex(username);
            string name = "^[a-zA-Z0-9\u4e00-\u9fa5]{1,}$";//字母数字汉字
            Regex rxname = new Regex(name);

            lblUserName.Text = "";
            lblPassword.Text = "";
            lblPassword2.Text = "";
            lblEmail.Text = "";
            lblcode.Text = "";
            if (txtUserName.Text == "")
            {
                lblUserName.Text = "账户不能为空!";
                return;
            }
            if (!rxname.IsMatch(txtUserName.Text))
            {
                lblPassword.Text = "不能输入特殊字符!";
                return;
            }
            if (txtPassword.Text == "")
            {
                lblPassword.Text = "密码不能为空!";
                return;
            }
            if (txtPassword2.Text == "")
            {
                lblPassword2.Text = "确认密码不能为空!";
                return;
            }
            if (txtphone.Text == "")
            {
                lblphone.Text = "手机号不能为空!";
                return;
            }
            if (txtEmail.Text == "")
            {
                lblEmail.Text = "邮箱不能为空!";
                return;
            }
            if (txtcode.Text == "")
            {
                lblcode.Text = "验证码不能为空!";
                return;
            }
            if (!rxusername.IsMatch(txtUserName.Text))
            {
                lblUserName.Text = "格式错误!";
                return;
            }
            if (!rxusername.IsMatch(txtPassword.Text))
            {
                lblPassword.Text = "格式错误!";
                return;
            }
            if (!rxusername.IsMatch(txtcode.Text))
            {
                lblUserName.Text = "格式错误!";
                return;
            }
            if (!rxusername.IsMatch(txtPassword2.Text))
            {
                lblUserName.Text = "格式错误!";
                return;
            }
            if (Users_Bll.GetList(" Username ='" + txtUserName.Text + "' ").Tables[0].Rows.Count != 0)
            {
                lblUserName.Text = "用户名已存在!";
                return;
            }
           
            if (txtPassword.Text != txtPassword2.Text)
            {
                lblPassword2.Text = "两次密码输入不一致!";
                return;
            }

            if (!rxphone.IsMatch(txtphone.Text))
            {
                txtphone.Text = "";
                lblphone.Text = "手机格式错误!";
                return;
            }

            if (!rxemail.IsMatch(txtEmail.Text))
            {
                txtEmail.Text = ""; 
                lblEmail.Text = "邮箱输入错误!";
                return;
            }
            if (Session["CheckCode"].ToString().ToLower() != txtcode.Text.ToLower())
            {
                txtcode.Text = "";
                lblcode.Text = "验证码错误!";
                return;
            }
            if (txtUserName.Text.Count() < 6)
            {
                lblUserName.Text = "账户不能小于6位!";
                return;
            }

            Users_Mol.UserID = DateTime.Now.ToString("yyyyMMddHHmmss");
            Users_Mol.Username = txtUserName.Text;
            Users_Mol.UserPassword = txtPassword.Text;
            Users_Mol.Phone = txtphone.Text;
            Users_Mol.UserEmail = txtEmail.Text;
            Users_Mol.RegistTime = DateTime.Now;
            Users_Mol.UserScore = 0;
            Users_Mol.UserGrade = "会员";
            Users_Mol.UserIdentity = "会员";
            if (CheckBox1.Checked == true)
            {
                Users_Bll.Add(Users_Mol);
                Response.Write("<script>alert('注册成功!');window.location.href='/Login.aspx'</script>");
            }
            else
            {
                CheckBox1.Checked = false;
                Response.Write("<script>alert('请同意条款!')</script>");
            }
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../tiaokuan.aspx");
        }
    }
}