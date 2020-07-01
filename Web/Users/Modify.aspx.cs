using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.Users
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string UserID= Request.Params["id"];
					ShowInfo(UserID);
				}
			}
		}
			
	private void ShowInfo(string UserID)
	{
		Maticsoft.BLL.Users bll=new Maticsoft.BLL.Users();
		Maticsoft.Model.Users model=bll.GetModel(UserID);
		this.lblUserID.Text=model.UserID;
		this.txtUsername.Text=model.Username;
		this.txtUserPassword.Text=model.UserPassword;
		this.txtUserRealName.Text=model.UserRealName;
		this.txtUserSex.Text=model.UserSex;
		this.txtUserEmail.Text=model.UserEmail;
		this.txtUserGrade.Text=model.UserGrade;
		this.txtUserScore.Text=model.UserScore.ToString();
		this.txtProvince.Text=model.Province;
		this.txtCity.Text=model.City;
		this.txtAddress1.Text=model.Address1;
		this.txtUserIdentity.Text=model.UserIdentity;
		this.txtRegistTime.Text=model.RegistTime.ToString();
		this.txtPhone.Text=model.Phone;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUsername.Text.Trim().Length==0)
			{
				strErr+="Username不能为空！\\n";	
			}
			if(this.txtUserPassword.Text.Trim().Length==0)
			{
				strErr+="UserPassword不能为空！\\n";	
			}
			if(this.txtUserRealName.Text.Trim().Length==0)
			{
				strErr+="UserRealName不能为空！\\n";	
			}
			if(this.txtUserSex.Text.Trim().Length==0)
			{
				strErr+="UserSex不能为空！\\n";	
			}
			if(this.txtUserEmail.Text.Trim().Length==0)
			{
				strErr+="UserEmail不能为空！\\n";	
			}
			if(this.txtUserGrade.Text.Trim().Length==0)
			{
				strErr+="UserGrade不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserScore.Text))
			{
				strErr+="UserScore格式错误！\\n";	
			}
			if(this.txtProvince.Text.Trim().Length==0)
			{
				strErr+="Province不能为空！\\n";	
			}
			if(this.txtCity.Text.Trim().Length==0)
			{
				strErr+="City不能为空！\\n";	
			}
			if(this.txtAddress1.Text.Trim().Length==0)
			{
				strErr+="Address1不能为空！\\n";	
			}
			if(this.txtUserIdentity.Text.Trim().Length==0)
			{
				strErr+="UserIdentity不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtRegistTime.Text))
			{
				strErr+="RegistTime格式错误！\\n";	
			}
			if(this.txtPhone.Text.Trim().Length==0)
			{
				strErr+="Phone不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string UserID=this.lblUserID.Text;
			string Username=this.txtUsername.Text;
			string UserPassword=this.txtUserPassword.Text;
			string UserRealName=this.txtUserRealName.Text;
			string UserSex=this.txtUserSex.Text;
			string UserEmail=this.txtUserEmail.Text;
			string UserGrade=this.txtUserGrade.Text;
			int UserScore=int.Parse(this.txtUserScore.Text);
			string Province=this.txtProvince.Text;
			string City=this.txtCity.Text;
			string Address1=this.txtAddress1.Text;
			string UserIdentity=this.txtUserIdentity.Text;
			DateTime RegistTime=DateTime.Parse(this.txtRegistTime.Text);
			string Phone=this.txtPhone.Text;


			Maticsoft.Model.Users model=new Maticsoft.Model.Users();
			model.UserID=UserID;
			model.Username=Username;
			model.UserPassword=UserPassword;
			model.UserRealName=UserRealName;
			model.UserSex=UserSex;
			model.UserEmail=UserEmail;
			model.UserGrade=UserGrade;
			model.UserScore=UserScore;
			model.Province=Province;
			model.City=City;
			model.Address1=Address1;
			model.UserIdentity=UserIdentity;
			model.RegistTime=RegistTime;
			model.Phone=Phone;

			Maticsoft.BLL.Users bll=new Maticsoft.BLL.Users();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
