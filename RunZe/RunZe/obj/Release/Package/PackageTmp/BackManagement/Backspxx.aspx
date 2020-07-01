<%@ Page Title="商品详细" Language="C#" MasterPageFile="~/BackManagement/BackManagement.Master" AutoEventWireup="true" CodeBehind="Backspxx.aspx.cs" Inherits="RunZe.BackManagement.Backspxx" %>

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
    <style type="text/css">
        .auto-style5 {
            height: 34px;
        }

        .auto-style6 {
            height: 31px;
        }

        .auto-style7 {
            height: 33px;
        }

        .auto-style8 {
            height: 29px;
        }

        .auto-style9 {
            height: 32px;
        }

        .auto-style10 {
            height: 27px;
        }

        .auto-style11 {
            height: 35px;
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
    <div class="content_main_right">
        <div class="content_main_yhxxxx">
            <div class="content_main_word">
                商品信息
            </div>
            <table class="content_main_information">
                <tr>
                    <th class="auto-style6">商品名称：</th>
                    <td class="auto-style6">
                        <telerik:RadTextBox ID="RadTextBox1" runat="server" LabelWidth="64px" Resize="None" Width="160px" MaxLength="40"></telerik:RadTextBox></td>
                </tr>
                <tr>
                    <th class="auto-style7">品牌：</th>
                    <td class="auto-style7">
                        <telerik:RadTextBox ID="RadTextBox2" runat="server" MaxLength="20"></telerik:RadTextBox></td>
                </tr>
                <tr>
                    <th>商品图片:</th>
                    <td>
                        <asp:Image ID="imgPic" runat="server" Width="200" Height="160" />

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
                    <th class="auto-style8">市场价：</th>
                    <td class="auto-style8">
                        <telerik:RadNumericTextBox ID="RadNumericTextBox1" runat="server" MaxLength="20">
                        </telerik:RadNumericTextBox></td>
                </tr>
                <tr>
                    <th class="auto-style9">会员价：</th>
                    <td class="auto-style9">
                        <telerik:RadNumericTextBox ID="RadNumericTextBox2" runat="server" MaxLength="20">
                        </telerik:RadNumericTextBox></td>
                </tr>
                <tr>
                    <th class="auto-style7">父类别：</th>
                    <td class="auto-style7">
                        <telerik:RadDropDownList ID="RadDropDownListFather" runat="server" OnLoad="RadDropDownListFather_Load" OnSelectedIndexChanged="RadDropDownListFather_SelectedIndexChanged" AppendDataBoundItems="true" AutoPostBack="true"></telerik:RadDropDownList>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style5">子类别：</th>
                    <td class="auto-style5">
                        <telerik:RadDropDownList ID="RadDropDownListSon" runat="server" AppendDataBoundItems="true" AutoPostBack="true"></telerik:RadDropDownList>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style9">购买积分：</th>
                    <td class="auto-style9">
                        <telerik:RadNumericTextBox ID="RadNumericTextBox3" runat="server" NumberFormat-DecimalDigits="0" MaxLength="20">
                        </telerik:RadNumericTextBox></td>
                </tr>
                <tr>
                    <th class="auto-style11">是否推荐：</th>
                    <td class="auto-style11">
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="推荐" GroupName="State" />
                        <asp:RadioButton ID="RadioButton4" runat="server" Text="不推荐" GroupName="State" /></td>
                </tr>
                <tr>
                    <th class="auto-style5">库存：</th>
                    <td class="auto-style5">
                        <telerik:RadNumericTextBox ID="RadNumericTextBox4" runat="server" NumberFormat-DecimalDigits="0" MaxLength="20">
                        </telerik:RadNumericTextBox></td>
                </tr>
                <tr>
                    <th class="auto-style6">商品状态：</th>
                    <td class="auto-style6">
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="上架" GroupName="Recommend" />
                        <asp:RadioButton ID="RadioButton3" runat="server" Text="下架" GroupName="Recommend" /></td>
                </tr>
                <tr>
                    <th>简介：</th>
                    <td>
                        <textarea id="myEditor" name="myEditor" runat="server" onblur="setUeditor()" style="width: 200px; height: 50px;"></textarea></td>
                </tr>
            </table>
            <div class="content_main_right_btna">
                <asp:Button ID="Button1" runat="server" Text="修改" CssClass="content_main_right_btn_check" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="返回" CssClass="content_main_right_btn_check2" OnClick="Button2_Click" />
            </div>
        </div>
    </div>
</asp:Content>
