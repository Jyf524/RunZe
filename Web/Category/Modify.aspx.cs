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
namespace Maticsoft.Web.Category
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int CategoryID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(CategoryID);
				}
			}
		}
			
	private void ShowInfo(int CategoryID)
	{
		Maticsoft.BLL.Category bll=new Maticsoft.BLL.Category();
		Maticsoft.Model.Category model=bll.GetModel(CategoryID);
		this.lblCategoryID.Text=model.CategoryID.ToString();
		this.txtCategorytype.Text=model.Categorytype;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCategorytype.Text.Trim().Length==0)
			{
				strErr+="Categorytype不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int CategoryID=int.Parse(this.lblCategoryID.Text);
			string Categorytype=this.txtCategorytype.Text;


			Maticsoft.Model.Category model=new Maticsoft.Model.Category();
			model.CategoryID=CategoryID;
			model.Categorytype=Categorytype;

			Maticsoft.BLL.Category bll=new Maticsoft.BLL.Category();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
