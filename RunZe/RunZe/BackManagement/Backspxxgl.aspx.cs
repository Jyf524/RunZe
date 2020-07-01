using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace RunZe.BackManagement
{
    public partial class Backspxxgl : System.Web.UI.Page
    {
        Maticsoft.BLL.Commodity Commodity_BLL = new Maticsoft.BLL.Commodity();
        Maticsoft.BLL.OrderDetail OrderDetail_Bll = new Maticsoft.BLL.OrderDetail();
        Maticsoft.BLL.CommodityFather CommodityFather_BLL = new Maticsoft.BLL.CommodityFather();
        Maticsoft.Model.CommodityFather CommodityFather_Model = new Maticsoft.Model.CommodityFather();
        Maticsoft.BLL.CommoditySon CommoditySon_Bll = new Maticsoft.BLL.CommoditySon();
        Maticsoft.Model.CommoditySon CommoditySon_Model = new Maticsoft.Model.CommoditySon();

        public String CommodityName
        {
            get
            { return ViewState["_CommodityName"] == null ? string.Empty : ViewState["_CommodityName"].ToString(); }
            set
            { ViewState["_CommodityName"] = value; }
        }
        public String Recommend
        {
            get
            { return ViewState["_Recommend"] == null ? string.Empty : ViewState["_Recommend"].ToString(); }
            set
            { ViewState["_Recommend"] = value; }
        }
        public String CommodityFatherName
        {
            get
            { return ViewState["_CommodityFatherID"] == null ? string.Empty : ViewState["_CommodityFatherID"].ToString(); }
            set
            { ViewState["_CommodityFatherID"] = value; }
        }
        public String CommoditySonName
        {
            get
            { return ViewState["_CommoditySonID"] == null ? string.Empty : ViewState["_CommoditySonID"].ToString(); }
            set
            { ViewState["_CommoditySonID"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (UsersInfo.UserID == "")
            {
                Response.Write("<script> alert('请先登录！'); window.location.href='/BackLogin.aspx' </script>");
                return;
            }
            Button3.Attributes["onclick"] = "OpenEdit();return false;";//添加
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Backspadd.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Backspxx.aspx");
        }

        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            DataLoad();
            //sqlstring = Session["sqlselect"].ToString();
            //RadGrid1.DataSource = Commodity_BLL.GetList3(sqlstring);
        }

        protected void RadGrid1_PageIndexChanged(object sender, Telerik.Web.UI.GridPageChangedEventArgs e)
        {

            RadGrid1.Rebind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CommodityName = RadTextBox1.Text;
            Recommend = ddlGoodsRecommend.SelectedText;
            CommodityFatherName = ddlGoodsFatherName.SelectedValue;
            CommoditySonName = ddlGoodsSonName.SelectedValue;
            DataLoad();
            RadGrid1.Rebind();
        }

        protected void DataLoad()
        {
            string sqlselect = "  CommodityName like '%" + CommodityName + "%' ";
            if (Recommend != "全部" && Recommend != "")
            {
                sqlselect += " and Recommend = '" + Recommend + "' ";
            }
            if (CommodityFatherName != "全部" && CommodityFatherName != "")
            {
                sqlselect += " and b.CommodityFatherID = '" + CommodityFatherName + "' ";
            }
            if (CommoditySonName != "全部" && CommoditySonName != "")
            {
                sqlselect += " and c.CommoditySonID = '" + CommoditySonName + "' ";
            }
            RadGrid1.DataSource = Commodity_BLL.GetList3(sqlselect);
        }

        protected void RadGrid1_ItemCommand1(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "Delete")
            {
                if (Commodity_BLL.GetRecordCount(" CommodityID ='" + id + "' ") != 0 && OrderDetail_Bll.GetRecordCount(" CommodityID ='" + id + "' ") != 0)
                {
                    RadAjaxManager1.Alert("存在订单，删除失败!");
                }
                else
                {
                    Commodity_BLL.Delete(e.CommandArgument.ToString());
                    RadGrid1.Rebind();
                }
            }
        }

        protected void ddlGoodsFatherName_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlGoodsFatherName.Items.Clear();
                ddlGoodsSonName.Items.Clear();
                ddlGoodsFatherName.Items.Add(new DropDownListItem("全部", ""));
                ddlGoodsSonName.Items.Add(new DropDownListItem("全部", ""));

                ddlGoodsFatherName.DataSource = CommodityFather_BLL.GetList("");
                ddlGoodsFatherName.DataTextField = "CommodityFatherName";
                ddlGoodsFatherName.DataValueField = "CommodityFatherID";
                ddlGoodsFatherName.DataBind();

                ddlGoodsFatherName.SelectedText = "请选择";
                ddlGoodsSonName.SelectedText = "请选择";
            }
        }

        protected void ddlGoodsFatherName_SelectedIndexChanged(object sender, Telerik.Web.UI.DropDownListEventArgs e)
        {
            ddlGoodsSonName.Items.Clear();
            ddlGoodsSonName.Items.Add(new DropDownListItem("全部", ""));
            ddlGoodsSonName.DataSource = CommoditySon_Bll.GetList(" CommodityFatherID ='" + ddlGoodsFatherName.SelectedValue + "'  ");
            ddlGoodsSonName.DataTextField = "CommoditySonName";
            ddlGoodsSonName.DataValueField = "CommoditySonID";
            ddlGoodsSonName.DataBind();
            ddlGoodsSonName.SelectedText = "请选择";
        }
    }
}
