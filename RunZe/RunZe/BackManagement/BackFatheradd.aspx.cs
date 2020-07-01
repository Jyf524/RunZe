using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.BackManagement
{

    public partial class BackFatheradd : System.Web.UI.Page
    {
        Maticsoft.BLL.CommodityFather CommodityFather_BLL = new Maticsoft.BLL.CommodityFather();
        Maticsoft.Model.CommodityFather CommodityFather_Model = new Maticsoft.Model.CommodityFather();
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
            if ((CommodityFather_BLL.GetList("CommodityFatherName ='" + RadTextBox1.Text + "'").Tables[0].Rows.Count) > 0)
            {
                RadAjaxManager1.Alert("请输入不同名称!");
            }
            else
            {
                CommodityFather_Model.CommodityFatherName = RadTextBox1.Text;
                CommodityFather_Model.CommodityFatherID = DateTime.Now.ToString("yyyyMMddhhmmss");
                CommodityFather_BLL.Add(CommodityFather_Model);
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>CloseAndRebind();</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>CloseAndRebind();</script>");
        }
    }
}