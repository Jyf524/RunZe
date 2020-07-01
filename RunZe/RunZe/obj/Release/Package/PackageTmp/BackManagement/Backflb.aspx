<%@ Page Title="" Language="C#" MasterPageFile="~/BackManagement/BackManagement.Master" AutoEventWireup="true" CodeBehind="Backflb.aspx.cs" Inherits="RunZe.BackManagement.Backflb" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js">
            </asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>
    <div class="content_main">

 <div class="content_main_right">
 <div class="content_main_flb">
  <div class="content_main_word">
 商品父类别信息
 </div>
 <div class="content_flbxg">
 父类别:<telerik:RadTextBox ID="RadTextBox1" Runat="server" Text="家电" LabelWidth="64px" Resize="None" Width="160px">
     </telerik:RadTextBox>
&nbsp;</div>
<div class="content_main_right_btnq">
    <asp:Button ID="Button1" runat="server" Text="确认" CssClass="content_main_right_btn_checkflb1" OnClick="Button1_Click"/>
    <asp:Button ID="Button2" runat="server" Text="返回" CssClass="content_main_right_btn_checkflb2" OnClick="Button2_Click"/>
 </div>
 </div>
 </div>
 </div>
</asp:Content>
