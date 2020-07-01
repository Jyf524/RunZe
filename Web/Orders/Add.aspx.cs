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
namespace Maticsoft.Web.Orders
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtOrderID.Text.Trim().Length==0)
			{
				strErr+="OrderID不能为空！\\n";	
			}
			if(this.txtUserID.Text.Trim().Length==0)
			{
				strErr+="UserID不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOrderDate.Text))
			{
				strErr+="OrderDate格式错误！\\n";	
			}
			if(this.txtOrderState.Text.Trim().Length==0)
			{
				strErr+="OrderState不能为空！\\n";	
			}
			if(this.txtCommodityID.Text.Trim().Length==0)
			{
				strErr+="CommodityID不能为空！\\n";	
			}
			if(this.txtOrderNumber.Text.Trim().Length==0)
			{
				strErr+="OrderNumber不能为空！\\n";	
			}
			if(this.txtAddresseeName.Text.Trim().Length==0)
			{
				strErr+="AddresseeName不能为空！\\n";	
			}
			if(this.txtAddresseeAddress.Text.Trim().Length==0)
			{
				strErr+="AddresseeAddress不能为空！\\n";	
			}
			if(this.txtAddresseeZipCode.Text.Trim().Length==0)
			{
				strErr+="AddresseeZipCode不能为空！\\n";	
			}
			if(this.txtAddresseePhone.Text.Trim().Length==0)
			{
				strErr+="AddresseePhone不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTotalMoney.Text))
			{
				strErr+="TotalMoney格式错误！\\n";	
			}
			if(this.txtPayType.Text.Trim().Length==0)
			{
				strErr+="PayType不能为空！\\n";	
			}
			if(this.txtDelivery.Text.Trim().Length==0)
			{
				strErr+="Delivery不能为空！\\n";	
			}
			if(this.txtMessage.Text.Trim().Length==0)
			{
				strErr+="Message不能为空！\\n";	
			}
			if(this.txtOrderImage.Text.Trim().Length==0)
			{
				strErr+="OrderImage不能为空！\\n";	
			}
			if(this.txtCommodityName.Text.Trim().Length==0)
			{
				strErr+="CommodityName不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice.Text))
			{
				strErr+="Price格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string OrderID=this.txtOrderID.Text;
			string UserID=this.txtUserID.Text;
			DateTime OrderDate=DateTime.Parse(this.txtOrderDate.Text);
			string OrderState=this.txtOrderState.Text;
			string CommodityID=this.txtCommodityID.Text;
			string OrderNumber=this.txtOrderNumber.Text;
			string AddresseeName=this.txtAddresseeName.Text;
			string AddresseeAddress=this.txtAddresseeAddress.Text;
			string AddresseeZipCode=this.txtAddresseeZipCode.Text;
			string AddresseePhone=this.txtAddresseePhone.Text;
			decimal TotalMoney=decimal.Parse(this.txtTotalMoney.Text);
			string PayType=this.txtPayType.Text;
			string Delivery=this.txtDelivery.Text;
			string Message=this.txtMessage.Text;
			string OrderImage=this.txtOrderImage.Text;
			string CommodityName=this.txtCommodityName.Text;
			decimal Price=decimal.Parse(this.txtPrice.Text);

			Maticsoft.Model.Orders model=new Maticsoft.Model.Orders();
			model.OrderID=OrderID;
			model.UserID=UserID;
			model.OrderDate=OrderDate;
			model.OrderState=OrderState;
			model.CommodityID=CommodityID;
			model.OrderNumber=OrderNumber;
			model.AddresseeName=AddresseeName;
			model.AddresseeAddress=AddresseeAddress;
			model.AddresseeZipCode=AddresseeZipCode;
			model.AddresseePhone=AddresseePhone;
			model.TotalMoney=TotalMoney;
			model.PayType=PayType;
			model.Delivery=Delivery;
			model.Message=Message;
			model.OrderImage=OrderImage;
			model.CommodityName=CommodityName;
			model.Price=Price;

			Maticsoft.BLL.Orders bll=new Maticsoft.BLL.Orders();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
