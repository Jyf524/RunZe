<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BackLogin.aspx.cs" Inherits="RunZe.BackLogin" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/Login_css2.css" rel="stylesheet" />
    <title></title>
</head>
<body style="background:url(../image/background.png) repeat">
    <form id="form1" runat="server">
    <div>
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
    <div>
    
<div id="header">
  <div class="header_k">
    <div class="header_logoworld1">润泽电商后台管理系统</div>
  </div>
</div>
<div id="content">
  <div id="content_k">
    <div class="content_Login">
      <div class="content_username"> 用户名：
          <telerik:RadTextBox ID="RadTextBox1" runat="server" CssClass="lbl_user" LabelWidth="64px" Resize="None" Width="160px"></telerik:RadTextBox>
          <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Red" Font-Size="12px" Visible="False"></asp:Label>
      </div>
      <div class="content_password"> 密&nbsp;&nbsp;&nbsp;码：
          <telerik:RadTextBox ID="RadTextBox3" runat="server" TextMode="Password"></telerik:RadTextBox>
          <asp:Label ID="Label2" runat="server" Text="Label" ForeColor="Red" Font-Size="12px" Visible="False"></asp:Label>
      </div>
            <div class="content_code">
              验证码：
                <telerik:RadTextBox ID="RadTextBox2" runat="server" CssClass="lbl_code" Width="80px"></telerik:RadTextBox>
                 <img src="../code/ValidateCode.aspx" onclick="this.src='../code/ValidateCode.aspx?'+Math.random();" id="imgValidateCode" alt="点击刷新验证码" title="点击刷新验证码" style="cursor: pointer;" />
      </div>
         <asp:Label ID="Label3" runat="server" Text="Label" ForeColor="Red" Font-Size="12px" Visible="False" ></asp:Label>

      <div class="content_Logincheck">
          <asp:Button ID="Button1" runat="server" Text="登录" CssClass="lbl_Login" OnClick="Button1_Click" />
        
      </div>

    </div>
  </div>
</div>
<div id="footer">
<div class="footer_copyright">
    <a href="/Login.aspx" class="word">前台登录</a>
</div>
</div>

    </div>
    </div>
    </form>
</body>
</html>
