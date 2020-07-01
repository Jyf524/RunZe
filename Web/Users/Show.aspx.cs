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
namespace Maticsoft.Web.Users
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
					string UserID= strid;
					ShowInfo(UserID);
				}
			}
		}
		
	private void ShowInfo(string UserID)
	{
		Maticsoft.BLL.Users bll=new Maticsoft.BLL.Users();
		Maticsoft.Model.Users model=bll.GetModel(UserID);
		this.lblUserID.Text=model.UserID;
		this.lblUsername.Text=model.Username;
		this.lblUserPassword.Text=model.UserPassword;
		this.lblUserRealName.Text=model.UserRealName;
		this.lblUserSex.Text=model.UserSex;
		this.lblUserEmail.Text=model.UserEmail;
		this.lblUserGrade.Text=model.UserGrade;
		this.lblUserScore.Text=model.UserScore.ToString();
		this.lblProvince.Text=model.Province;
		this.lblCity.Text=model.City;
		this.lblAddress1.Text=model.Address1;
		this.lblUserIdentity.Text=model.UserIdentity;
		this.lblRegistTime.Text=model.RegistTime.ToString();
		this.lblPhone.Text=model.Phone;

	}


    }
}
