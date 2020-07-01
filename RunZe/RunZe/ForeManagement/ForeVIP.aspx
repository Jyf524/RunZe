<%@ Page Title="" Language="C#" MasterPageFile="~/ForeManagement/ForeManagement.Master" AutoEventWireup="true" CodeBehind="ForeVIP.aspx.cs" Inherits="RunZe.ForeManagement.ForeVIP" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/ForeVIP.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server"></telerik:RadAjaxManager>
    <div id="content_k">
        <div class="content_nav_kk">
            <div class="content_nav">
                <div class="content_nav_word">
                    个人资料
                </div>
            </div>
        </div>
        <div id="content">
            <div class="content_main_yhxxxx">
                <div class="content_main_word">
                </div>
                <table class="content_main_information">
                    <tr style="height:40px;">
                        <th class="auto-style1">用户名：</th>
                        <td class="auto-style1">
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                      <tr style="height:40px;">
                        <th class="auto-style2">姓 &nbsp;&nbsp;&nbsp;名：</th>
                        <td class="auto-style2">
                            <telerik:RadTextBox ID="RadTextBox2" runat="server"></telerik:RadTextBox></td>
                    </tr>
                      <tr style="height:40px;">
                        <th class="auto-style2">性 &nbsp;&nbsp;&nbsp;别：</th>
                        <td class="auto-style2">
                            <asp:RadioButton ID="Rad_nan" runat="server" Text="男" Checked="True" GroupName="RadSex" />
                            &nbsp;
        <asp:RadioButton ID="Rad_nv" runat="server" Text="女" GroupName="RadSex" />
                        </td>
                    </tr>
                      <tr style="height:40px;">
                        <th class="auto-style1">邮箱：</th>
                        <td class="auto-style1">
                            <telerik:RadTextBox ID="RadTextBox3" runat="server"></telerik:RadTextBox></td>
                    </tr>
                      <tr style="height:40px;">
                        <th class="auto-style1">注册日期：</th>
                        <td class="auto-style1">
                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr style="height:40px;">
                        <th class="auto-style1">个人积分：</th>
                        <td class="auto-style1">
                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                      <tr style="height:40px;">
                        <th class="auto-style3">所在地：</th>
                        <td class="auto-style3">
                            <telerik:RadDropDownList ID="ddlprovince" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="ddlprovince_SelectedIndexChanged">
                            </telerik:RadDropDownList>
                            <telerik:RadDropDownList ID="ddlcity" runat="server" AppendDataBoundItems="true" AutoPostBack="true">
                            </telerik:RadDropDownList>
                        </td>
                    </tr>
                      <tr style="height:40px;">
                        <th class="auto-style2">详细地址：</th>
                        <td class="auto-style2">
                            <telerik:RadTextBox ID="RadTextBox6" runat="server"></telerik:RadTextBox>
                        </td>
                    </tr>
                </table>
                <div class="content_main_right_btnc_k">
                    <div class="content_main_right_btnc">
                        <asp:Button ID="Button1" runat="server" Text="修改" CssClass="content_main_right_btn_check" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="返回" CssClass="content_main_right_btn_check2" OnClick="Button2_Click" />
                        <asp:Button ID="Btn_change" runat="server" Text="修改密码"  CssClass="content_main_right_btn_check3" OnClick="Btn_change_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
