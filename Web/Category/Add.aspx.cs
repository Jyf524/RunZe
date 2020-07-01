using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.Category
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtCategoryID.Text))
			{
				strErr+="CategoryID格式错误！\\n";	
			}
			if(this.txtCategorytype.Text.Trim().Length==0)
			{
				strErr+="Categorytype不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int CategoryID=int.Parse(this.txtCategoryID.Text);
			string Categorytype=this.txtCategorytype.Text;

			Maticsoft.Model.Category model=new Maticsoft.Model.Category();
			model.CategoryID=CategoryID;
			model.Categorytype=Categorytype;

			Maticsoft.BLL.Category bll=new Maticsoft.BLL.Category();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
