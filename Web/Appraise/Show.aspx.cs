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
namespace Maticsoft.Web.Appraise
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
					string AppriseID= strid;
					ShowInfo(AppriseID);
				}
			}
		}
		
	private void ShowInfo(string AppriseID)
	{
		Maticsoft.BLL.Appraise bll=new Maticsoft.BLL.Appraise();
		Maticsoft.Model.Appraise model=bll.GetModel(AppriseID);
		this.lblAppriseID.Text=model.AppriseID;
		this.lblUserID.Text=model.UserID;
		this.lblCommodityID.Text=model.CommodityID;

	}


    }
}
