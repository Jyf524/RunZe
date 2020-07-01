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
namespace Maticsoft.Web.OrderDetail
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string OrderDetailID= Request.Params["id"];
					ShowInfo(OrderDetailID);
				}
			}
		}
			
	private void ShowInfo(string OrderDetailID)
	{
		Maticsoft.BLL.OrderDetail bll=new Maticsoft.BLL.OrderDetail();
		Maticsoft.Model.OrderDetail model=bll.GetModel(OrderDetailID);
		this.lblOrderDetailID.Text=model.OrderDetailID;
		this.txtOrderID.Text=model.OrderID;
		this.txtCommodityID.Text=model.CommodityID;
		this.txtUserID.Text=model.UserID;
		this.txtOrderNumber.Text=model.OrderNumber.ToString();
		this.txtAppraiseGrade.Text=model.AppraiseGrade.ToString();
		this.txtSubtotal.Text=model.Subtotal;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtOrderID.Text.Trim().Length==0)
			{
				strErr+="OrderID不能为空！\\n";	
			}
			if(this.txtCommodityID.Text.Trim().Length==0)
			{
				strErr+="CommodityID不能为空！\\n";	
			}
			if(this.txtUserID.Text.Trim().Length==0)
			{
				strErr+="UserID不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderNumber.Text))
			{
				strErr+="OrderNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtAppraiseGrade.Text))
			{
				strErr+="AppraiseGrade格式错误！\\n";	
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
			string OrderDetailID=this.lblOrderDetailID.Text;
			string OrderID=this.txtOrderID.Text;
			string CommodityID=this.txtCommodityID.Text;
			string UserID=this.txtUserID.Text;
			int OrderNumber=int.Parse(this.txtOrderNumber.Text);
			int AppraiseGrade=int.Parse(this.txtAppraiseGrade.Text);
			string Subtotal=this.txtSubtotal.Text;


			Maticsoft.Model.OrderDetail model=new Maticsoft.Model.OrderDetail();
			model.OrderDetailID=OrderDetailID;
			model.OrderID=OrderID;
			model.CommodityID=CommodityID;
			model.UserID=UserID;
			model.OrderNumber=OrderNumber;
			model.AppraiseGrade=AppraiseGrade;
			model.Subtotal=Subtotal;

			Maticsoft.BLL.OrderDetail bll=new Maticsoft.BLL.OrderDetail();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
