using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.BackManagement
{
    public partial class BackSonadd : System.Web.UI.Page
    {
        Maticsoft.BLL.CommoditySon CommoditySon_Bll = new Maticsoft.BLL.CommoditySon();
        Maticsoft.Model.CommoditySon CommoditySon_Model = new Maticsoft.Model.CommoditySon();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UsersInfo.UserID == "")
            {
                Response.Write("<script> alert('请先登录！'); window.location.href='/BackLogin.aspx' </script>");
                return;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((CommoditySon_Bll.GetList("CommoditySonName ='" + RadTextBox1.Text + "'").Tables[0].Rows.Count) > 0)
            {
                RadAjaxManager1.Alert("请输入不同名称!");
            }
            else
            {
                CommoditySon_Model.CommoditySonName = RadTextBox1.Text;
                CommoditySon_Model.CommodityFatherID = Session["FaID"].ToString();
                CommoditySon_Model.CommoditySonID = DateTime.Now.ToString("yyyyMMddhhmmss");
                CommoditySon_Bll.Add(CommoditySon_Model);
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>CloseAndRebind();</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>CloseAndRebind();</script>");
        }
    }
}