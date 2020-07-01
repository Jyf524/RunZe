<%@ Page Title="商品详细" Language="C#" MasterPageFile="~/ForeManagement/ForeManagement.Master" AutoEventWireup="true" CodeBehind="Forespxx.aspx.cs" Inherits="RunZe.ForeManagement.Forespxx" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/Forespxx.css" rel="stylesheet" />
    <script src="../js/jquery.min.js"></script>
    <script src="../js/indexjs.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        img
        {
            max-width: 1000px;
        }
    </style>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="Btn_jian">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Commoditynum" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Btn_add">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Commoditynum" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <div id="content">
        <div class="content_main_left_k">
            <div class="image_k">
                <asp:Image ID="Image1" runat="server" Width="300px" Height="300px" />
            </div>
            <div class="content_main_left_sc">
                <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" />
            </div>
            <div class="content_main_left_score" runat="server">
                评分：
                <div class="lbl_pf">
                    <asp:Label ID="lbl_pf" runat="server" ></asp:Label>

                </div>
            </div>
            <div id="content_main_left_score2" runat="server">
                <telerik:RadRating ID="RadRating1" runat="server" ItemCount="4"></telerik:RadRating>
                <telerik:RadButton ID="Button2" runat="server" Text="评价" Skin="Web20" OnClick="Button2_Click1"></telerik:RadButton>
            </div>
        </div>
        <div class="content_main_right_k">
            <div class="content_main_right_spname">
                <asp:Label ID="Label1" runat="server" Text="商品名"></asp:Label>
            </div>
            <div class="content_main_right_sppp">
                品牌：<asp:Label ID="Label2" runat="server" Text="品牌"></asp:Label>
            </div>
            <div class="content_main_right_spMarketPrice">
                市场价：<asp:Label ID="Label3" runat="server" Text="市场价"></asp:Label>
            </div>
            <div class="content_main_right_spVIPPrice">
                会员价：<asp:Label ID="Label4" runat="server" Text="会员价"></asp:Label>
            </div>
            <div class="content_main_right_spxiaoliang">
                销量：<asp:Label ID="Label6" runat="server" Text="销量"></asp:Label>
            </div>
            <div class="content_main_right_spkucun">
                库存：<asp:Label ID="Label7" runat="server" Text="库存"></asp:Label>
            </div>
            <div class="content_main_right_spNumber">
                <asp:Button ID="Btn_jian" runat="server" CssClass="content_btnjian" Text="-" OnClick="Btn_jian_Click"/>
                <div class="content_txtnum1">
                    <telerik:RadNumericTextBox ID="Commoditynum" NumberFormat-DecimalDigits="0" MinValue="1" MaxValue="9999999" runat="server" CssClass="content_table_txtnum" Height="25px" Width="70px" MaxLength="7"></telerik:RadNumericTextBox>
                </div>
                <asp:Button ID="Btn_add" runat="server" CssClass="content_btnadd" Text="+" OnClick="Btn_add_Click"/>

            </div>
            <div class="content_main_right_spxiaoliang">
                状态：<asp:Label ID="Label5" runat="server" Text="状态"></asp:Label>
            </div>
            <div class="content_main_right_btn_buy">
                <asp:Button ID="Button1" runat="server" CssClass="content_main_right_btn_check" Text="立即购买" OnClick="Button1_Click" />
            </div>
        </div>
        <div class="content_spjj">
            <div class="content_spjj_word">商品简介:</div>
            <asp:Label ID="Label8" runat="server" Text="Label" Visible="false"></asp:Label>
        </div>
    </div>
</asp:Content>
