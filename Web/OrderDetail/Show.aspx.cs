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
namespace Maticsoft.Web.OrderDetail
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
					string OrderDetailID= strid;
					ShowInfo(OrderDetailID);
				}
			}
		}
		
	private void ShowInfo(string OrderDetailID)
	{
		Maticsoft.BLL.OrderDetail bll=new Maticsoft.BLL.OrderDetail();
		Maticsoft.Model.OrderDetail model=bll.GetModel(OrderDetailID);
		this.lblOrderDetailID.Text=model.OrderDetailID;
		this.lblOrderID.Text=model.OrderID;
		this.lblCommodityID.Text=model.CommodityID;
		this.lblUserID.Text=model.UserID;
		this.lblOrderNumber.Text=model.OrderNumber.ToString();
		this.lblAppraiseGrade.Text=model.AppraiseGrade.ToString();
		this.lblSubtotal.Text=model.Subtotal;

	}


    }
}
