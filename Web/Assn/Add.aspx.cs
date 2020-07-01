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
namespace Maticsoft.Web.Assn
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtAssnID.Text))
			{
				strErr+="AssnID格式错误！\\n";	
			}
			if(this.txtSocialName.Text.Trim().Length==0)
			{
				strErr+="SocialName不能为空！\\n";	
			}
			if(this.txtSocialTeacher.Text.Trim().Length==0)
			{
				strErr+="SocialTeacher不能为空！\\n";	
			}
			if(this.txtSocialLogo.Text.Trim().Length==0)
			{
				strErr+="SocialLogo不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAddTime.Text))
			{
				strErr+="AddTime格式错误！\\n";	
			}
			if(this.txtSocialState.Text.Trim().Length==0)
			{
				strErr+="SocialState不能为空！\\n";	
			}
			if(this.txtSocialPurpose.Text.Trim().Length==0)
			{
				strErr+="SocialPurpose不能为空！\\n";	
			}
			if(this.txtSocialType.Text.Trim().Length==0)
			{
				strErr+="SocialType不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int AssnID=int.Parse(this.txtAssnID.Text);
			string SocialName=this.txtSocialName.Text;
			string SocialTeacher=this.txtSocialTeacher.Text;
			string SocialLogo=this.txtSocialLogo.Text;
			DateTime AddTime=DateTime.Parse(this.txtAddTime.Text);
			string SocialState=this.txtSocialState.Text;
			string SocialPurpose=this.txtSocialPurpose.Text;
			string SocialType=this.txtSocialType.Text;

			Maticsoft.Model.Assn model=new Maticsoft.Model.Assn();
			model.AssnID=AssnID;
			model.SocialName=SocialName;
			model.SocialTeacher=SocialTeacher;
			model.SocialLogo=SocialLogo;
			model.AddTime=AddTime;
			model.SocialState=SocialState;
			model.SocialPurpose=SocialPurpose;
			model.SocialType=SocialType;

			Maticsoft.BLL.Assn bll=new Maticsoft.BLL.Assn();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
