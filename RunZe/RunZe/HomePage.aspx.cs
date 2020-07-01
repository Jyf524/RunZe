using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe
{
    public partial class HomePage : System.Web.UI.Page
    {
        Maticsoft.BLL.Users Users_Bll = new Maticsoft.BLL.Users();
        Maticsoft.BLL.Commodity Commodity_Bll = new Maticsoft.BLL.Commodity();
        Maticsoft.BLL.CommodityFather CommodityFather_Bll = new Maticsoft.BLL.CommodityFather();
        Maticsoft.BLL.CommoditySon CommoditySon_Bll = new Maticsoft.BLL.CommoditySon();
        Maticsoft.BLL.ShoppingCart ShoppingCart_Bll = new Maticsoft.BLL.ShoppingCart();
        Maticsoft.Model.ShoppingCart ShoppingCart_Mol = new Maticsoft.Model.ShoppingCart();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadLV_Father_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            RadLV_Father.DataSource = CommodityFather_Bll.GetList2("");//绑定父类数据源
        }

        protected void RadLV_Father_ItemDataBound(object sender, Telerik.Web.UI.RadListViewItemEventArgs e)
        {
            Telerik.Web.UI.RadListView RadLV_Son = e.Item.FindControl("RadLV_Son") as Telerik.Web.UI.RadListView;//寻找子类ListView控件
            if (RadLV_Son != null)//判断子类控件是否存在
            {
                RadLV_Son.DataSource = CommoditySon_Bll.GetList(" CommodityFatherID='" + e.Item.OwnerListView.DataKeyValues[e.Item.OwnerListView.DataKeyValues.Count - 1]["CommodityFatherID"].ToString() + "' ");
                //通过寻找父类ID给子类ListView绑值
                RadLV_Son.DataBind();//数据绑定
            }
        }

        protected void RadLV_Son_ItemCommand(object sender, Telerik.Web.UI.RadListViewCommandEventArgs e)
        {
            string search1 = e.CommandArgument.ToString();
            Response.Redirect("/ForeManagement/Foresplb.aspx?search1=" + search1 + "");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void RadLV_newsp_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            RadLV_newsp.DataSource = Commodity_Bll.GetList2(0, "CommodityState='上架' or Stock <0", "CommodityTime desc");
        }

        protected void RadLVtuijiansp_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            RadLVtuijiansp.DataSource = Commodity_Bll.GetList2(0, " Recommend = '推荐' and CommodityState='上架' or Stock <0 ", "CommodityTime desc");
        }

        protected void RadLVzshyph_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            RadLVzshyph.DataSource = Commodity_Bll.GetList(0, "  ", "CommoditySaled desc");
        }

        protected void RadLVVipjfph_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            RadLVVipjfph.DataSource = Users_Bll.GetList(0, "  ", "UserScore desc");
        }

        protected void RadLV_Father_ItemCommand(object sender, Telerik.Web.UI.RadListViewCommandEventArgs e)
        {
            string search2 = e.CommandArgument.ToString();
            Response.Redirect("/ForeManagement/Foresplb.aspx?search2=" + search2 + "");
        }

        protected void RadLV_Father1_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            RadLV_Father1.DataSource = CommodityFather_Bll.GetList2("");
        }

        protected void RadLV_Father1_ItemCommand(object sender, Telerik.Web.UI.RadListViewCommandEventArgs e)
        {
            string search2 = e.CommandArgument.ToString();
            Response.Redirect("/ForeManagement/Foresplb.aspx?search2=" + search2 + "");
        }

    }
}