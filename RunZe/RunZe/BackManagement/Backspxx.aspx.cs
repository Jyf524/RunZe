using NavigationPlatformWeb.util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace RunZe.BackManagement
{
    public partial class Backspxx : System.Web.UI.Page
    {
        Maticsoft.BLL.Commodity Commodity_Bll = new Maticsoft.BLL.Commodity();
        Maticsoft.Model.Commodity Commodity_Mol = new Maticsoft.Model.Commodity();
        Maticsoft.BLL.CommodityFather CommodityFather_BLL = new Maticsoft.BLL.CommodityFather();
        Maticsoft.Model.CommodityFather CommodityFather_Model = new Maticsoft.Model.CommodityFather();
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
                    Session["GoodsID"] = Request.QueryString["ID"].ToString();
                    Maticsoft.Model.Commodity modelgoods = Commodity_Bll.GetModel(Session["GoodsID"].ToString());
                    if (modelgoods == null)
                    {
                        Response.Write("<script>window.location.href='Backspxxgl.aspx'</script>");
                    }
                    RadTextBox1.Text = modelgoods.CommodityName;
                    RadTextBox2.Text = modelgoods.CommodityType;
                    imgPic.ImageUrl = modelgoods.CommodityImage;
                    RadNumericTextBox1.Text = modelgoods.MarketPrice.ToString();
                    RadNumericTextBox2.Text = modelgoods.VIPPrice.ToString();
                    RadNumericTextBox3.Text = modelgoods.BuyScore;
                    RadNumericTextBox4.Text = modelgoods.Stock.ToString();
                    if (modelgoods.Recommend == "推荐")
                    {
                        RadioButton1.Checked = true;
                    }
                    if (modelgoods.Recommend == "不推荐")
                    {
                        RadioButton4.Checked = true;
                    }
                    if (modelgoods.CommodityState == "上架")
                    {
                        RadioButton2.Checked = true;
                    }
                    if (modelgoods.CommodityState == "下架")
                    {
                        RadioButton3.Checked = true;
                    }
                    myEditor.Value = modelgoods.Introduce;

                    RadDropDownListFather.Items.Clear();
                    RadDropDownListSon.Items.Clear();
                    RadDropDownListFather.Items.Add(new DropDownListItem("请选择", ""));
                    RadDropDownListSon.Items.Add(new DropDownListItem("请选择", ""));

                    RadDropDownListFather.DataSource = CommodityFather_BLL.GetList("");
                    RadDropDownListFather.DataTextField = "CommodityFatherName";
                    RadDropDownListFather.DataValueField = "CommodityFatherID";
                    RadDropDownListFather.DataBind();
                    RadDropDownListFather.SelectedValue = modelgoods.CommodityFatherID;

                    RadDropDownListSon.DataSource = CommoditySon_Bll.GetList(" CommodityFatherID ='" + RadDropDownListFather.SelectedValue + "'  ");
                    RadDropDownListSon.DataTextField = "CommoditySonName";
                    RadDropDownListSon.DataValueField = "CommoditySonID";
                    RadDropDownListSon.DataBind();
                    RadDropDownListSon.SelectedValue = modelgoods.CommoditySonID;
                }

                else
                {
                    Response.Write("<script>window.location.href='Backspxxgl.aspx'</script>");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.Model.Commodity modelgoods = Commodity_Bll.GetModel(Session["GoodsID"].ToString());
            string name = "^[a-zA-Z0-9\u4e00-\u9fa5]{1,}$";//字母数字汉字
            Regex rxname = new Regex(name);

            if (RadTextBox1.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入商品名称!");
                return;
            }
            else if (!rxname.IsMatch(RadTextBox1.Text))
            {
                RadAjaxManager1.Alert("不能输入特殊字符!");
                return;
            }
            else if (RadTextBox2.Text == "")
            {
                RadAjaxManager1.Alert("请输入商品品牌!");
                return;
            }
            else if (!rxname.IsMatch(RadTextBox2.Text))
            {
                RadAjaxManager1.Alert("不能输入特殊字符!");
                return;
            }
            else if (imgPic.ImageUrl == "") //判断是否为空
            {
                RadAjaxManager1.Alert("请插入图片!");
                return;
            }
            if (RadNumericTextBox1.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入市场价!");
                return;
            }
            else if (RadNumericTextBox2.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入会员价!");
                return;
            }
            else if (RadDropDownListFather.SelectedItem.Text == "请选择")
            {
                RadAjaxManager1.Alert("请输入父类别!");
                return;
            }
            else if (RadDropDownListSon.SelectedItem.Text == "请选择")
            {
                RadAjaxManager1.Alert("请输入子类别!");
                return;
            }
            else if (RadNumericTextBox3.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入购买积分!");
                return;
            }
            else if (RadNumericTextBox4.Text == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入库存!");
                return;
            }
            else if (myEditor.Value == "")//判断是否为空
            {
                RadAjaxManager1.Alert("请输入简介!");
                return;
            }
            else
            {
                Commodity_Mol = Commodity_Bll.GetModel(Request.QueryString["ID"].ToString());
                Commodity_Mol.CommodityName = RadTextBox1.Text;
                Commodity_Mol.CommodityType = RadTextBox2.Text;
                Commodity_Mol.CommodityImage = imgPic.ImageUrl;
                Commodity_Mol.MarketPrice = Convert.ToDecimal(RadNumericTextBox1.Text);
                Commodity_Mol.VIPPrice = Convert.ToDecimal(RadNumericTextBox2.Text);
                Commodity_Mol.CommodityFatherID = RadDropDownListFather.SelectedValue;
                Commodity_Mol.CommoditySonID = RadDropDownListSon.SelectedValue;
                Commodity_Mol.BuyScore = RadNumericTextBox3.Text;
                Commodity_Mol.Stock = Convert.ToInt32(RadNumericTextBox4.Text);
                Commodity_Mol.Introduce = myEditor.Value;
                Commodity_Mol.CommodityTime = Convert.ToDateTime(DateTime.Now.ToString());
                if (RadioButton1.Checked == true)
                {
                    Commodity_Mol.Recommend = "推荐";
                }
                if (RadioButton4.Checked == true)
                {
                    Commodity_Mol.Recommend = "不推荐";
                }
                if (RadioButton2.Checked == true && Convert.ToInt32(RadNumericTextBox4.Text) > 0)//状态为上架
                {
                    Commodity_Mol.CommodityState = "上架";
                }
                if (RadioButton2.Checked == true && Convert.ToInt32(RadNumericTextBox4.Text) <= 0)
                {
                    RadAjaxManager1.Alert("库存为零，无法上架!");
                    return;
                }
                if (RadioButton3.Checked == true)
                {
                    Commodity_Mol.CommodityState = "下架";
                }
                if (RadioButton1.Checked == true && Commodity_Bll.GetList("  Recommend ='推荐' ").Tables[0].Rows.Count >= 10)
                {
                    RadAjaxManager1.Alert("推荐商品已满10个，不能添加!");
                }
                else
                {
                    Commodity_Bll.Update(Commodity_Mol);
                    Response.Write("<script>alert('修改成功!');window.location.href='Backspxxgl.aspx'</script>");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Backspxxgl.aspx");
        }

        protected void rauFiles_FileUploaded(object sender, Telerik.Web.UI.FileUploadedEventArgs e)
        {
            string filepath = "";
            if (rauFiles.UploadedFiles.Count > 0)
            {
                UploadedFile file = rauFiles.UploadedFiles[0];
                string uploadPath = "/Upload/" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + "/";
                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(Server.MapPath(uploadPath));
                }
                string name = DateTime.Now.ToString("yyyyMMddHHmmssff") + ".png";
                filepath = Server.MapPath(uploadPath) + name;
                file.SaveAs(filepath);
                imgPic.ImageUrl = uploadPath + name;
            }
        }

        protected void RadDropDownListFather_SelectedIndexChanged(object sender, DropDownListEventArgs e)
        {
            RadDropDownListSon.Items.Clear();
            RadDropDownListSon.Items.Add(new DropDownListItem("请选择", ""));
            RadDropDownListSon.DataSource = CommoditySon_Bll.GetList(" CommodityFatherID ='" + RadDropDownListFather.SelectedValue + "'  ");
            RadDropDownListSon.DataTextField = "CommoditySonName";
            RadDropDownListSon.DataValueField = "CommoditySonID";
            RadDropDownListSon.DataBind();
            RadDropDownListSon.SelectedText = "请选择";
        }

        protected void RadDropDownListFather_Load(object sender, EventArgs e)
        {

        }
    }
}