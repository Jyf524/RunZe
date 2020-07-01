using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace RunZe.BackManagement
{
    public partial class Backyhxxxx : System.Web.UI.Page
    {
        Maticsoft.BLL.Users Users_Bll = new Maticsoft.BLL.Users();
        Maticsoft.Model.Users User_Model = new Maticsoft.Model.Users();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UsersInfo.UserID == "")
            {
                Response.Write("<script> alert('请先登录！'); window.location.href='/BackLogin.aspx' </script>");
                return;
            }
            if (!IsPostBack)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    if (Request.QueryString["ID"] != null)
                    {
                            Maticsoft.Model.Users modelnew = Users_Bll.GetModel(Request.QueryString["ID"].ToString());//引用id所在行的数据
                            Label1.Text = modelnew.Username;//添加数据
                            RadTextBox2.Text = modelnew.UserRealName;//添加数据
                            ddlcityLoad(modelnew.Province);
                            ddlcity.SelectedValue = modelnew.City;
                            RadTextBox6.Text = modelnew.Address1;//添加数据
                            RadNumericTextBox1.Text = modelnew.UserScore.ToString();
                            RadTextBox3.Text = modelnew.UserEmail;
                            if (modelnew.UserSex == "男")
                            {
                                Rad_nan.Checked = true;
                            }
                            else
                            {
                                Rad_nv.Checked = true;
                            }
                            RadDatePicker1.SelectedDate = modelnew.RegistTime;
                            RadDropDownList1.SelectedValue = modelnew.UserGrade.ToString();//添加数据
                        }
                }
                else
                {
                    Response.Redirect("Backhygl.aspx");
                }
            }
        }

        protected void ddlcityLoad(string Province)
        {
            Maticsoft.Model.Users modelnew = Users_Bll.GetModel(Request.QueryString["ID"].ToString());//引用id所在行的数据
            ddlprovince.Items.Clear();//清空省下拉框项目
            ddlcity.Items.Clear();//清空市下拉框项目    
            DataSet ProvinceDS = new DataSet();//声明数据库
            ProvinceDS.ReadXml(Server.MapPath("~/PatentProvince.xml"));//读取xml文件
            foreach (DataRow dr in ProvinceDS.Tables[0].Rows)//声明dr,数据库循环
            {
                //逐条向dr添加,文本为dr的name列,值为dr的name列
                ddlprovince.Items.Add(new DropDownListItem(dr["name"].ToString(), dr["name"].ToString()));
            }
            ddlprovince.SelectedValue = Province;

            XmlDataSource xds = new XmlDataSource();//声明xml数据源
            xds.DataFile = Server.MapPath("~/PatentProvince.xml");//读取xml文件
            xds.XPath = "//province[@name='" + ddlprovince.SelectedValue + "']/city";//将路径存放在表达式中
            ddlcity.DataSource = xds;//将xds赋值给数据源
            ddlcity.DataTextField = "cname";//设置文本字段
            ddlcity.DataValueField = "cname";//设置值字段
            ddlcity.DataBind();//绑定数据源
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = @"(^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.[a-zA-Z0-9]{2,6}$)";
            Regex rx = new Regex(path);
            string name = "^[a-zA-Z0-9\u4e00-\u9fa5]{1,}$";//字母数字汉字
            Regex rxname = new Regex(name);
            if (RadTextBox2.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入姓名!");
            }
            else if (!rxname.IsMatch(RadTextBox2.Text))
            {
                RadAjaxManager1.Alert("不能输入特殊字符!");
                return;
            }
            else if (RadTextBox3.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入邮箱!");
            }
            else if (RadDatePicker1.SelectedDate.ToString() == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入生日!");
            }
            else if (ddlprovince.SelectedValue == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入所在地!");
            }
            else if (ddlcity.SelectedValue == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入所在地!");
            }
            else if (RadTextBox6.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入详细地址!");
            }
            else if (!rxname.IsMatch(RadTextBox6.Text))
            {
                RadAjaxManager1.Alert("不能输入特殊字符!");
                return;
            }
            else if (RadNumericTextBox1.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入会员积分!");
            }
            else if (RadDropDownList1.SelectedValue == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入会员等级");
            }
            else if (!rx.IsMatch(RadTextBox3.Text))
            {
                RadTextBox3.Text = "";
                RadAjaxManager1.Alert("邮箱格式错误!");
            }
            else
            {
                User_Model = Users_Bll.GetModel(Request.QueryString["ID"].ToString());
                User_Model.UserRealName = RadTextBox2.Text;//添加数据
                User_Model.Province = ddlprovince.SelectedValue;
                User_Model.City = ddlcity.SelectedValue;
                User_Model.Address1 = RadTextBox6.Text;//添加数据
                User_Model.UserEmail = RadTextBox3.Text;
                User_Model.UserScore = Convert.ToInt32(RadNumericTextBox1.Text);
                if (Rad_nan.Checked == true)
                {
                    User_Model.UserSex = "男";
                }
                else
                {
                    User_Model.UserSex = "女";
                }
                User_Model.RegistTime = RadDatePicker1.SelectedDate;
                User_Model.UserGrade = RadDropDownList1.SelectedValue;//添加数据
                Users_Bll.Update(User_Model);
                Response.Write("<script>alert('修改成功!');window.location.href='Backhygl.aspx?ID=" + UsersInfo.UserID + "'</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Backhygl.aspx");
        }

        protected void RadTextBox1_Load(object sender, EventArgs e)
        {

        }

        protected void RadTextBox2_Load(object sender, EventArgs e)
        {

        }

        protected void RadTextBox3_Load(object sender, EventArgs e)
        {

        }

        protected void RadTextBox5_Load(object sender, EventArgs e)
        {

        }

        protected void RadTextBox6_Load(object sender, EventArgs e)
        {

        }


        protected void RadDateTimePicker1_Load(object sender, EventArgs e)
        {

        }

        protected void RadTextBox9_Load(object sender, EventArgs e)
        {

        }

        protected void RadTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadDropDownList2_SelectedIndexChanged(object sender, DropDownListEventArgs e)
        {

        }

        protected void ddlprovince_SelectedIndexChanged(object sender, DropDownListEventArgs e)
        {
            ddlcity.Items.Clear();//清空市下拉框项目
            ddlcity.Items.Add(new DropDownListItem("请选择", ""));//给市下拉框添加请选择
            XmlDataSource xds = new XmlDataSource();//声明xml数据源
            xds.DataFile = Server.MapPath("~/PatentProvince.xml");//读取xml文件
            xds.XPath = "//province[@name='" + ddlprovince.SelectedValue + "']/city";//将路径存放在表达式中
            ddlcity.DataSource = xds;//将xds赋值给数据源
            ddlcity.DataTextField = "cname";//设置文本字段
            ddlcity.DataValueField = "cname";//设置值字段
            ddlcity.DataBind();//绑定数据源
            ddlcity.SelectedText = "请选择";//设置初始值
        }

    }
}
