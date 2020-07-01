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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtShoppingCartID.Text.Trim().Length==0)
			{
				strErr+="ShoppingCartID不能为空！\\n";	
			}
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
			string ShoppingCartID=this.txtShoppingCartID.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
