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
namespace Maticsoft.Web.ShoppingCart
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
					string ShoppingCartID= strid;
					ShowInfo(ShoppingCartID);
				}
			}
		}
		
	private void ShowInfo(string ShoppingCartID)
	{
		Maticsoft.BLL.ShoppingCart bll=new Maticsoft.BLL.ShoppingCart();
		Maticsoft.Model.ShoppingCart model=bll.GetModel(ShoppingCartID);
		this.lblShoppingCartID.Text=model.ShoppingCartID;
		this.lblUserID.Text=model.UserID;
		this.lblCommodityID.Text=model.CommodityID;
		this.lblOrderNumber.Text=model.OrderNumber.ToString();
		this.lblSubtotal.Text=model.Subtotal;

	}


    }
}
