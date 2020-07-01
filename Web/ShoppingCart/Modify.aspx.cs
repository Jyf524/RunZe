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
namespace Maticsoft.Web.ShoppingCart
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string ShoppingCartID= Request.Params["id"];
					ShowInfo(ShoppingCartID);
				}
			}
		}
			
	private void ShowInfo(string ShoppingCartID)
	{
		Maticsoft.BLL.ShoppingCart bll=new Maticsoft.BLL.ShoppingCart();
		Maticsoft.Model.ShoppingCart model=bll.GetModel(ShoppingCartID);
		this.lblShoppingCartID.Text=model.ShoppingCartID;
		this.txtUserID.Text=model.UserID;
		this.txtCommodityID.Text=model.CommodityID;
		this.txtOrderNumber.Text=model.OrderNumber.ToString();
		this.txtSubtotal.Text=model.Subtotal;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserID.Text.Trim().Length==0)
			{
				strErr+="UserID不能为空！\\n";	
			}
			if(this.txtCommodityID.Text.Trim().Length==0)
			{
				strErr+="CommodityID不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderNumber.Text))
			{
				strErr+="OrderNumber格式错误！\\n";	
			}
			if(this.txtSubtotal.Text.Trim().Length==0)
			{
				strErr+="Subtotal不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ShoppingCartID=this.lblShoppingCartID.Text;
			string UserID=this.txtUserID.Text;
			string CommodityID=this.txtCommodityID.Text;
			int OrderNumber=int.Parse(this.txtOrderNumber.Text);
			string Subtotal=this.txtSubtotal.Text;


			Maticsoft.Model.ShoppingCart model=new Maticsoft.Model.ShoppingCart();
			model.ShoppingCartID=ShoppingCartID;
			model.UserID=UserID;
			model.CommodityID=CommodityID;
			model.OrderNumber=OrderNumber;
			model.Subtotal=Subtotal;

			Maticsoft.BLL.ShoppingCart bll=new Maticsoft.BLL.ShoppingCart();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
