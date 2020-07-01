using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.BackManagement
{
    public partial class Backlbgl : System.Web.UI.Page
    {
        Maticsoft.BLL.CommodityFather CommodityFather_BLL = new Maticsoft.BLL.CommodityFather();
        Maticsoft.Model.CommodityFather CommodityFather_Model = new Maticsoft.Model.CommodityFather();
        Maticsoft.BLL.CommoditySon CommoditySon_BLL = new Maticsoft.BLL.CommoditySon();
        string sqlstring = "";

        public String CommodityFatherName
        {
            get
            { return ViewState["_CommodityFatherName"] == null ? string.Empty : ViewState["_CommodityFatherName"].ToString(); }
            set
            { ViewState["_CommodityFatherName"] = value; }
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
            Button1.Attributes["onclick"] = "OpenEdit();return false;";//修改
            Button3.Attributes["onclick"] = "OpenEdit2();return false;";//添加
            Button2.Attributes["onclick"] = "OpenEdit3();return false;";//查看
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("Backzlbgl.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            DataLoad();
            //sqlstring = Session["sqlselect"].ToString();
            //RadGrid1.DataSource = CommodityFather_BLL.GetList(sqlstring);
        }

        protected void RadGrid1_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "Delete")
            {
                if (CommodityFather_BLL.GetRecordCount(" CommodityFatherID ='" + id + "' ") != 0 && CommoditySon_BLL.GetRecordCount(" CommodityFatherID ='" + id + "' ") != 0)
                {
                    RadAjaxManager1.Alert("删除失败！");
                }
                else
                {
                    CommodityFather_BLL.Delete(e.CommandArgument.ToString());
                    RadGrid1.Rebind();//删除
                }
            }
        }

        protected void RadGrid1_PageIndexChanged(object sender, Telerik.Web.UI.GridPageChangedEventArgs e)
        {
            RadGrid1.Rebind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["sqlselect"] = "CommodityFatherName like '%" + RadTextBox1.Text + "%' ";
            DataLoad();
            RadGrid1.Rebind();
        }

        protected void DataLoad()
        {
            string sqlselect = " CommodityFatherName like '%" + RadTextBox1.Text + "%' ";
            RadGrid1.DataSource = CommodityFather_BLL.GetList(sqlselect);
        }

        protected void RadAjaxManager1_AjaxRequest(object sender, Telerik.Web.UI.AjaxRequestEventArgs e)
        {
            if (e.Argument == "Rebind")
            {
                RadGrid1.Rebind();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
}