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
namespace Maticsoft.Web.CommodityFather
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string CommodityFatherID= Request.Params["id"];
					ShowInfo(CommodityFatherID);
				}
			}
		}
			
	private void ShowInfo(string CommodityFatherID)
	{
		Maticsoft.BLL.CommodityFather bll=new Maticsoft.BLL.CommodityFather();
		Maticsoft.Model.CommodityFather model=bll.GetModel(CommodityFatherID);
		this.lblCommodityFatherID.Text=model.CommodityFatherID;
		this.txtCommodityFatherName.Text=model.CommodityFatherName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCommodityFatherName.Text.Trim().Length==0)
			{
				strErr+="CommodityFatherName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CommodityFatherID=this.lblCommodityFatherID.Text;
			string CommodityFatherName=this.txtCommodityFatherName.Text;


			Maticsoft.Model.CommodityFather model=new Maticsoft.Model.CommodityFather();
			model.CommodityFatherID=CommodityFatherID;
			model.CommodityFatherName=CommodityFatherName;

			Maticsoft.BLL.CommodityFather bll=new Maticsoft.BLL.CommodityFather();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
