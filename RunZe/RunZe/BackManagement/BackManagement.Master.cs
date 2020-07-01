using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RunZe.BackManagement
{
    public partial class BackManagement : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsersInfo user = new UsersInfo();
            Label1.Text = UsersInfo.UserName;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            UsersInfo.UserName = "";
            UsersInfo.UserRole = "";
            UsersInfo.UserID = "";
            Response.Redirect("../BackLogin.aspx");
        }
    }
}