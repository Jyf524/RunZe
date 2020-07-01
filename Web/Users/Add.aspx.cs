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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserID.Text.Trim().Length==0)
			{
				strErr+="UserID不能为空！\\n";	
			}
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
			string UserID=this.txtUserID.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
