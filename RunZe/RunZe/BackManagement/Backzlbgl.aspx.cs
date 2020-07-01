using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.BackManagement
{
    public partial class Backzlbgl : System.Web.UI.Page
    {
        Maticsoft.BLL.CommoditySon CommoditySon_BLL = new Maticsoft.BLL.CommoditySon();
        Maticsoft.BLL.Commodity Commodity_BLL = new Maticsoft.BLL.Commodity();
        string sqlstring = "";

        public String CommodityFatherID
        {
            get
            { return ViewState["_CommodityFatherID"] == null ? string.Empty : ViewState["_CommodityFatherID"].ToString(); }
            set
            { ViewState["_CommodityFatherID"] = value; }
        }

        public String CommoditySonName
        {
            get
            { return ViewState["_CommoditySonName"] == null ? string.Empty : ViewState["_CommoditySonName"].ToString(); }
            set
            { ViewState["_CommoditySonName"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (UsersInfo.UserID == "")
            {
                Response.Write("<script> alert('请先登录！'); window.location.href='/BackLogin.aspx' </script>");
                return;
            }
            Button1.Attributes["onclick"] = "OpenEdit();return false;";//修改
            Button3.Attributes["onclick"] = "OpenEdit2();return false;";//添加
            if (!IsPostBack)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    Session["FaID"] = Request.QueryString["ID"].ToString();
                }
                else
                {
                    Response.Redirect("Backlbgl.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Backzlb.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Backlbgl.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Backzlbadd.aspx");
        }

        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void RadGrid1_NeedDataSource1(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            DataLoad();
            //sqlstring = Session["sqlselect"].ToString();
            //RadGrid1.DataSource = CommoditySon_BLL.GetList(sqlstring);
        }

        protected void RadGrid1_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "Delete")//删除数据
            {
                if (Commodity_BLL.GetRecordCount(" CommoditySonID ='" + id + "' ") != 0 && CommoditySon_BLL.GetRecordCount(" CommoditySonID ='" + id + "' ") != 0)
                {
                    RadAjaxManager1.Alert("删除失败！");
                }
                else
                {
                    CommoditySon_BLL.Delete(e.CommandArgument.ToString());
                    RadGrid1.Rebind();
                }
            }
        }

        protected void RadGrid1_PageIndexChanged(object sender, Telerik.Web.UI.GridPageChangedEventArgs e)
        {
            RadGrid1.Rebind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataLoad();
            RadGrid1.Rebind();
        }

        protected void DataLoad()
        {
            string sqlselect = " CommodityFatherID='" + Session["FaID"] + "' and CommoditySonName like '%" + RadTextBox1.Text + "%' ";
            RadGrid1.DataSource = CommoditySon_BLL.GetList(sqlselect);
        }

        protected void RadAjaxManager1_AjaxRequest(object sender, Telerik.Web.UI.AjaxRequestEventArgs e)
        {
            if (e.Argument == "Rebind")
            {
                RadGrid1.Rebind();
            }
        }
    }
}