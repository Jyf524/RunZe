<%@ Page Title="会员登录" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RunZe.Login" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/Login_css.css" rel="stylesheet" />
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
        <div>
            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server"></telerik:RadAjaxManager>
            <div id="header">
                <div class="header_k">
                    <a href="HomePage.aspx">
                    <div class="header_logo"></div>
                    <div class="header_logoworld1">润泽电商</div>
                    <div class="header_logoworld2">runze.com</div>
                        </a>
                </div>
            </div>
            <div id="content">
                <div id="content_k">
                    <div class="content_banner"></div>
                    <div class="content_Login">
                        <div class="content_username">
                            用户名：
          <telerik:RadTextBox ID="RadTextBox1" runat="server" CssClass="lbl_user" LabelWidth="64px" Resize="None" Width="160px"></telerik:RadTextBox>
                            <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Red" Font-Size="12px" Visible="False"></asp:Label>
                        </div>
                        <div class="content_password">
                            密&nbsp;&nbsp;&nbsp;码：
                            <telerik:RadTextBox ID="RadTextBox3" runat="server" CssClass="lbl_password" TextMode="Password"></telerik:RadTextBox>
                            <asp:Label ID="Label2" runat="server" Text="Label" ForeColor="Red" Font-Size="12px" Visible="False"></asp:Label>
                        </div>
                        <div class="content_code_k">
                            <div class="content_code_word">
                                验证码：
                            </div>
                            <div style="float:left">
                            <telerik:RadTextBox ID="RadTextBox2" runat="server" CssClass="lbl_code" Width="80px"></telerik:RadTextBox>
                                </div>
                            <div class="content_code">
                                <img src="../code/ValidateCode.aspx" onclick="this.src='../code/ValidateCode.aspx?'+Math.random();" id="imgValidateCode"  style="cursor: pointer;" />
                                <asp:Label ID="Label3" runat="server" Font-Size="12px" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                            </div>
                        </div>
                        <div class="content_Logincheck">
                            <asp:Button ID="Button1" runat="server" Text="登录" CssClass="lbl_Login" OnClick="Button1_Click" />

                        </div>
                        <div class="content_Logincheck2">
                            <asp:Button ID="Button2" runat="server" Text="注册" CssClass="lbl_Login2" OnClick="Button2_Click" />
                        </div>
                    </div>
                        

                    </div>
                </div>
            </div>
            <div id="footer">
                <div class="footer_copyright">
                    <p>请使用 1024*768 IE7.0 或更高版本浏览器浏览本站点, 以保证最佳阅读效果</p>
                    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;公司电话: 010-88588888/22/23/24/25 公司传真: 86-10-88588888</p>
                    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;客服热线: 800-810-1118/400-810-1118  E-mail：yi@163.com </p>
                    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; © Copyright  2011 润泽电子商城 版权所有 All Rights Reserved</p>
                    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;京ICP证354878号 经营许可证&nbsp;<img src="image/copyright.png" width="128" height="47" />&nbsp;&nbsp;&nbsp;</p>
                <a href="BackLogin.aspx" class="backlogin">管理登录</a>
                </div>
            </div>
    </form>
</body>
</html>
