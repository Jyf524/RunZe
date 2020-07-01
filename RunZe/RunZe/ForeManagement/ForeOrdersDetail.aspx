<%@ Page Title="" Language="C#" MasterPageFile="~/ForeManagement/ForeManagement.Master" AutoEventWireup="true" CodeBehind="ForeOrdersDetail.aspx.cs" Inherits="RunZe.ForeManagement.ForeOrdersDetail" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/ForeOrderDetail.css" rel="stylesheet" />
    <style type="text/css">
        #TextArea1 {
            height: 122px;
            width: 250px;
        }

        .auto-style1 {
            height: 40px;
            width: 200px;
        }

        .auto-style2 {
            height: 82px;
            width: 460px;
        }

        .auto-style3 {
            width: 460px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="ddlprovince">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddlprovince" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddlcity" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ddlcity">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddlprovince" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ddlcity" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <div id="content_k">
        <div class="content_nav_kk">
            <div class="content_nav">
                <div class="content_nav_word">
                    订单详细
                </div>
            </div>
        </div>
        <div class="content_k2">
            <div id="content">
                <div class="table_k">
                    <table style="height: 417px; width: 315px; margin: auto">
                        <tr>
                            <td class="auto-style1">
                                <strong>收件人：</strong>
                            </td>
                            <td>
                                <telerik:RadTextBox ID="RadTextBox1" runat="server"></telerik:RadTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <strong>收件人地址</strong>：
                            </td>
                            <td>
                                <telerik:RadDropDownList ID="ddlprovince" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="ddlprovince_SelectedIndexChanged">
                                </telerik:RadDropDownList>
                            </td>
                            <td>
                                <telerik:RadDropDownList ID="ddlcity" runat="server" AppendDataBoundItems="true" AutoPostBack="true">
                                </telerik:RadDropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <strong>收件人详细地址：</strong>
                            </td>
                            <td>
                                <telerik:RadTextBox ID="RadTextBox2" runat="server"></telerik:RadTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <strong>收件人邮编:</strong>
                            </td>
                            <td>
                                <telerik:RadTextBox ID="RadTextBox3" runat="server"></telerik:RadTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <strong>收件人联系电话:</strong>
                            </td>
                            <td>
                                <telerik:RadTextBox ID="RadTextBox4" runat="server"></telerik:RadTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <strong>积分换购：</strong>
                                </td>
                            <td>
                                <telerik:RadNumericTextBox ID="RadTextBox5" runat="server"  MinValue="0" MaxValue="999999999" NumberFormat-DecimalDigits="0"></telerik:RadNumericTextBox>
                                </td>
                            <td>
                                可用积分：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </td>

                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <strong>送货方式：</strong>
                            </td>
                            <td>
                                <telerik:RadDropDownList ID="RadDropDownList1" runat="server">
                                    <Items>
                                        <telerik:DropDownListItem Text="普通快递送货上门" Value="1" />
                                        <telerik:DropDownListItem Text="加急快递送货上门" Value="2" />
                                        <telerik:DropDownListItem Text="普通邮递" Value="3" />
                                    </Items>
                                </telerik:RadDropDownList>
                                    </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <strong>支付方式：</strong>
                                </td>
                            <td>
                                <telerik:RadDropDownList ID="RadDropDownList2" runat="server">
                                    <Items>
                                        <telerik:DropDownListItem Text="支付宝" Value="1" />
                                        <telerik:DropDownListItem Text="微信" Value="2" />
                                        <telerik:DropDownListItem Text="银联" Value="3" />
                                    </Items>
                                </telerik:RadDropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <strong>留言：</strong>
                            </td>
                            <td>
                                <textarea id="TextArea1" runat="server"></textarea>
                            </td>
                        </tr>
                        <tr>
                            <td >
                                <div class="btn_check_k">
                                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn_check" OnClick="LinkButton1_Click">提交</asp:LinkButton>
                                </div>

                            </td>
                            <td>
                                <div class="btn_check_k">
                                    <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn_check" OnClick="LinkButton2_Click">返回</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                    </table>
                    <div class="content_word_k">
                        <div class="content_word">
                            请您在一周内依据您选择的支付方式进行汇款，汇款时请注明您的订单号。为了更及时地为您服务，当您汇完款，请至网站留言！
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
