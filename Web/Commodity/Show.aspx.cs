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
namespace Maticsoft.Web.Commodity
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
					string CommodityID= strid;
					ShowInfo(CommodityID);
				}
			}
		}
		
	private void ShowInfo(string CommodityID)
	{
		Maticsoft.BLL.Commodity bll=new Maticsoft.BLL.Commodity();
		Maticsoft.Model.Commodity model=bll.GetModel(CommodityID);
		this.lblCommodityID.Text=model.CommodityID;
		this.lblCommodityFatherID.Text=model.CommodityFatherID;
		this.lblCommoditySonID.Text=model.CommoditySonID;
		this.lblCommodityName.Text=model.CommodityName;
		this.lblCommodityPrice.Text=model.CommodityPrice;
		this.lblMarketPrice.Text=model.MarketPrice.ToString();
		this.lblVIPPrice.Text=model.VIPPrice.ToString();
		this.lblStock.Text=model.Stock.ToString();
		this.lblBuyScore.Text=model.BuyScore;
		this.lblCommodityImage.Text=model.CommodityImage;
		this.lblCommodityType.Text=model.CommodityType;
		this.lblCommoditySaled.Text=model.CommoditySaled.ToString();
		this.lblIntroduce.Text=model.Introduce;
		this.lblCommodityTime.Text=model.CommodityTime.ToString();
		this.lblRecommend.Text=model.Recommend;
		this.lblCommodityState.Text=model.CommodityState;
		this.lblScore.Text=model.Score;
		this.lblScoreTimes.Text=model.ScoreTimes;

	}


    }
}
