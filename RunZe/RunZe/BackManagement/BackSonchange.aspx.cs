using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.BackManagement
{
    public partial class BackSonchange : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                    CommoditySon_Model = CommoditySon_Bll.GetModel(Request.QueryString["ID"].ToString());//引用id所在行的数据
                    RadTextBox1.Text = CommoditySon_Model.CommoditySonName;//添加数据
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.Model.CommoditySon modelnew = CommoditySon_Bll.GetModel(Request.QueryString["ID"].ToString());//引用id所在行的数据
            if ((CommoditySon_Bll.GetList("CommoditySonName ='" + RadTextBox1.Text + "'").Tables[0].Rows.Count) != 0 && RadTextBox1.Text != modelnew.CommoditySonName)
            {
                RadAjaxManager1.Alert("请输入不同名称!");
            }
            else
            {
                CommoditySon_Model = CommoditySon_Bll.GetModel(Request.QueryString["ID"].ToString());
                CommoditySon_Model.CommoditySonName = RadTextBox1.Text;
                CommoditySon_Bll.Update(CommoditySon_Model);
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>CloseAndRebind();</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>CloseAndRebind();</script>");
        }
    }
}