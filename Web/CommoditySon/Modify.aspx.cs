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
namespace Maticsoft.Web.CommoditySon
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string CommoditySonID= Request.Params["id"];
					ShowInfo(CommoditySonID);
				}
			}
		}
			
	private void ShowInfo(string CommoditySonID)
	{
		Maticsoft.BLL.CommoditySon bll=new Maticsoft.BLL.CommoditySon();
		Maticsoft.Model.CommoditySon model=bll.GetModel(CommoditySonID);
		this.lblCommoditySonID.Text=model.CommoditySonID;
		this.txtCommodityFatherID.Text=model.CommodityFatherID;
		this.txtCommoditySonName.Text=model.CommoditySonName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCommodityFatherID.Text.Trim().Length==0)
			{
				strErr+="CommodityFatherID不能为空！\\n";	
			}
			if(this.txtCommoditySonName.Text.Trim().Length==0)
			{
				strErr+="CommoditySonName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CommoditySonID=this.lblCommoditySonID.Text;
			string CommodityFatherID=this.txtCommodityFatherID.Text;
			string CommoditySonName=this.txtCommoditySonName.Text;


			Maticsoft.Model.CommoditySon model=new Maticsoft.Model.CommoditySon();
			model.CommoditySonID=CommoditySonID;
			model.CommodityFatherID=CommodityFatherID;
			model.CommoditySonName=CommoditySonName;

			Maticsoft.BLL.CommoditySon bll=new Maticsoft.BLL.CommoditySon();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
