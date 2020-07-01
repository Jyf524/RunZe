<%@ Page Title="添加商品" Language="C#" MasterPageFile="~/BackManagement/BackManagement.Master" AutoEventWireup="true" CodeBehind="Backspadd.aspx.cs" Inherits="RunZe.BackManagement.Backspadd" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function setUeditor() {
            var myEditor = document.getElementById("myEditor");
            myEditor.value = editor.getContent();//把得到的值给textarea
        }
    </script>
    <script src="../ueditor/ueditor.config.js" type="text/javascript"></script>
    <script src="../ueditor/ueditor.all.min.js" type="text/javascript"></script>
    <script type="text/javascript" charset="utf-8" src="../ueditor/lang/zh-cn/zh-cn.js"></script>
    <script type="text/javascript">
        var editor = new baidu.editor.ui.Editor();
        <%--editor.render("<%=myEditor.ClientID%>");--%>
        editor.render("<%=myEditor.ClientID%>");
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="imgPic" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="rauFiles" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadDropDownListFather">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadDropDownListFather" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="RadDropDownListSon" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadDropDownListSon">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadDropDownListFather" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="RadDropDownListSon" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="myEditor">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="myEditor" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <table class="content_main_spadd_conntent">
        <tr>
            <th>商品名称：</th>
            <td>
                <telerik:RadTextBox ID="RadTextBox1" runat="server" LabelWidth="64px" Resize="None" Width="160px" MaxLength="20"></telerik:RadTextBox></td>
        </tr>
        <tr>
            <th>品牌：</th>
            <td>
                <telerik:RadTextBox ID="RadTextBox2" runat="server"></telerik:RadTextBox></td>
        </tr>
        <tr>
            <th>商品图片：</th>
            <td>
                <asp:Image ID="imgPic" runat="server" Width="200" Height="140" />

                <telerik:RadAsyncUpload ID="rauFiles" runat="server" Culture="zh-CN" AutoAddFileInputs="false" MaxFileInputsCount="1" OnFileUploaded="rauFiles_FileUploaded" OnClientFilesUploaded="OnClientFilesUploaded">
                    <Localization Cancel="取消" DropZone="拖动文件到此处" Remove="移除" Select="选择" />
                    <FileFilters>
                        <telerik:FileFilter Description="Images(jpeg,jpg,gif,png)" Extensions="jpeg,jpg,gif,png" />
                    </FileFilters>
                </telerik:RadAsyncUpload>
                <div id="Div1" runat="server">
                    <script type="text/javascript">
                        (function (global, undefined) {
                            var demo = {};

                            function OnClientFilesUploaded(sender, args) {
                                $find(demo.ajaxManagerID).ajaxRequest();
                            }

                            function serverID(name, id) {
                                demo[name] = id;
                            }

                            global.serverID = serverID;

                            global.OnClientFilesUploaded = OnClientFilesUploaded;
                        })(window)
                        //<![CDATA[
                        serverID("ajaxManagerID", "<%= RadAjaxManager1.ClientID %>");
                        //]]>
                    </script>
                </div>
            </td>
        </tr>

        <tr>
            <th>市场价： </th>
            <td>
                <telerik:RadNumericTextBox ID="RadNumericTextBox1" runat="server" MaxLength="20" MinValue="0">
                </telerik:RadNumericTextBox></td>
        </tr>
        <tr>
            <th>会员价： </th>
            <td>
                <telerik:RadNumericTextBox ID="RadNumericTextBox2" runat="server" MaxLength="20" MinValue="0">
                </telerik:RadNumericTextBox></td>
        </tr>
        <tr>
            <th>购买积分:</th>
            <td>

                <telerik:RadNumericTextBox ID="RadNumericTextBox3" runat="server">
                </telerik:RadNumericTextBox></td>
        </tr>
        <tr>
            <th>库存:</th>
            <td>

                <telerik:RadNumericTextBox ID="RadNumericTextBox4" runat="server" NumberFormat-DecimalDigits="0" MaxLength="20" MinValue="0">
                </telerik:RadNumericTextBox></td>
        </tr>

        <tr>
            <th>类别：</th>
            <td>

                <telerik:RadDropDownList ID="RadDropDownListFather" runat="server" OnLoad="RadDropDownList1_Load" OnSelectedIndexChanged="RadDropDownList1_SelectedIndexChanged" AppendDataBoundItems="true" AutoPostBack="true">
                </telerik:RadDropDownList>
                <telerik:RadDropDownList ID="RadDropDownListSon" runat="server" AppendDataBoundItems="true" AutoPostBack="true">
                </telerik:RadDropDownList>
            </td>
        </tr>

        <tr>
            <th>是否推荐：</th>
            <td>

                <asp:RadioButton ID="RadioButton1" runat="server" Text="推荐" GroupName="State" />
                <asp:RadioButton ID="RadioButton4" runat="server" Text="不推荐" Checked="True" GroupName="State" /></td>
        </tr>
        <tr>
            <th>简介： </th>
            <td>

                <textarea id="myEditor" name="myEditor" runat="server" onblur="setUeditor()" style="width: 400px; height: 100px;"></textarea></td>
        </tr>


    </table>
    <div class="content_main_right_btnq">
        <asp:Button ID="Button1" runat="server" Text="添加" CssClass="content_main_right_btn_check" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="返回" CssClass="content_main_right_btn_check2" OnClick="Button2_Click" />
    </div>
</asp:Content>
