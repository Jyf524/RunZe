using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.BackManagement
{
    public partial class BackFatherchange : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                    Maticsoft.Model.CommodityFather modelnew = CommodityFather_BLL.GetModel(Request.QueryString["ID"].ToString());//引用id所在行的数据
                    RadTextBox1.Text = modelnew.CommodityFatherName;//添加数据
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.Model.CommodityFather modelnew = CommodityFather_BLL.GetModel(Request.QueryString["ID"].ToString());//引用id所在行的数据
            if ((CommodityFather_BLL.GetList("CommodityFatherName ='" + RadTextBox1.Text + "'").Tables[0].Rows.Count) != 0&&RadTextBox1.Text!= modelnew.CommodityFatherName)
            {
                RadAjaxManager1.Alert("请输入不同名称!");
            }
            else
            {
                CommodityFather_Model = CommodityFather_BLL.GetModel(Request.QueryString["ID"].ToString());
                CommodityFather_Model.CommodityFatherName = RadTextBox1.Text;
                CommodityFather_BLL.Update(CommodityFather_Model);
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>CloseAndRebind();</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>CloseAndRebind();</script>");
        }
    }
}