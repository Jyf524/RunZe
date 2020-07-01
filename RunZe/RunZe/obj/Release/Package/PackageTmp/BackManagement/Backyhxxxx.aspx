<%@ Page Title="用户详细信息" Language="C#" MasterPageFile="~/BackManagement/BackManagement.Master" AutoEventWireup="true" CodeBehind="Backyhxxxx.aspx.cs" Inherits="RunZe.BackManagement.Backyhxxxx" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 60px;
        }
        .auto-style2 {
            height: 61px;
        }
        .auto-style3 {
            height: 59px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server"></telerik:RadAjaxManager>
    <div class="content_main_right">
        <div class="content_main_yhxxxx">
            <div class="content_main_word">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 用户信息
            </div>
            <table class="content_main_information">
                <tr>
                    <th class="auto-style1">用户名：</th>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th class="auto-style2">姓 &nbsp;&nbsp;&nbsp;名：</th>
                    <td class="auto-style2">
                        <telerik:RadTextBox ID="RadTextBox2" runat="server" OnLoad="RadTextBox2_Load"></telerik:RadTextBox></td>
                </tr>
                <tr>
                    <th class="auto-style2">性 &nbsp;&nbsp;&nbsp;别：</th>
                    <td class="auto-style2">
                        <asp:RadioButton ID="Rad_nan" runat="server" Text="男" Checked="True" GroupName="RadSex" />
                        &nbsp;
        <asp:RadioButton ID="Rad_nv" runat="server" Text="女" GroupName="RadSex" />
                    </td>
                </tr>
                <tr>
                    <th class="auto-style1">邮箱：</th>
                    <td class="auto-style1">
                        <telerik:RadTextBox ID="RadTextBox3" runat="server"></telerik:RadTextBox></telerik:RadTextBox></td>
                </tr>
                <tr>
                    <th class="auto-style1">注册日期：</th>
                    <td class="auto-style1">
                        <telerik:RadDatePicker ID="RadDatePicker1" runat="server"></telerik:RadDatePicker>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style3">所在地：</th>
                    <td class="auto-style3">
                        <telerik:RadDropDownList ID="ddlprovince" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="ddlprovince_SelectedIndexChanged">
                        </telerik:RadDropDownList>
                        <telerik:RadDropDownList ID="ddlcity" runat="server" AppendDataBoundItems="true" AutoPostBack="true">
                        </telerik:RadDropDownList>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style2">详细地址：</th>
                    <td class="auto-style2">
                        <telerik:RadTextBox ID="RadTextBox6" runat="server" OnLoad="RadTextBox6_Load"></telerik:RadTextBox>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style3">会员积分：</th>
                    <td class="auto-style3">
                        <telerik:RadNumericTextBox ID="RadNumericTextBox1" runat="server" NumberFormat-DecimalDigits="0" Culture="zh-CN" DbValueFactor="1" LabelWidth="64px" MinValue="0" Width="160px"></telerik:RadNumericTextBox>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style1">会员等级：</th>
                    <td class="auto-style1">
                        <telerik:RadDropDownList ID="RadDropDownList1" runat="server">
                            <Items>
                                <telerik:DropDownListItem Text="请选择" Value="" />
                                <telerik:DropDownListItem Text="会员" Value="1" />
                                <telerik:DropDownListItem Text="VIP" Value="2" />
                            </Items>
                        </telerik:RadDropDownList>
                    </td>
                </tr>
            </table>

            <div class="content_main_right_btnc">
                <asp:Button ID="Button1" runat="server" Text="修改" CssClass="content_main_right_btn_check" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="返回" CssClass="content_main_right_btn_check2" OnClick="Button2_Click" />
            </div>
        </div>
    </div>
</asp:Content>
