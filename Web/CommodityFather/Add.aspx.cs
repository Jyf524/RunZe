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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCommodityFatherID.Text.Trim().Length==0)
			{
				strErr+="CommodityFatherID不能为空！\\n";	
			}
			if(this.txtCommodityFatherName.Text.Trim().Length==0)
			{
				strErr+="CommodityFatherName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CommodityFatherID=this.txtCommodityFatherID.Text;
			string CommodityFatherName=this.txtCommodityFatherName.Text;

			Maticsoft.Model.CommodityFather model=new Maticsoft.Model.CommodityFather();
			model.CommodityFatherID=CommodityFatherID;
			model.CommodityFatherName=CommodityFatherName;

			Maticsoft.BLL.CommodityFather bll=new Maticsoft.BLL.CommodityFather();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
