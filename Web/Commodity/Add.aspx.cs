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
namespace Maticsoft.Web.Commodity
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCommodityID.Text.Trim().Length==0)
			{
				strErr+="CommodityID不能为空！\\n";	
			}
			if(this.txtCommodityFatherID.Text.Trim().Length==0)
			{
				strErr+="CommodityFatherID不能为空！\\n";	
			}
			if(this.txtCommoditySonID.Text.Trim().Length==0)
			{
				strErr+="CommoditySonID不能为空！\\n";	
			}
			if(this.txtCommodityName.Text.Trim().Length==0)
			{
				strErr+="CommodityName不能为空！\\n";	
			}
			if(this.txtCommodityPrice.Text.Trim().Length==0)
			{
				strErr+="CommodityPrice不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMarketPrice.Text))
			{
				strErr+="MarketPrice格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtVIPPrice.Text))
			{
				strErr+="VIPPrice格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStock.Text))
			{
				strErr+="Stock格式错误！\\n";	
			}
			if(this.txtBuyScore.Text.Trim().Length==0)
			{
				strErr+="BuyScore不能为空！\\n";	
			}
			if(this.txtCommodityImage.Text.Trim().Length==0)
			{
				strErr+="CommodityImage不能为空！\\n";	
			}
			if(this.txtCommodityType.Text.Trim().Length==0)
			{
				strErr+="CommodityType不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtCommoditySaled.Text))
			{
				strErr+="CommoditySaled格式错误！\\n";	
			}
			if(this.txtIntroduce.Text.Trim().Length==0)
			{
				strErr+="Introduce不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCommodityTime.Text))
			{
				strErr+="CommodityTime格式错误！\\n";	
			}
			if(this.txtRecommend.Text.Trim().Length==0)
			{
				strErr+="Recommend不能为空！\\n";	
			}
			if(this.txtCommodityState.Text.Trim().Length==0)
			{
				strErr+="CommodityState不能为空！\\n";	
			}
			if(this.txtScore.Text.Trim().Length==0)
			{
				strErr+="Score不能为空！\\n";	
			}
			if(this.txtScoreTimes.Text.Trim().Length==0)
			{
				strErr+="ScoreTimes不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CommodityID=this.txtCommodityID.Text;
			string CommodityFatherID=this.txtCommodityFatherID.Text;
			string CommoditySonID=this.txtCommoditySonID.Text;
			string CommodityName=this.txtCommodityName.Text;
			string CommodityPrice=this.txtCommodityPrice.Text;
			decimal MarketPrice=decimal.Parse(this.txtMarketPrice.Text);
			decimal VIPPrice=decimal.Parse(this.txtVIPPrice.Text);
			int Stock=int.Parse(this.txtStock.Text);
			string BuyScore=this.txtBuyScore.Text;
			string CommodityImage=this.txtCommodityImage.Text;
			string CommodityType=this.txtCommodityType.Text;
			int CommoditySaled=int.Parse(this.txtCommoditySaled.Text);
			string Introduce=this.txtIntroduce.Text;
			DateTime CommodityTime=DateTime.Parse(this.txtCommodityTime.Text);
			string Recommend=this.txtRecommend.Text;
			string CommodityState=this.txtCommodityState.Text;
			string Score=this.txtScore.Text;
			string ScoreTimes=this.txtScoreTimes.Text;

			Maticsoft.Model.Commodity model=new Maticsoft.Model.Commodity();
			model.CommodityID=CommodityID;
			model.CommodityFatherID=CommodityFatherID;
			model.CommoditySonID=CommoditySonID;
			model.CommodityName=CommodityName;
			model.CommodityPrice=CommodityPrice;
			model.MarketPrice=MarketPrice;
			model.VIPPrice=VIPPrice;
			model.Stock=Stock;
			model.BuyScore=BuyScore;
			model.CommodityImage=CommodityImage;
			model.CommodityType=CommodityType;
			model.CommoditySaled=CommoditySaled;
			model.Introduce=Introduce;
			model.CommodityTime=CommodityTime;
			model.Recommend=Recommend;
			model.CommodityState=CommodityState;
			model.Score=Score;
			model.ScoreTimes=ScoreTimes;

			Maticsoft.BLL.Commodity bll=new Maticsoft.BLL.Commodity();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
