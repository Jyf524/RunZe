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
namespace Maticsoft.Web.Orders
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
					string OrderID= strid;
					ShowInfo(OrderID);
				}
			}
		}
		
	private void ShowInfo(string OrderID)
	{
		Maticsoft.BLL.Orders bll=new Maticsoft.BLL.Orders();
		Maticsoft.Model.Orders model=bll.GetModel(OrderID);
		this.lblOrderID.Text=model.OrderID;
		this.lblUserID.Text=model.UserID;
		this.lblOrderDate.Text=model.OrderDate.ToString();
		this.lblOrderState.Text=model.OrderState;
		this.lblCommodityID.Text=model.CommodityID;
		this.lblOrderNumber.Text=model.OrderNumber;
		this.lblAddresseeName.Text=model.AddresseeName;
		this.lblAddresseeAddress.Text=model.AddresseeAddress;
		this.lblAddresseeZipCode.Text=model.AddresseeZipCode;
		this.lblAddresseePhone.Text=model.AddresseePhone;
		this.lblTotalMoney.Text=model.TotalMoney.ToString();
		this.lblPayType.Text=model.PayType;
		this.lblDelivery.Text=model.Delivery;
		this.lblMessage.Text=model.Message;
		this.lblOrderImage.Text=model.OrderImage;
		this.lblCommodityName.Text=model.CommodityName;
		this.lblPrice.Text=model.Price.ToString();

	}


    }
}
