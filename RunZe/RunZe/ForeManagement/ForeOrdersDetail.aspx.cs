using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace RunZe.ForeManagement
{
    public partial class ForeOrdersDetail : System.Web.UI.Page
    {
        Maticsoft.BLL.Users Users_Bll = new Maticsoft.BLL.Users();
        Maticsoft.Model.Users Users_Mol = new Maticsoft.Model.Users();
        Maticsoft.BLL.Appraise Appraise_Bll = new Maticsoft.BLL.Appraise();
        Maticsoft.Model.Appraise Appraise_Mol = new Maticsoft.Model.Appraise();
        Maticsoft.BLL.Commodity Commodity_Bll = new Maticsoft.BLL.Commodity();
        Maticsoft.Model.Commodity Commodity_Mol = new Maticsoft.Model.Commodity();
        Maticsoft.BLL.CommodityFather CommodityFather_Bll = new Maticsoft.BLL.CommodityFather();
        Maticsoft.BLL.CommoditySon CommoditySon_Bll = new Maticsoft.BLL.CommoditySon();
        Maticsoft.BLL.ShoppingCart ShoppingCart_Bll = new Maticsoft.BLL.ShoppingCart();
        Maticsoft.Model.ShoppingCart ShoppingCart_Mol = new Maticsoft.Model.ShoppingCart();
        Maticsoft.BLL.Orders Orders_Bll = new Maticsoft.BLL.Orders();
        Maticsoft.Model.Orders Orders_Mol = new Maticsoft.Model.Orders();
        Maticsoft.BLL.OrderDetail OrderDetail_Bll = new Maticsoft.BLL.OrderDetail();
        Maticsoft.Model.OrderDetail OrderDetail_Mol = new Maticsoft.Model.OrderDetail();
        public double Score1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UsersInfo.UserID == "")
            {
                Response.Write("<script> alert('请先登录！'); window.location.href='../Login.aspx' </script>");
                return;
            }
            if (!IsPostBack)
            {
                Maticsoft.Model.Users molUsers = Users_Bll.GetModel(UsersInfo.UserID);
                Maticsoft.Model.Orders molOrders = Orders_Bll.GetModel(Request.QueryString["OrderID"].ToString());
                RadTextBox1.Text = molUsers.UserRealName;
                RadTextBox2.Text = molUsers.Address1;
                ddlcityLoad(molUsers.Province);
                ddlcity.SelectedValue = molUsers.City;
                Score1 = Convert.ToInt32(molOrders.TotalMoney * 100);
                if (RadTextBox5.Text == "")
                {
                    RadTextBox5.Text = "0";
                }
                if (Convert.ToInt32(Score1) > molUsers.UserScore)
                {
                    Label1.Text = molUsers.UserScore.ToString();
                }
                else
                {
                    Label1.Text = Score1.ToString();
                }
                RadTextBox4.Text = molUsers.Phone;
                RadDropDownList1.SelectedValue = "1";
                RadDropDownList2.SelectedValue = "1";
            }
        }

        protected void ddlcityLoad(string Province)
        {
            Maticsoft.Model.Users modelnew = Users_Bll.GetModel(UsersInfo.UserID);//引用id所在行的数据
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

        protected void ddlprovince_SelectedIndexChanged(object sender, Telerik.Web.UI.DropDownListEventArgs e)
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string phone = @"((^13[0-9]{1}[0-9]{8}|^15[0-9]{1}[0-9]{8}|^14[0-9]{1}[0-9]{8}|^16[0-9]{1}[0-9]{8}|^17[0-9]{1}[0-9]{8}|^18[0-9]{1}[0-9]{8}|^19[0-9]{1}[0-9]{8})|^((\d{7,8})|(\d{4}|\d{3})-(\d{7,8})|(\d{4}|\d{3})-(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1})|(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1}))$)";
            Regex rxphone = new Regex(phone);
            string yb = @"^[1-9]\d{5}$";
            Regex rxyb = new Regex(yb);
            Maticsoft.Model.Orders molOrders = Orders_Bll.GetModel(Request.QueryString["OrderID"].ToString());

            if (RadTextBox1.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入收件人姓名!");
            }
            else if (ddlprovince.SelectedValue == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入收件人地址!");
            }
            else if (ddlcity.SelectedValue == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入收件人地址!");
            }
            else if (RadTextBox2.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入收件人详细地址!");
            }
            else if (RadTextBox3.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入收件人邮编!");
            }
            else if (RadTextBox4.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入收件人联系电话!");
            }
            else if (RadDropDownList1.SelectedValue == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请选择送货方式!");
            }
            else if (RadDropDownList2.SelectedValue == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请选择支付方式!");
            }
            else if (!rxyb.IsMatch(RadTextBox3.Text))
            {
                RadTextBox3.Text = "";
                RadAjaxManager1.Alert("邮编格式错误!");
            }
            else if (!rxphone.IsMatch(RadTextBox4.Text))
            {
                RadTextBox4.Text = "";
                RadAjaxManager1.Alert("手机格式错误!");
            }
            else if(Convert.ToInt32( RadTextBox5.Text)>Convert.ToInt32(  Label1.Text))
            {
                RadAjaxManager1.Alert("积分不足!");
            }
            else
            {
                Maticsoft.Model.Users molUsers = Users_Bll.GetModel(UsersInfo.UserID);

                molOrders.AddresseeName = RadTextBox1.Text;
                molOrders.AddresseeAddress = ddlprovince.SelectedValue;
                molOrders.AddresseeAddress += ddlcity.SelectedValue;
                molOrders.AddresseeAddress += RadTextBox2.Text;
                molOrders.AddresseeZipCode = RadTextBox3.Text;
                molOrders.AddresseePhone = RadTextBox4.Text;
                molOrders.Delivery = RadDropDownList1.SelectedText;
                molOrders.PayType = RadDropDownList2.SelectedText;
                molOrders.Message = TextArea1.InnerText;
                molOrders.OrderState = "已付款待发货";

                molUsers.UserScore = molUsers.UserScore - Convert.ToInt32(RadTextBox5.Text);
                Users_Bll.Update(molUsers);



                molOrders.TotalMoney = molOrders.TotalMoney - Convert.ToDecimal(Convert.ToInt32(RadTextBox5.Text) * 0.01);

                Orders_Bll.Update(molOrders);

                Response.Write("<script>alert('提交成功!');window.location.href='ForeOrderShow.aspx?OrderID=" + Request.QueryString["OrderID"] + "'</script>");
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location.href='ShoppingCart.aspx' </script>");
        }
    }
}