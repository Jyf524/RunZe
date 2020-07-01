<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BackFatherchange.aspx.cs" Inherits="RunZe.BackManagement.BackFatherchange" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <script type="text/javascript">
         //关闭模式窗口
         function GetRadWindow() {
             var oWnd = null;
             if (window.radWindow) oWnd = window.radWindow;
             else if (window.frameElement.radWindow) oWnd = window.frameElement.radWindow;
             return oWnd;
         }
         function GetClose() {
             var oWnd = GetRadWindow();
             oWnd.Close();
         }
         function CloseAndRebind(args) {
             GetRadWindow().Close();
             GetRadWindow().BrowserWindow.refreshGrid(args);
         }
    </script>
</head>
<body>
    <form id="form1" runat="server">
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
    <div class="content_main_right" style="text-align:center">
 <div class="content_main_flb">
  <div class="content_main_word">
      <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
      </telerik:RadAjaxManager>
 商品父类别信息
 </div>
 <div class="content_flbxg">
 父类别:<telerik:RadTextBox ID="RadTextBox1" runat="server" LabelWidth="64px" Resize="None" Width="160px"></telerik:RadTextBox>
&nbsp;</div>
<div class="content_main_right_btnq">
    <asp:Button ID="Button1" runat="server" Text="确认" CssClass="content_main_right_btn_checkflb1" OnClick="Button1_Click"  />
    <asp:Button ID="Button2" runat="server" Text="返回" CssClass="content_main_right_btn_checkflb2" OnClick="Button2_Click" />
 </div>
 </div>
 </div>
    </div>
    </form>
</body>
</html>
