<%@ Page Title="订单信息" Language="C#" MasterPageFile="~/BackManagement/BackManagement.Master" AutoEventWireup="true" CodeBehind="Backddxx.aspx.cs" Inherits="RunZe.BackManagement.Backddxx" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>
    <br />
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    <div class="content_main_right">
        <div class="content_main_yhxxxx">
            <div class="content_main_word">
                订单信息
            </div>
            <table class="content_main_information">
                <tr>
                    <th>订单号： </th>
                    <td>
                        <asp:Label ID="Lbl_ddh" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>送货方式：</th>
                    <td>
                        <asp:Label ID="Lbl_shfs" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>收货人信息：</th>
                    <td>
                        <asp:Label ID="Lbl_shrxx" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>支付方式:</th>
                    <td>
                        <asp:Label ID="Lbl_zffs" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>金额：</th>
                    <td>
                        <asp:Label ID="Lbl_money" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>订单状态:</th>
                    <td>
                        <asp:Label ID="Lbl_State" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
            <table class="content_list_table_k" style="border-spacing: 0; padding: 0; border: 0;">
                <tr>
                    <td style="width: 120px;">商品图片</td>
                    <td style="width: 120px;">商品名称</td>
                    <td style="width: 120px;">商品数量</td>
                </tr>
            </table>
            <telerik:RadListView ID="RadListView1" runat="server" AllowPaging="true" PageSize="5" OnItemCommand="RadListView1_ItemCommand" OnNeedDataSource="RadListView1_NeedDataSource">
                <ItemTemplate>
                    <table class="content_list_table" style="border-spacing: 0; padding: 0; border: 0; font-size: 14px;">
                        <tr>
                            <td style="width: 200px;">
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("CommodityImage") %>' Width="100" Height="100" />
                            </td>
                            <td style="width: 200px;">
                                <div class="jiequ_k">
                                    <div class="jiequ">
                                        <%#Eval("CommodityName") %>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 200px;">
                                <%#Eval("OrderNumber") %>
                            </td>
                    </table>
                </ItemTemplate>
                <EmptyDataTemplate>
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/image/none.png" />
                </EmptyDataTemplate>
            </telerik:RadListView>
            <div class="content_fy">
                <table style="margin: auto">
                    <tr>
                        <td>
                            <telerik:RadDataPager ID="RadDataPager1" runat="server" PageSize="5" PagedControlID="RadListView1" Skin="Metro">
                                <Fields>
                                    <telerik:RadDataPagerButtonField FieldType="FirstPrev" FirstButtonText="首页" PrevButtonText="上一页" />
                                    <telerik:RadDataPagerButtonField FieldType="Numeric" />
                                    <telerik:RadDataPagerButtonField FieldType="NextLast" LastButtonText="尾页" NextButtonText="下一页" />
                                </Fields>
                            </telerik:RadDataPager>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="content_main_right_btnz">
                <asp:Button ID="Button1" runat="server" Text="发货" CssClass="content_main_right_btn_check" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="返回" CssClass="content_main_right_btn_check2" OnCommand="Button2_Command" />
            </div>
        </div>
    </div>
</asp:Content>
