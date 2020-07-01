using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.BackManagement
{
    public partial class Backhygl : System.Web.UI.Page
    {
        Maticsoft.BLL.Users Users_Bll = new Maticsoft.BLL.Users();
        Maticsoft.BLL.Commodity Commodity_Bll = new Maticsoft.BLL.Commodity();
        Maticsoft.Model.Commodity Commodity_Mol = new Maticsoft.Model.Commodity();
        Maticsoft.BLL.Appraise Appraise_Bll = new Maticsoft.BLL.Appraise();
        Maticsoft.Model.Appraise Appraise_Mol = new Maticsoft.Model.Appraise();
        Maticsoft.BLL.ShoppingCart ShoppingCart_Bll = new Maticsoft.BLL.ShoppingCart();
        Maticsoft.Model.ShoppingCart ShoppingCart_Mol = new Maticsoft.Model.ShoppingCart();
        Maticsoft.BLL.OrderDetail OrderDetail_Bll = new Maticsoft.BLL.OrderDetail();
        Maticsoft.Model.OrderDetail OrderDetail_Mol = new Maticsoft.Model.OrderDetail();
        Maticsoft.BLL.Orders Orders_Bll = new Maticsoft.BLL.Orders();
        public String Username
        {
            get
            { return ViewState["_Username"] == null ? string.Empty : ViewState["_Username"].ToString(); }
            set
            { ViewState["_Username"] = value; }
        }

        public String Grade
        {
            get
            { return ViewState["_Grade"] == null ? string.Empty : ViewState["_Grade"].ToString(); }
            set
            { ViewState["_Grade"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    Session["sqlselect"] = "";
            //}
            if (UsersInfo.UserID == "")
            {
                Response.Write("<script> alert('请先登录！'); window.location.href='/BackLogin.aspx' </script>");
                return;
            }
            Button1.Attributes["onclick"] = "OpenEdit();return false;";//添加
        }


        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void RadGrid1_NeedDataSource1(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            DataLoad();
            //sqlstring = Session["sqlselect"].ToString();
            //RadGrid1.DataSource = User_BLL.GetList2(sqlstring);
        }

        protected void RadGrid1_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "Delete")//删除数据
            {
                Users_Bll.DeleteList(id);
                if(Appraise_Bll.GetRecordCount("UserID='" + id + "'") !=0)
                {
                    Appraise_Bll.DeleteList2(id);
                }
                if (ShoppingCart_Bll.GetRecordCount("UserID='" + id + "'") != 0)
                {
                    ShoppingCart_Bll.DeleteList2(id);
                }
                if (OrderDetail_Bll.GetRecordCount("UserID='" + id + "'") != 0)
                {
                    OrderDetail_Bll.DeleteList2(id);
                }
                if (Orders_Bll.GetRecordCount("UserID='" + id + "'") != 0)
                {
                    Orders_Bll.DeleteList2(id);
                }
                RadGrid1.Rebind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Grade = RadDropDownList1.SelectedValue;
            DataLoad();
            RadGrid1.Rebind();
        }

        protected void DataLoad()
        {
            string sqlselect = " Username like '%" + RadTextBox1.Text + "%' ";
            if (Grade != "")
            {
                sqlselect += " and UserGrade = '" + Grade + "' ";
            }
            RadGrid1.DataSource = Users_Bll.GetList(sqlselect);
        }

        protected void RadGrid1_PageIndexChanged1(object sender, Telerik.Web.UI.GridPageChangedEventArgs e)
        {
            RadGrid1.Rebind();
        }
    }
}