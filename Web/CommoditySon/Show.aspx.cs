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
namespace Maticsoft.Web.CommoditySon
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
					string CommoditySonID= strid;
					ShowInfo(CommoditySonID);
				}
			}
		}
		
	private void ShowInfo(string CommoditySonID)
	{
		Maticsoft.BLL.CommoditySon bll=new Maticsoft.BLL.CommoditySon();
		Maticsoft.Model.CommoditySon model=bll.GetModel(CommoditySonID);
		this.lblCommoditySonID.Text=model.CommoditySonID;
		this.lblCommodityFatherID.Text=model.CommodityFatherID;
		this.lblCommoditySonName.Text=model.CommoditySonName;

	}


    }
}
