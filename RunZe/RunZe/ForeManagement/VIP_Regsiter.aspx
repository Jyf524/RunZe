<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VIP_Regsiter.aspx.cs" Inherits="RunZe.ForeManagement.VIP_Regsiter" Title="会员注册" %> 

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../css/ForeManagement.css" rel="stylesheet" />
     <style type="text/css">
        .auto-style4
        {
            width: 21%;
            height: 50px;
            margin-top: 20px;
        }

        .auto-style6
        {
            width: 25%;
        }

        .auto-style7
        {
            width: 200px;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
            </Scripts>
        </telerik:RadScriptManager>
        <div id="header">
            <div class="header_k">
                <div class="header_text">
                    <a class="header_text_a_1" href="../Login.aspx">请登录&nbsp; &nbsp; </a>
                    <a class="header_text_a" href="VIP_Regsiter.aspx">免费注册</a>
                </div>
                <div class="header_text_2">
                    <a href="../Homepage.aspx" class="header_text_a">首页</a>
                    <b class="header_text_a">|</b>
                    <a class="header_text_a" href="/ForeManagement/ShoppingCart.aspx">购物车</a>
                    <b class="header_text_a">|</b>
                    <a class="header_text_a" href="ForeCollect.aspx">收藏夹</a>
                    <b class="header_text_a">|</b>
                    <a class="header_text_a" href="ForeMyOrder.aspx">我的订单</a>
                </div>
            </div>
            <div class="header_logo">
                <a  class="header_logo_word header_logo_a">&nbsp; 润泽电商<br />
                    Runze.com</a>
            </div>
        </div>
        <div id="content">
            <div class="content_text">
                <div class="content_text_1">用户注册:</div>
            </div>
            <div class="content_main">
                <div class="content_main_1">

                    <table class="content_main_table">
                        <tr class="content_main_tr">
                            <td class="auto-style6">用户名:</td>
                            <td class="auto-style7">
                                <telerik:RadTextBox ID="txtUserName" MaxLength="12" runat="server" LabelWidth="64px" Resize="None" Width="160px">
                                </telerik:RadTextBox>
                            </td>
                            <td>
                                <asp:Label ID="lblUserName" runat="server" Text="" ForeColor="Red"></asp:Label></td>
                        </tr>
                        <tr class="content_main_tr">
                            <td class="auto-style6">密码:</td>
                            <td class="auto-style7">
                                <telerik:RadTextBox ID="txtPassword" MaxLength="12" runat="server" MaxLength="30" TextMode="Password"></telerik:RadTextBox></td>
                            <td>
                                <asp:Label ID="lblPassword" runat="server" Text="" ForeColor="Red"></asp:Label></td>

                        </tr>
                        <tr class="content_main_tr">
                            <td class="auto-style6">确认密码:</td>
                            <td class="auto-style7">
                                <telerik:RadTextBox ID="txtPassword2" MaxLength="12" runat="server" MaxLength="30" TextMode="Password"></telerik:RadTextBox></td>
                            <td>
                                <asp:Label ID="lblPassword2" runat="server" Text="" ForeColor="Red"></asp:Label></td>

                        </tr>

                        <tr class="content_main_tr">
                            <td class="auto-style6">手机号:</td>
                            <td class="auto-style7">
                                <telerik:RadTextBox ID="txtphone" runat="server" MaxLength="11" ></telerik:RadTextBox></td>
                            <td>
                                <asp:Label ID="lblphone" runat="server" Text="" ForeColor="Red"></asp:Label></td>

                        </tr>

                        <tr class="content_main_tr">
                            <td class="auto-style6">电子邮箱:</td>
                            <td class="auto-style7">
                                <telerik:RadTextBox ID="txtEmail" runat="server" MaxLength="20"></telerik:RadTextBox></td>
                            <td>
                                <asp:Label ID="lblEmail" runat="server" Text="" ForeColor="Red"></asp:Label></td>
                        </tr>

                        <tr>
                            <td class="auto-style4">验证码:</td>
                            <td colspan="2" class="auto-style7">
                                <!--验证码框-->
                                <div class="cl_input1">
                                    <telerik:RadTextBox ID="txtcode" runat="server" Height="25px" Width="97px" MaxLength="10"></telerik:RadTextBox>
                                    <%--                                    <asp:Label ID="Label3" runat="server" Text="" ForeColor="Red"></asp:Label>--%>
                                </div>
                                <!--验证码框-->
                                <div class="cl_input_yanzhengma">
                                    <img src="../Code/ValidateCode.aspx" onclick="this.src='../Code/ValidateCode.aspx?'+Math.random();" id="imgValidateCode" alt="点击刷新验证码" title="点击刷新验证码" style="cursor: pointer;" />
                                </div>
                                <asp:Label ID="lblcode" runat="server" Text="" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>

                    </table>
                    <div class="zctk">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="同意" />
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">注册条款</asp:LinkButton>
                        </div>
                    <div class="content_button">
                        <asp:Button ID="btnlogin" runat="server" Text="注册" CssClass="cl_login" OnClick="btnlogin_Click" />
                    </div>
                </div>
            </div>
            <div class="content_footer"></div>
        </div>
        <div id="footer">
            <div class="footer_text">请使用 1024*768 IE7.0 或更高版本浏览器浏览本站点, 以保证最佳阅读效果</div>
            <div class="footer_text">公司电话: 010-88588888/22/23/24/25 公司传真: 86-10-88588888</div>
            <div class="footer_text">客服热线: 800-810-1118/400-810-1118  E-mail：yi@163.com</div>
            <div class="footer_text">© Copyright  2011 润泽电子商城 版权所有 All Rights Reserved</div>
            <div class="footer_text1">
                京ICP证354878号 经营许可证
                <img src="../image/copyright.png" width="128" height="47" />
                <a href="../BackLogin.aspx">管理登录</a>
            </div>
        </div>
    </form>
</body>
</html>
