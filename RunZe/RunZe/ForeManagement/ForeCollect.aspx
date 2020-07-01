<%@ Page Title="我的收藏" Language="C#" MasterPageFile="~/ForeManagement/ForeManagement.Master" AutoEventWireup="true" CodeBehind="ForeCollect.aspx.cs" Inherits="RunZe.ForeManagement.ForeCollect" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/ForeCollect.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadLV_splb">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadLV_splb" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="RadDataPager_1" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadDataPager_1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadLV_splb" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="RadDataPager_1" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
</telerik:RadAjaxManager>
    <div id="content_k">
        <div class="content_nav_kk">
            <div class="content_nav">
                <div class="content_nav_word">
                    我的收藏夹
                </div>
            </div>
        </div>
        <div class="content_k2">
            <div id="content">

                <telerik:RadListView ID="RadLV_splb" runat="server" DataKeyNames="AppriseID" OnItemCommand="RadLV_splb_ItemCommand" OnNeedDataSource="RadLV_splb_NeedDataSource" AllowPaging="true" PageSize="3" OnItemDataBound="RadLV_splb_ItemDataBound">
                    <ItemTemplate>
                            <table style="width: 180px; float: left" class="RadLV_splb_k">
                                <tr>
                                    <td>
                                        <a href="Forespxx.aspx?ID=<%#Eval ("CommodityID") %>">
                                            <asp:Image ID="Image3" runat="server" ImageUrl='<%#Eval("CommodityImage") %>' Width="100" Height="100" /></a>
                                    </td>
                                    <tr>
                                        <td>
                                            <div class="jiequ_k">
                                            <div class="jiequ">
                                                <a href="Forespxx.aspx?ID=<%#Eval ("CommodityID") %>"><%#Eval ("CommodityName") %></a>
                                            </div>
                                                </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <font color="Red">￥<%#Eval ("VIPPrice") %></font></s></td>
                                    </tr>
                                    <tr>
                                        <td>库存:<%#Eval ("Stock") %></td>
                                    </tr>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" CommandName="Join" CommandArgument='<%#Eval ("CommodityID") %>'>加入购物车</asp:LinkButton>
                                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton1_Click" CommandName="Delete" CommandArgument='<%#Eval ("AppriseID") %>'>删除</asp:LinkButton>

                                    </td>
                                </tr>
                        </table>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        <div class="error">
                            <asp:Image ID="Image2" runat="server" ImageUrl="~/image/none.png" />
                        </div>
                    </EmptyDataTemplate>
                </telerik:RadListView>

                <div class="content_fy">
                    <telerik:RadDataPager ID="RadDataPager_1" runat="server" PagedControlID="RadLV_splb" PageSize="3" Skin="Web20">
                        <Fields>
                            <telerik:RadDataPagerButtonField FieldType="FirstPrev" FirstButtonText="首页" PrevButtonText="上一页" />
                            <telerik:RadDataPagerButtonField FieldType="Numeric" />
                            <telerik:RadDataPagerButtonField FieldType="NextLast" LastButtonText="尾页" NextButtonText="下一页" />
                        </Fields>
                    </telerik:RadDataPager>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
