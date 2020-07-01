<%@ Page Title="商品列表" Language="C#" MasterPageFile="~/ForeManagement/ForeManagement.Master" AutoEventWireup="true" CodeBehind="Foresplb.aspx.cs" Inherits="RunZe.ForeManagement.WebForm1" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/menu.css" rel="stylesheet" />
    <link href="../css/public.css" rel="stylesheet" />
    <script src="../js/jquery.min.js"></script>
    <script src="../js/menu.js"></script>
    <link href="../css/Foresplb.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server"></telerik:RadAjaxManager>
    <div id="content">
        <div class="content_main_left">
            <div class="content_main_left_0">
                <div class="middle">
                    <div class="leftMenu">
                        <div class="topMenu">
                            <p class="menuTitle">
                                <asp:LinkButton ID="LinkButton3" CssClass="link1" runat="server" OnClick="LinkButton3_Click">全部商品分类</asp:LinkButton></p>
                        </div>
                        <div class="menu_list">
                            <ul>
                                <telerik:RadListView ID="RadLV_Father" runat="server" OnNeedDataSource="RadLV_Father_NeedDataSource" OnItemCommand="RadLV_Father_ItemCommand" OnItemDataBound="RadLV_Father_ItemDataBound" DataKeyNames="CommodityFatherID">
                                    <ItemTemplate>
                                        <li class="">
                                            <p class="fuMenu">
                                                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument=' <%#Eval ("CommodityFatherID") %>' OnClick="LinkButton2_Click"><%#Eval ("CommodityFatherName") %></asp:LinkButton>
                                            </p>
                                            <img class="xiala" src="../image/xiala.png" />
                                            <div class="div1">
                                                <telerik:RadListView ID="RadLV_Son" runat="server" OnNeedDataSource="RadLV_Son_NeedDataSource" OnItemCommand="RadLV_Son_ItemCommand">
                                                    <ItemTemplate>
                                                        <table style="width: 260px">
                                                            <tr>
                                                                <td>
                                                                    <p class="zcd" id="zcd1">
                                                                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument=' <%#Eval ("CommoditySonID") %>' OnClick="LinkButton1_Click"> <%#Eval ("CommoditySonName") %></asp:LinkButton>
                                                                    </p>
                                                                </td>
                                                        </table>
                                                    </ItemTemplate>
                                                </telerik:RadListView>
                                            </div>
                                        </li>
                                    </ItemTemplate>
                                </telerik:RadListView>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="content_main_right">
            <div class="content_main_right_head">
                <div class="content_main_right_head_word">
                    商品列表
                </div>
            </div>
            <div class="content_main_right_content">
                <telerik:RadListView ID="RadLV_splb" runat="server" OnItemCommand="RadLV_splb_ItemCommand" OnNeedDataSource="RadLV_splb_NeedDataSource" AllowPaging="true" PageSize="20" OnPageIndexChanged="RadLV_splb_PageIndexChanged">
                    <ItemTemplate>
                        <table style="width: 180px; float: left">
                            <tr>
                                <td>
                                    <a href="Forespxx.aspx?ID=<%#Eval ("CommodityID") %>">
                                        <asp:Image ID="Image3" runat="server" ImageUrl='<%#Eval("CommodityImage") %>' Width="100" Height="100" /></a>
                                </td>
                                <tr />
                                <tr>
                                    <td>
                                        <div class="jiequ">
                                            <a href="Forespxx.aspx?ID=<%#Eval ("CommodityID") %>"><%#Eval ("CommodityName") %></a>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <s>￥<%#Eval ("MarketPrice") %></s></td>
                                </tr>
                                <tr>
                                    <td>
                                        <font color="Red">￥<%#Eval ("VIPPrice") %></font></s></td>
                                </tr>
                            </tr>
                            <tr>
                                <td>
                                    <telerik:RadButton ID="RadButton1" runat="server" Text="购买" OnClick="RadButton1_Click" Skin="Web20" CommandName="buy" CommandArgument='<%#Eval("CommodityID") %>'></telerik:RadButton>
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
            </div>
            <div class="content_main_right_fy">
                <telerik:RadDataPager ID="RadDataPager_1" runat="server" PagedControlID="RadLV_splb" PageSize="20" Skin="Web20">
                    <Fields>
                        <telerik:RadDataPagerButtonField FieldType="FirstPrev" FirstButtonText="首页" PrevButtonText="上一页" />
                        <telerik:RadDataPagerButtonField FieldType="Numeric" />
                        <telerik:RadDataPagerButtonField FieldType="NextLast" LastButtonText="尾页" NextButtonText="下一页" />
                    </Fields>
                </telerik:RadDataPager>

            </div>
        </div>
    </div>
</asp:Content>
