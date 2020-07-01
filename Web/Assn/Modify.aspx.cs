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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int AssnID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(AssnID);
				}
			}
		}
			
	private void ShowInfo(int AssnID)
	{
		Maticsoft.BLL.Assn bll=new Maticsoft.BLL.Assn();
		Maticsoft.Model.Assn model=bll.GetModel(AssnID);
		this.lblAssnID.Text=model.AssnID.ToString();
		this.txtSocialName.Text=model.SocialName;
		this.txtSocialTeacher.Text=model.SocialTeacher;
		this.txtSocialLogo.Text=model.SocialLogo;
		this.txtAddTime.Text=model.AddTime.ToString();
		this.txtSocialState.Text=model.SocialState;
		this.txtSocialPurpose.Text=model.SocialPurpose;
		this.txtSocialType.Text=model.SocialType;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			int AssnID=int.Parse(this.lblAssnID.Text);
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
