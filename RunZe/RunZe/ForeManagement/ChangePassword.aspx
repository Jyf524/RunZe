<%@ Page Title="" Language="C#" MasterPageFile="~/ForeManagement/ForeManagement.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="RunZe.ForeManagement.ChangePassword" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/ChangePassword.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server"></telerik:RadAjaxManager>
    <div id="content_k">
        <div class="content_nav_kk">
            <div class="content_nav">
                <div class="content_nav_word">
                    修改密码
                </div>
            </div>
        </div>
        <div id="content">
            <div class="content_word">
            原密码：<telerik:RadTextBox ID="RadTextBox1" runat="server" TextMode="Password"></telerik:RadTextBox>
            <br /><br />
            新密码：<telerik:RadTextBox ID="RadTextBox2" runat="server" TextMode="Password"></telerik:RadTextBox>
            <br /><br />
            确认密码：<telerik:RadTextBox ID="RadTextBox3" runat="server" TextMode="Password"></telerik:RadTextBox>
                </div>
            <div class="content_btn">
                <asp:Button ID="Btn_Check" runat="server" Text="确定" CssClass="content_Check" OnClick="Btn_Check_Click" />
                <asp:Button ID="Btn_Back" runat="server" Text="返回" CssClass="content_Back" OnClick="Btn_Back_Click" />
            </div>
        </div>
    </div>
</asp:Content>
