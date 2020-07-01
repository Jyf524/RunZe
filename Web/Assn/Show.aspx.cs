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
namespace Maticsoft.Web.Assn
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int AssnID=(Convert.ToInt32(strid));
					ShowInfo(AssnID);
				}
			}
		}
		
	private void ShowInfo(int AssnID)
	{
		Maticsoft.BLL.Assn bll=new Maticsoft.BLL.Assn();
		Maticsoft.Model.Assn model=bll.GetModel(AssnID);
		this.lblAssnID.Text=model.AssnID.ToString();
		this.lblSocialName.Text=model.SocialName;
		this.lblSocialTeacher.Text=model.SocialTeacher;
		this.lblSocialLogo.Text=model.SocialLogo;
		this.lblAddTime.Text=model.AddTime.ToString();
		this.lblSocialState.Text=model.SocialState;
		this.lblSocialPurpose.Text=model.SocialPurpose;
		this.lblSocialType.Text=model.SocialType;

	}


    }
}
